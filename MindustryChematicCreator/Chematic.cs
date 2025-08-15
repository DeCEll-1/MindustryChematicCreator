using CsvHelper;
using MindustryChematicCreator;
using MindustryChematicCreator.Configs;
using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MindustrySchematicCreator
{
    public class Chematic : ICloneable
    {
        public List<Block> Blocks { get; private set; } = new();
        private Dictionary<string, string> Tags = new();
        public string Name { get => Tags["name"]; set => Tags["name"] = value; }
        public List<string> Labels = new();
        private Dictionary<(int, int), Block> FilledList = new();

        public Chematic() { this.Name = "unnamed"; }

        public bool AddBlock(Block block)
        {
            if (CheckOffsetForBlock(block.xOffset, block.yOffset) is not null)
                return false;

            this.Blocks.Add(block);

            //int halfSize = (block.data.Size - 1) / 2;
            //int upperSize = block.data.Size / 2;

            //for (int x = -halfSize; x <= upperSize; x++)
            //{
            //    for (int y = -halfSize; y <= upperSize; y++)
            //    {
            //        this.FilledList.Add((x + block.xOffset, y + block.yOffset), block);
            //    }
            //}

            for (int x = 0; x < block.data.Size; x++)
            {
                for (int y = 0; y < block.data.Size; y++)
                {
                    this.FilledList.Add((x + block.xOffset, y + block.yOffset), block);
                }
            }

            return true;
        }

        public Block? CheckOffsetForBlock(int x, int y)
        {
            if (FilledList.TryGetValue((x, y), out Block? foundBlock))
                return foundBlock;
            return null;
        }

        public (int width, int height, int xOffset, int yOffset) GetSize()
        {
            if (FilledList.Count == 0)
            {
                return (0, 0, 0, 0);
            }
            Block defaults = FilledList.First().Value;

            int biggestFilledBlockX = defaults.xOffset;
            int biggestFilledBlockY = defaults.xOffset;

            int smallestFilledBlockX = defaults.xOffset;
            int smallestFilledBlockY = defaults.xOffset;

            foreach (KeyValuePair<(int, int), Block> pair in FilledList)
            {
                (int blockX, int blockY) = pair.Key;

                biggestFilledBlockX = Math.Max(biggestFilledBlockX, blockX + 1);
                biggestFilledBlockY = Math.Max(biggestFilledBlockY, blockY + 1);

                smallestFilledBlockX = Math.Min(smallestFilledBlockX, blockX);
                smallestFilledBlockY = Math.Min(smallestFilledBlockY, blockY);
            }
            int width = 0;
            int height = 0;
            int xOffset = 0;
            int yOffset = 0;

            width = biggestFilledBlockX - smallestFilledBlockX;
            height = biggestFilledBlockY - smallestFilledBlockY;
            xOffset = smallestFilledBlockX;
            yOffset = smallestFilledBlockY;

            return
                (
                    width,
                    height,
                    -xOffset,
                    -yOffset
                );
        }

        public byte[] WriteToByteArray()
        {
            Chematic chem = (Chematic)this.Clone();

            List<BlockData> UsedBlocks = new();

            foreach (Block block in chem.Blocks)
                if (!UsedBlocks.Exists(s => s.Name == block.data.Name))
                    UsedBlocks.Add(block.data);


            (int width, int height, int xOffset, int yOffset) = chem.GetSize();

            foreach (Block block in chem.Blocks)
            {
                block.xOffset += xOffset;
                block.yOffset += yOffset;
            }

            using MemoryStream ms = new MemoryStream();
            using BinaryWriter writer = new BinaryWriter(ms);


            ByteUtils.WriteUInt16BigEndian(writer, (ushort)width);// 2 bytes
            ByteUtils.WriteUInt16BigEndian(writer, (ushort)height);// 2 bytes

            string labelString = $"[{string.Join(',', chem.Labels)}]";
            this.Tags.Add("labels", labelString);

            writer.Write((byte)Tags.Count); // 1 byte

            foreach (KeyValuePair<string, string> pair in Tags)
            {
                ByteUtils.WriteUTF(writer, pair.Key);
                ByteUtils.WriteUTF(writer, pair.Value);
            }

            writer.Write((byte)UsedBlocks.Count); // 1 byte

            // replace _ with - as we were using _s for -s in the enums
            UsedBlocks.ForEach(block => ByteUtils.WriteUTF(writer, block.Name.Replace("_", "-")));

            ByteUtils.WriteInt32BigEndian(writer, Blocks.Count); // 4 bytes

            foreach (Block block in Blocks)
            {
                writer.Write((byte)UsedBlocks.IndexOf(block.data));
                (int x, int y) = BottomLeftOriginToCenter(block.xOffset, block.yOffset, block.data.Size);
                ByteUtils.WriteUInt16BigEndian(writer, (ushort)x);// 2 bytes
                ByteUtils.WriteUInt16BigEndian(writer, (ushort)y);// 2 bytes
                block.config.Compress(writer);
                writer.Write((byte)block.rotation);
            }

            byte[] header = Encoding.ASCII.GetBytes("msch\x01");

            byte[] result = ms.ToArray();

            return header.Concat(CompressionUtils.Compress(result)).ToArray();
        }
        public string GetBase64() => Convert.ToBase64String(WriteToByteArray());
        private static readonly Dictionary<byte, BlockConfig> ConfigLookupTable = new()
        {
            { 0 ,new NullConfig()},
            { 14, new LogicCodeConfig() }
        };
        public static Chematic FromBytes(byte[] data)
        {

            if (data.Length < 4 || data[0] != 'm' || data[1] != 's' || data[2] != 'c' || data[3] != 'h')
                throw new Exception("Invalid msch data");


            Chematic chem = new Chematic();
            data = data.Skip(5).ToArray();

            data = CompressionUtils.Decompress(data);

            using MemoryStream ms = new MemoryStream(data);
            using BinaryReader reader = new(ms);

            short width = ByteUtils.ReadInt16BigEndian(reader); // width
            short height = ByteUtils.ReadInt16BigEndian(reader); // height

            int tagCount = reader.ReadByte(); // tag count

            for (int i = 0; i < tagCount; i++)
            {
                string tag = ByteUtils.ReadUTF(reader);
                string value = ByteUtils.ReadUTF(reader);
                chem.Tags[tag] = value;
            }

            if (chem.Tags["labels"] != "[]")
            {
                string labelsString = chem.Tags["labels"];

                chem.Labels = chem.Tags["labels"].Substring(1, labelsString.Length - 2).Split(',').ToList();
            }

            List<string> UsedBlocks = new();

            int blockTypeCount = reader.ReadByte();

            for (int i = 0; i < blockTypeCount; i++)
            {
                UsedBlocks.Add(ByteUtils.ReadUTF(reader));
            }

            int blockCount = ByteUtils.ReadInt32BigEndian(reader);

            for (int i = 0; i < blockCount; i++)
            {
                byte blockTypeIndex = reader.ReadByte();
                int blockX = ByteUtils.ReadUInt16BigEndian(reader);
                int blockY = ByteUtils.ReadUInt16BigEndian(reader);

                byte configID = reader.ReadByte();
                BlockConfig config = ConfigLookupTable[configID].Clone();
                config.DecompressFrom(reader);

                byte rotation = reader.ReadByte();

                BlockData blockData = BlockData.Blocks[Enum.Parse<BlockType>(UsedBlocks[blockTypeIndex].Replace("-", "_"))];

                (int x, int y) = CenterToBottomLeftOrigin(blockX, blockY, blockData.Size);

                chem.AddBlock(new(blockData, blockX, blockY, rotation, config));
            }

            return chem;
        }
        public static Chematic FromBase64(string chem) => FromBytes(Convert.FromBase64String(chem));

        private static (int x, int y) BottomLeftOriginToCenter(int x, int y, int size)
        {
            int halfSize = (size - 1) / 2;
            return (x + halfSize, y + halfSize);
        }

        private static (int x, int y) CenterToBottomLeftOrigin(int x, int y, int size)
        {
            int halfSize = (size - 1) / 2;
            return (x - halfSize, y - halfSize);
        }
        public object Clone()
        {
            return new Chematic()
            {
                Blocks = new(this.Blocks),
                FilledList = new(this.FilledList),
                Labels = new(this.Labels),
                Tags = new(this.Tags),
            };
        }
    }
}

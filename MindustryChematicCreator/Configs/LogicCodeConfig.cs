using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MindustryChematicCreator.Configs
{
    public record ProcessorLink(int x, int y, string name);
    public class LogicCodeConfig : BlockConfig
    {
        public override BlockConfig Clone() => new LogicCodeConfig();
        public override byte ID => 14;


        public string Code { get; set; } = "";

        public List<ProcessorLink> Links = new();
        public LogicCodeConfig() { }

        public override void Compress(BinaryWriter writer)
        {
            using MemoryStream ms = new MemoryStream();
            using BinaryWriter logicCodeCompressor = new BinaryWriter(ms);

            logicCodeCompressor.Write((byte)1); // 1 byte
            byte[] codeBytes = Encoding.ASCII.GetBytes(this.Code);

            ByteUtils.WriteInt32BigEndian(logicCodeCompressor, codeBytes.Length);
            logicCodeCompressor.Write(codeBytes);

            ByteUtils.WriteInt32BigEndian(logicCodeCompressor, this.Links.Count);

            foreach (ProcessorLink link in this.Links)
            {
                byte[] linkName = Encoding.UTF8.GetBytes(link.name);
                ByteUtils.WriteUInt16BigEndian(logicCodeCompressor, (ushort)linkName.Length);
                logicCodeCompressor.Write(linkName);
                ByteUtils.WriteUInt16BigEndian(logicCodeCompressor, (ushort)link.x);
                ByteUtils.WriteUInt16BigEndian(logicCodeCompressor, (ushort)link.y);
            }

            byte[] result = CompressionUtils.Compress(ms.ToArray());

            byte[] configID = [ID];
            // lenght + config id
            byte[] header = configID.Concat(BitConverter.GetBytes(result.Length)).ToArray();

            writer.Write(header.Concat(result).ToArray());
        }

        public override void DecompressFrom(BinaryReader reader)
        {
            int len = ByteUtils.ReadInt32BigEndian(reader);

            byte[] decompressedData = CompressionUtils.Decompress(reader.ReadBytes(len));

            using MemoryStream ms = new MemoryStream(decompressedData);
            reader = new BinaryReader(ms);

            // discard version byte
            reader.ReadByte();

            int codeLength = ByteUtils.ReadInt32BigEndian(reader); // 4 byte
            byte[] codeBytes = reader.ReadBytes(codeLength);
            string code = Encoding.ASCII.GetString(codeBytes);

            int linkCount = ByteUtils.ReadInt32BigEndian(reader); // 4 byte
            var links = new List<ProcessorLink>();
            for (int i = 0; i < linkCount; i++)
            {

                ushort nameLength = ByteUtils.ReadUInt16BigEndian(reader); // 2 byte length
                byte[] nameBytes = reader.ReadBytes(nameLength);
                string name = Encoding.UTF8.GetString(nameBytes);
                short x = ByteUtils.ReadInt16BigEndian(reader); // 2 byte
                short y = ByteUtils.ReadInt16BigEndian(reader); // 2 byte
                links.Add(new ProcessorLink(x, y, name));
            }

            this.Code = code;
            this.Links = links;
        }
    }
}

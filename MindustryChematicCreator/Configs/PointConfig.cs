using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindustryChematicCreator.Configs
{
    public class PointConfig : BlockConfig
    { // for stuff like surge towers and the mass launcher thingies
        public override byte ID => 7;
        public int targetX = 0;
        public int targetY = 0;
        public override BlockConfig Clone()
        {
            return new PointConfig()
            {
                targetX = targetX,
                targetY = targetY,
            };
        }

        public override void Compress(BinaryWriter writer)
        {
            writer.Write(ID);
            ByteUtils.WriteInt32BigEndian(writer, targetX);
            ByteUtils.WriteInt32BigEndian(writer, targetY);
        }

        public override void DecompressFrom(BinaryReader reader)
        {
            reader.ReadByte();
            this.targetX = ByteUtils.ReadInt32BigEndian(reader);
            this.targetY = ByteUtils.ReadInt32BigEndian(reader);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindustryChematicCreator.Configs
{
    public class NullConfig : BlockConfig
    {
        public override byte ID { get => 0; }

        public override BlockConfig Clone() => new NullConfig();


        // null config for objects without config
        public override void Compress(BinaryWriter writer) => writer.Write(ID);
        public override void DecompressFrom(BinaryReader reader) { }
    }
}

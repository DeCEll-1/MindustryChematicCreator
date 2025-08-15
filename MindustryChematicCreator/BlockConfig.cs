using System.Runtime.InteropServices;

namespace MindustryChematicCreator
{
    public abstract class BlockConfig
    {
        public abstract byte ID { get; }

        public abstract BlockConfig Clone();

        public abstract void Compress(BinaryWriter writer);
        public abstract void DecompressFrom(BinaryReader reader);

    }



}
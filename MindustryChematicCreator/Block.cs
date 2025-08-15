using MindustryChematicCreator;
using MindustryChematicCreator.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindustrySchematicCreator
{
    public class Block
    {

        public BlockData data;
        public int xOffset;
        public int yOffset;
        public BlockConfig config;
        public int rotation;

        public Block(BlockData data, int xOffset, int yOffset, int rotation = 0, BlockConfig? config = null)
        {
            this.data = data;
            this.xOffset = xOffset;
            this.yOffset = yOffset;
            this.config = config ?? new NullConfig();
            this.rotation = rotation;
        }

        public Block Clone()
        {
            return new Block(data, xOffset, yOffset, rotation, config: this.config);
        }
    }
}

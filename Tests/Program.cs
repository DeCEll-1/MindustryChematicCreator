using MindustryChematicCreator;
using MindustryChematicCreator.Configs;
using MindustrySchematicCreator;

namespace Tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chematic chem = new Chematic();

            Block block = new Block(BlockData.Blocks[BlockType.copper_wall], 0, 0);
            chem.AddBlock(block);

            block = block.Clone();
            block.xOffset = 1;
            chem.AddBlock(block);

            Block largeBlock = new Block(BlockData.Blocks[BlockType.copper_wall_large], 0, 1);
            chem.AddBlock(largeBlock);

            Block fuse = new Block(BlockData.Blocks[BlockType.fuse], 2, 0);
            chem.AddBlock(fuse);

            Block foreshadow = new Block(BlockData.Blocks[BlockType.foreshadow], 5, 1);
            chem.AddBlock(foreshadow);

            string res = chem.GetBase64();
            Console.WriteLine(res);

            var k = Chematic.FromBase64("bXNjaAF4nGNgZGBkZmDJS8xNZWApSc0tYOBOSS1OLsosKMnMz2NgYGDLSUxKzSlmYIqOZWTgz81MLsrXLSjKT04tLs4vAsozMoAAHxDLVsxJTklIeKCrceqMdmCAl/Yp//BHTFwGDAzGH1giGACiOhxe");

            foreach (Block chemBlock in k.Blocks)
            {
                Console.WriteLine($"{chemBlock.data.Name} : {chemBlock.xOffset}, {chemBlock.yOffset} ");

                if (chemBlock.config is LogicCodeConfig logicConfig)
                {
                    Console.WriteLine(logicConfig.Code);
                } 
            }


        }
    }
}

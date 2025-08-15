using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace MindustryChematicCreator
{

    public class BlockData
    {

        public readonly static Dictionary<BlockType, BlockData> Blocks = new();
        public string Name { get; }
        public int ID { get; }
        public int LogicId { get; }
        public string Visibility { get; }
        public int Size { get; }
        public string Subclass { get; }
        public bool Legacy { get; }
        public bool Configurable { get; }
        public string Category { get; }
        public float Range { get; }
        public bool HasItems { get; }
        public bool AcceptsItems { get; }
        public bool SeparateItemCapacity { get; }
        public int ItemCapacity { get; }
        public bool NoSideBlend { get; }
        public bool Unloadable { get; }
        public bool HasLiquids { get; }
        public bool OutputsLiquid { get; }
        public float LiquidCapacity { get; }
        public bool HasPower { get; }
        public bool ConsumesPower { get; }
        public bool OutputsPower { get; }
        public bool ConnectedPower { get; }
        public bool ConductivePower { get; }
        public int MaxNodes { get; }
        public bool OutputFacing { get; }
        public bool Rotate { get; }
        public string UnitPlans { get; }

        private BlockData(
                string Name, int ID, int LogicId, string Visibility, int Size, string Subclass, bool Legacy, bool Configurable, string Category, float Range, bool HasItems, bool AcceptsItems, bool SeparateItemCapacity, int ItemCapacity, bool NoSideBlend, bool Unloadable, bool HasLiquids, bool OutputsLiquid, float LiquidCapacity, bool HasPower, bool ConsumesPower, bool OutputsPower, bool ConnectedPower, bool ConductivePower, int MaxNodes, bool OutputFacing, bool Rotate, string UnitPlans)
        {
            this.Name = Name;
            this.ID = ID;
            this.LogicId = LogicId;
            this.Visibility = Visibility;
            this.Size = Size;
            this.Subclass = Subclass;
            this.Legacy = Legacy;
            this.Configurable = Configurable;
            this.Category = Category;
            this.Range = Range;
            this.HasItems = HasItems;
            this.AcceptsItems = AcceptsItems;
            this.SeparateItemCapacity = SeparateItemCapacity;
            this.ItemCapacity = ItemCapacity;
            this.NoSideBlend = NoSideBlend;
            this.Unloadable = Unloadable;
            this.HasLiquids = HasLiquids;
            this.OutputsLiquid = OutputsLiquid;
            this.LiquidCapacity = LiquidCapacity;
            this.HasPower = HasPower;
            this.ConsumesPower = ConsumesPower;
            this.OutputsPower = OutputsPower;
            this.ConnectedPower = ConnectedPower;
            this.ConductivePower = ConductivePower;
            this.MaxNodes = MaxNodes;
            this.OutputFacing = OutputFacing;
            this.Rotate = Rotate;
            this.UnitPlans = UnitPlans;
        }


        static BlockData()
        {
            Blocks.Add(MindustryChematicCreator.BlockType.air, new("air", 0, -1, "hidden", 1, "AirBlock", false, false, "distribution", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.spawn, new("spawn", 1, -1, "hidden", 1, "SpawnBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.remove_wall, new("remove-wall", 2, -1, "hidden", 1, "RemoveWall", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.remove_ore, new("remove-ore", 3, -1, "hidden", 1, "RemoveOre", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.cliff, new("cliff", 4, -1, "hidden", 1, "Cliff", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.build1, new("build1", 5, -1, "hidden", 1, "ConstructBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.build2, new("build2", 6, -1, "hidden", 2, "ConstructBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.build3, new("build3", 7, -1, "hidden", 3, "ConstructBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.build4, new("build4", 8, -1, "hidden", 4, "ConstructBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.build5, new("build5", 9, -1, "hidden", 5, "ConstructBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.build6, new("build6", 10, -1, "hidden", 6, "ConstructBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.build7, new("build7", 11, -1, "hidden", 7, "ConstructBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.build8, new("build8", 12, -1, "hidden", 8, "ConstructBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.build9, new("build9", 13, -1, "hidden", 9, "ConstructBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.build10, new("build10", 14, -1, "hidden", 10, "ConstructBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.build11, new("build11", 15, -1, "hidden", 11, "ConstructBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.build12, new("build12", 16, -1, "hidden", 12, "ConstructBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.build13, new("build13", 17, -1, "hidden", 13, "ConstructBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.build14, new("build14", 18, -1, "hidden", 14, "ConstructBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.build15, new("build15", 19, -1, "hidden", 15, "ConstructBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.build16, new("build16", 20, -1, "hidden", 16, "ConstructBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.deep_water, new("deep-water", 21, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.shallow_water, new("shallow-water", 22, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.tainted_water, new("tainted-water", 23, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.deep_tainted_water, new("deep-tainted-water", 24, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.darksand_tainted_water, new("darksand-tainted-water", 25, -1, "hidden", 1, "ShallowLiquid", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.sand_water, new("sand-water", 26, -1, "hidden", 1, "ShallowLiquid", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.darksand_water, new("darksand-water", 27, -1, "hidden", 1, "ShallowLiquid", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.tar, new("tar", 28, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.pooled_cryofluid, new("pooled-cryofluid", 29, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.molten_slag, new("molten-slag", 30, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.space, new("space", 31, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.empty, new("empty", 32, -1, "hidden", 1, "EmptyFloor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.stone, new("stone", 33, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.crater_stone, new("crater-stone", 34, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.char_block, new("char", 35, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.basalt, new("basalt", 36, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.hotrock, new("hotrock", 37, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.magmarock, new("magmarock", 38, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.sand_floor, new("sand-floor", 39, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.darksand, new("darksand", 40, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.dirt, new("dirt", 41, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.mud, new("mud", 42, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.dacite, new("dacite", 43, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.rhyolite, new("rhyolite", 44, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.rhyolite_crater, new("rhyolite-crater", 45, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.rough_rhyolite, new("rough-rhyolite", 46, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.regolith, new("regolith", 47, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.yellow_stone, new("yellow-stone", 48, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.carbon_stone, new("carbon-stone", 49, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.ferric_stone, new("ferric-stone", 50, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.ferric_craters, new("ferric-craters", 51, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.beryllic_stone, new("beryllic-stone", 52, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.crystalline_stone, new("crystalline-stone", 53, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.crystal_floor, new("crystal-floor", 54, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.yellow_stone_plates, new("yellow-stone-plates", 55, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.red_stone, new("red-stone", 56, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.dense_red_stone, new("dense-red-stone", 57, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.red_ice, new("red-ice", 58, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.arkycite_floor, new("arkycite-floor", 59, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.arkyic_stone, new("arkyic-stone", 60, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.rhyolite_vent, new("rhyolite-vent", 61, -1, "hidden", 1, "SteamVent", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.carbon_vent, new("carbon-vent", 62, -1, "hidden", 1, "SteamVent", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.arkyic_vent, new("arkyic-vent", 63, -1, "hidden", 1, "SteamVent", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.yellow_stone_vent, new("yellow-stone-vent", 64, -1, "hidden", 1, "SteamVent", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.red_stone_vent, new("red-stone-vent", 65, -1, "hidden", 1, "SteamVent", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.crystalline_vent, new("crystalline-vent", 66, -1, "hidden", 1, "SteamVent", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.stone_vent, new("stone-vent", 67, -1, "hidden", 1, "SteamVent", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.basalt_vent, new("basalt-vent", 68, -1, "hidden", 1, "SteamVent", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.redmat, new("redmat", 69, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.bluemat, new("bluemat", 70, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.grass, new("grass", 71, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.salt, new("salt", 72, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.snow, new("snow", 73, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.ice, new("ice", 74, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.ice_snow, new("ice-snow", 75, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.shale, new("shale", 76, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.moss, new("moss", 77, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.core_zone, new("core-zone", 78, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.spore_moss, new("spore-moss", 79, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.stone_wall, new("stone-wall", 80, -1, "hidden", 1, "StaticWall", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.spore_wall, new("spore-wall", 81, -1, "hidden", 1, "StaticWall", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.dirt_wall, new("dirt-wall", 82, -1, "hidden", 1, "StaticWall", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.dacite_wall, new("dacite-wall", 83, -1, "hidden", 1, "StaticWall", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.ice_wall, new("ice-wall", 84, -1, "hidden", 1, "StaticWall", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.snow_wall, new("snow-wall", 85, -1, "hidden", 1, "StaticWall", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.dune_wall, new("dune-wall", 86, -1, "hidden", 1, "StaticWall", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.regolith_wall, new("regolith-wall", 87, -1, "hidden", 1, "StaticWall", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.yellow_stone_wall, new("yellow-stone-wall", 88, -1, "hidden", 1, "StaticWall", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.rhyolite_wall, new("rhyolite-wall", 89, -1, "hidden", 1, "StaticWall", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.carbon_wall, new("carbon-wall", 90, -1, "hidden", 1, "StaticWall", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.ferric_stone_wall, new("ferric-stone-wall", 91, -1, "hidden", 1, "StaticWall", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.beryllic_stone_wall, new("beryllic-stone-wall", 92, -1, "hidden", 1, "StaticWall", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.arkyic_wall, new("arkyic-wall", 93, -1, "hidden", 1, "StaticWall", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.crystalline_stone_wall, new("crystalline-stone-wall", 94, -1, "hidden", 1, "StaticWall", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.red_ice_wall, new("red-ice-wall", 95, -1, "hidden", 1, "StaticWall", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.red_stone_wall, new("red-stone-wall", 96, -1, "hidden", 1, "StaticWall", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.red_diamond_wall, new("red-diamond-wall", 97, -1, "hidden", 1, "StaticTree", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.sand_wall, new("sand-wall", 98, -1, "hidden", 1, "StaticWall", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.salt_wall, new("salt-wall", 99, -1, "hidden", 1, "StaticWall", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.shrubs, new("shrubs", 100, -1, "hidden", 1, "StaticWall", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.shale_wall, new("shale-wall", 101, -1, "hidden", 1, "StaticWall", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.spore_pine, new("spore-pine", 102, -1, "hidden", 1, "StaticTree", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.snow_pine, new("snow-pine", 103, -1, "hidden", 1, "StaticTree", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.pine, new("pine", 104, -1, "hidden", 1, "StaticTree", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.white_tree_dead, new("white-tree-dead", 105, -1, "hidden", 1, "TreeBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.white_tree, new("white-tree", 106, -1, "hidden", 1, "TreeBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.spore_cluster, new("spore-cluster", 107, -1, "hidden", 1, "Prop", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.redweed, new("redweed", 108, -1, "hidden", 1, "Seaweed", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.pur_bush, new("pur-bush", 109, -1, "hidden", 1, "SeaBush", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.yellowcoral, new("yellowcoral", 110, -1, "hidden", 1, "SeaBush", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.boulder, new("boulder", 111, -1, "hidden", 1, "Prop", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.snow_boulder, new("snow-boulder", 112, -1, "hidden", 1, "Prop", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.shale_boulder, new("shale-boulder", 113, -1, "hidden", 1, "Prop", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.sand_boulder, new("sand-boulder", 114, -1, "hidden", 1, "Prop", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.dacite_boulder, new("dacite-boulder", 115, -1, "hidden", 1, "Prop", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.basalt_boulder, new("basalt-boulder", 116, -1, "hidden", 1, "Prop", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.carbon_boulder, new("carbon-boulder", 117, -1, "hidden", 1, "Prop", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.ferric_boulder, new("ferric-boulder", 118, -1, "hidden", 1, "Prop", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.beryllic_boulder, new("beryllic-boulder", 119, -1, "hidden", 1, "Prop", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.yellow_stone_boulder, new("yellow-stone-boulder", 120, -1, "hidden", 1, "Prop", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.arkyic_boulder, new("arkyic-boulder", 121, -1, "hidden", 1, "Prop", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.crystal_cluster, new("crystal-cluster", 122, -1, "hidden", 1, "TallBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.vibrant_crystal_cluster, new("vibrant-crystal-cluster", 123, -1, "hidden", 1, "TallBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.crystal_blocks, new("crystal-blocks", 124, -1, "hidden", 1, "TallBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.crystal_orbs, new("crystal-orbs", 125, -1, "hidden", 1, "TallBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.crystalline_boulder, new("crystalline-boulder", 126, -1, "hidden", 1, "Prop", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.red_ice_boulder, new("red-ice-boulder", 127, -1, "hidden", 1, "Prop", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.rhyolite_boulder, new("rhyolite-boulder", 128, -1, "hidden", 1, "Prop", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.red_stone_boulder, new("red-stone-boulder", 129, -1, "hidden", 1, "Prop", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.metal_floor, new("metal-floor", 130, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.metal_floor_damaged, new("metal-floor-damaged", 131, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.metal_floor_2, new("metal-floor-2", 132, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.metal_floor_3, new("metal-floor-3", 133, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.metal_floor_4, new("metal-floor-4", 134, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.metal_floor_5, new("metal-floor-5", 135, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.dark_panel_1, new("dark-panel-1", 136, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.dark_panel_2, new("dark-panel-2", 137, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.dark_panel_3, new("dark-panel-3", 138, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.dark_panel_4, new("dark-panel-4", 139, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.dark_panel_5, new("dark-panel-5", 140, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.dark_panel_6, new("dark-panel-6", 141, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.dark_metal, new("dark-metal", 142, -1, "hidden", 1, "StaticWall", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.metal_tiles_1, new("metal-tiles-1", 143, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.metal_tiles_2, new("metal-tiles-2", 144, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.metal_tiles_3, new("metal-tiles-3", 145, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.metal_tiles_4, new("metal-tiles-4", 146, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.metal_tiles_5, new("metal-tiles-5", 147, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.metal_tiles_6, new("metal-tiles-6", 148, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.metal_tiles_7, new("metal-tiles-7", 149, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.metal_tiles_8, new("metal-tiles-8", 150, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.metal_tiles_9, new("metal-tiles-9", 151, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.metal_tiles_10, new("metal-tiles-10", 152, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.metal_tiles_11, new("metal-tiles-11", 153, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.metal_tiles_12, new("metal-tiles-12", 154, -1, "hidden", 1, "Floor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.colored_floor, new("colored-floor", 155, -1, "hidden", 1, "ColoredFloor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.colored_wall, new("colored-wall", 156, -1, "hidden", 1, "ColoredWall", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.character_overlay, new("character-overlay", 157, -1, "hidden", 1, "CharacterOverlay", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.character_overlay_white, new("character-overlay-white", 158, -1, "hidden", 1, "CharacterOverlay", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.pebbles, new("pebbles", 159, -1, "hidden", 1, "OverlayFloor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.tendrils, new("tendrils", 160, -1, "hidden", 1, "OverlayFloor", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.ore_copper, new("ore-copper", 161, -1, "hidden", 1, "OreBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.ore_lead, new("ore-lead", 162, -1, "hidden", 1, "OreBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.ore_scrap, new("ore-scrap", 163, -1, "hidden", 1, "OreBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.ore_coal, new("ore-coal", 164, -1, "hidden", 1, "OreBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.ore_titanium, new("ore-titanium", 165, -1, "hidden", 1, "OreBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.ore_thorium, new("ore-thorium", 166, -1, "hidden", 1, "OreBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.ore_beryllium, new("ore-beryllium", 167, -1, "hidden", 1, "OreBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.ore_tungsten, new("ore-tungsten", 168, -1, "hidden", 1, "OreBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.ore_crystal_thorium, new("ore-crystal-thorium", 169, -1, "hidden", 1, "OreBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.ore_wall_thorium, new("ore-wall-thorium", 170, -1, "hidden", 1, "OreBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.ore_wall_beryllium, new("ore-wall-beryllium", 171, -1, "hidden", 1, "OreBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.graphitic_wall, new("graphitic-wall", 172, -1, "hidden", 1, "StaticWall", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.ore_wall_tungsten, new("ore-wall-tungsten", 173, -1, "hidden", 1, "OreBlock", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.graphite_press, new("graphite-press", 174, 0, "shown", 2, "GenericCrafter", false, false, "crafting", 0, true, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.multi_press, new("multi-press", 175, 1, "shown", 3, "GenericCrafter", false, false, "crafting", 0, true, true, false, 20, false, true, true, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.silicon_smelter, new("silicon-smelter", 176, 2, "shown", 2, "GenericCrafter", false, false, "crafting", 0, true, true, false, 10, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.silicon_crucible, new("silicon-crucible", 177, 3, "shown", 3, "AttributeCrafter", false, false, "crafting", 0, true, true, false, 30, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.kiln, new("kiln", 178, 4, "shown", 2, "GenericCrafter", false, false, "crafting", 0, true, true, false, 10, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.plastanium_compressor, new("plastanium-compressor", 179, 5, "shown", 2, "GenericCrafter", false, false, "crafting", 0, true, true, false, 10, false, true, true, false, 60, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.phase_weaver, new("phase-weaver", 180, 6, "shown", 2, "GenericCrafter", false, false, "crafting", 0, true, true, false, 30, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.surge_smelter, new("surge-smelter", 181, 180, "shown", 3, "GenericCrafter", false, false, "crafting", 0, true, true, false, 20, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.cryofluid_mixer, new("cryofluid-mixer", 182, 7, "shown", 2, "GenericCrafter", false, false, "crafting", 0, true, true, false, 10, false, true, true, true, 36, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.pyratite_mixer, new("pyratite-mixer", 183, 8, "shown", 2, "GenericCrafter", false, false, "crafting", 0, true, true, false, 10, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.blast_mixer, new("blast-mixer", 184, 9, "shown", 2, "GenericCrafter", false, false, "crafting", 0, true, true, false, 10, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.melter, new("melter", 185, 10, "shown", 1, "GenericCrafter", false, false, "crafting", 0, true, true, false, 10, false, true, true, true, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.separator, new("separator", 186, 11, "shown", 2, "Separator", false, false, "crafting", 0, true, false, false, 10, false, true, true, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.disassembler, new("disassembler", 187, 12, "shown", 3, "Separator", false, false, "crafting", 0, true, true, false, 20, false, true, true, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.spore_press, new("spore-press", 188, 13, "shown", 2, "GenericCrafter", false, false, "crafting", 0, true, true, false, 10, false, true, true, true, 60, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.pulverizer, new("pulverizer", 189, 14, "shown", 1, "GenericCrafter", false, false, "crafting", 0, true, true, false, 10, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.coal_centrifuge, new("coal-centrifuge", 190, 15, "shown", 2, "GenericCrafter", false, false, "crafting", 0, true, false, false, 10, false, true, true, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.incinerator, new("incinerator", 191, 16, "shown", 1, "Incinerator", false, false, "crafting", 0, false, false, false, 10, false, true, true, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.silicon_arc_furnace, new("silicon-arc-furnace", 192, 153, "shown", 3, "GenericCrafter", false, false, "crafting", 0, true, true, false, 30, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.electrolyzer, new("electrolyzer", 193, 178, "shown", 3, "GenericCrafter", false, false, "crafting", 0, true, false, false, 0, false, true, true, true, 50, true, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.atmospheric_concentrator, new("atmospheric-concentrator", 194, 192, "shown", 3, "HeatCrafter", false, false, "crafting", 0, true, false, false, 0, false, true, true, true, 60, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.oxidation_chamber, new("oxidation-chamber", 195, 179, "shown", 3, "HeatProducer", false, false, "crafting", 0, true, true, false, 10, false, true, true, false, 30, true, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.electric_heater, new("electric-heater", 196, 186, "shown", 2, "HeatProducer", false, false, "crafting", 0, true, false, false, 0, false, true, false, false, 10, true, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.slag_heater, new("slag-heater", 197, 238, "shown", 3, "HeatProducer", false, false, "crafting", 0, true, false, false, 0, false, true, true, false, 120, false, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.phase_heater, new("phase-heater", 198, 201, "shown", 2, "HeatProducer", false, false, "crafting", 0, true, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.heat_redirector, new("heat-redirector", 199, 202, "shown", 3, "HeatConductor", false, false, "crafting", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.small_heat_redirector, new("small-heat-redirector", 200, 255, "shown", 2, "HeatConductor", false, false, "crafting", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.heat_router, new("heat-router", 201, 250, "shown", 3, "HeatConductor", false, false, "crafting", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.slag_incinerator, new("slag-incinerator", 202, 187, "shown", 1, "ItemIncinerator", false, false, "crafting", 0, false, false, false, 10, false, true, true, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.carbide_crucible, new("carbide-crucible", 203, 164, "shown", 3, "HeatCrafter", false, false, "crafting", 0, true, true, false, 20, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.slag_centrifuge, new("slag-centrifuge", 204, 185, "debugonly", 3, "GenericCrafter", false, false, "crafting", 0, true, true, false, 10, false, true, true, true, 80, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.surge_crucible, new("surge-crucible", 205, 181, "shown", 3, "HeatCrafter", false, false, "crafting", 0, true, true, false, 20, false, true, true, false, 400, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.cyanogen_synthesizer, new("cyanogen-synthesizer", 206, 184, "shown", 3, "HeatCrafter", false, false, "crafting", 0, true, true, false, 10, false, true, true, true, 80, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.phase_synthesizer, new("phase-synthesizer", 207, 188, "shown", 3, "HeatCrafter", false, false, "crafting", 0, true, true, false, 40, false, true, true, false, 40, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.heat_reactor, new("heat-reactor", 208, 175, "debugonly", 3, "HeatProducer", false, false, "crafting", 0, true, true, false, 20, false, true, true, false, 10, false, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.copper_wall, new("copper-wall", 209, 17, "shown", 1, "Wall", false, false, "defense", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.copper_wall_large, new("copper-wall-large", 210, 18, "shown", 2, "Wall", false, false, "defense", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.titanium_wall, new("titanium-wall", 211, 19, "shown", 1, "Wall", false, false, "defense", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.titanium_wall_large, new("titanium-wall-large", 212, 20, "shown", 2, "Wall", false, false, "defense", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.plastanium_wall, new("plastanium-wall", 213, 21, "shown", 1, "Wall", false, false, "defense", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.plastanium_wall_large, new("plastanium-wall-large", 214, 22, "shown", 2, "Wall", false, false, "defense", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.thorium_wall, new("thorium-wall", 215, 23, "shown", 1, "Wall", false, false, "defense", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.thorium_wall_large, new("thorium-wall-large", 216, 24, "shown", 2, "Wall", false, false, "defense", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.phase_wall, new("phase-wall", 217, 25, "shown", 1, "Wall", false, false, "defense", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.phase_wall_large, new("phase-wall-large", 218, 26, "shown", 2, "Wall", false, false, "defense", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.surge_wall, new("surge-wall", 219, 27, "shown", 1, "Wall", false, false, "defense", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.surge_wall_large, new("surge-wall-large", 220, 28, "shown", 2, "Wall", false, false, "defense", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.door, new("door", 221, 29, "shown", 1, "Door", false, false, "defense", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.door_large, new("door-large", 222, 30, "shown", 2, "Door", false, false, "defense", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.scrap_wall, new("scrap-wall", 223, 31, "shown", 1, "Wall", false, false, "defense", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.scrap_wall_large, new("scrap-wall-large", 224, 32, "shown", 2, "Wall", false, false, "defense", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.scrap_wall_huge, new("scrap-wall-huge", 225, 33, "shown", 3, "Wall", false, false, "defense", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.scrap_wall_gigantic, new("scrap-wall-gigantic", 226, 34, "shown", 4, "Wall", false, false, "defense", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.thruster, new("thruster", 227, 149, "sandboxonly", 4, "Thruster", false, false, "defense", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.beryllium_wall, new("beryllium-wall", 228, 206, "shown", 1, "Wall", false, false, "defense", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.beryllium_wall_large, new("beryllium-wall-large", 229, 207, "shown", 2, "Wall", false, false, "defense", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.tungsten_wall, new("tungsten-wall", 230, 203, "shown", 1, "Wall", false, false, "defense", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.tungsten_wall_large, new("tungsten-wall-large", 231, 204, "shown", 2, "Wall", false, false, "defense", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.blast_door, new("blast-door", 232, 227, "shown", 2, "AutoDoor", false, false, "defense", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.reinforced_surge_wall, new("reinforced-surge-wall", 233, 225, "shown", 1, "Wall", false, false, "defense", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.reinforced_surge_wall_large, new("reinforced-surge-wall-large", 234, 234, "shown", 2, "Wall", false, false, "defense", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.carbide_wall, new("carbide-wall", 235, 220, "shown", 1, "Wall", false, false, "defense", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.carbide_wall_large, new("carbide-wall-large", 236, 221, "shown", 2, "Wall", false, false, "defense", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.shielded_wall, new("shielded-wall", 237, 240, "shown", 2, "ShieldWall", false, false, "defense", 0, false, false, false, 10, false, true, false, false, 10, true, true, false, true, true, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.mender, new("mender", 238, 35, "shown", 1, "MendProjector", false, false, "effect", 0, true, true, false, 10, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.mend_projector, new("mend-projector", 239, 36, "shown", 2, "MendProjector", false, false, "effect", 0, true, true, false, 10, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.overdrive_projector, new("overdrive-projector", 240, 37, "shown", 2, "OverdriveProjector", false, false, "effect", 0, true, true, false, 10, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.overdrive_dome, new("overdrive-dome", 241, 38, "shown", 3, "OverdriveProjector", false, false, "effect", 0, true, true, false, 10, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.force_projector, new("force-projector", 242, 39, "shown", 3, "ForceProjector", false, false, "effect", 0, true, true, false, 10, false, true, true, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.shock_mine, new("shock-mine", 243, 40, "shown", 1, "ShockMine", false, false, "effect", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.radar, new("radar", 244, 226, "fogonly", 1, "Radar", false, false, "effect", 0, false, false, false, 10, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.build_tower, new("build-tower", 245, 162, "shown", 3, "BuildTurret", false, false, "effect", 0, false, false, false, 10, false, true, true, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.regen_projector, new("regen-projector", 246, 197, "shown", 3, "RegenProjector", false, false, "effect", 0, true, true, false, 10, false, true, true, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.shockwave_tower, new("shockwave-tower", 247, 246, "shown", 3, "ShockwaveTower", false, false, "effect", 0, false, false, false, 10, false, true, true, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.shield_projector, new("shield-projector", 248, 211, "editoronly", 3, "BaseShield", false, false, "effect", 0, false, false, false, 10, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.large_shield_projector, new("large-shield-projector", 249, 217, "editoronly", 4, "BaseShield", false, false, "effect", 0, false, false, false, 10, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.conveyor, new("conveyor", 250, 41, "shown", 1, "Conveyor", false, false, "distribution", 0, true, true, false, 3, false, false, false, false, 10, false, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.titanium_conveyor, new("titanium-conveyor", 251, 42, "shown", 1, "Conveyor", false, false, "distribution", 0, true, true, false, 3, false, false, false, false, 10, false, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.plastanium_conveyor, new("plastanium-conveyor", 252, 43, "shown", 1, "StackConveyor", false, false, "distribution", 0, true, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.armored_conveyor, new("armored-conveyor", 253, 44, "shown", 1, "ArmoredConveyor", false, false, "distribution", 0, true, true, false, 3, true, false, false, false, 10, false, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.junction, new("junction", 254, 45, "shown", 1, "Junction", false, false, "distribution", 0, false, true, false, 10, false, false, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.bridge_conveyor, new("bridge-conveyor", 255, 46, "shown", 1, "BufferedItemBridge", false, true, "distribution", 4, true, true, false, 10, false, false, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.phase_conveyor, new("phase-conveyor", 256, 47, "shown", 1, "ItemBridge", false, true, "distribution", 12, true, true, false, 10, false, false, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.sorter, new("sorter", 257, 48, "shown", 1, "Sorter", false, true, "distribution", 0, false, true, false, 10, false, false, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.inverted_sorter, new("inverted-sorter", 258, 49, "shown", 1, "Sorter", false, true, "distribution", 0, false, true, false, 10, false, false, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.router, new("router", 259, 50, "shown", 1, "Router", false, false, "distribution", 0, true, true, false, 1, false, false, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.distributor, new("distributor", 260, 51, "shown", 2, "Router", false, false, "distribution", 0, true, true, false, 1, false, false, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.overflow_gate, new("overflow-gate", 261, 52, "shown", 1, "OverflowGate", false, false, "distribution", 0, true, true, false, 0, false, false, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.underflow_gate, new("underflow-gate", 262, 53, "shown", 1, "OverflowGate", false, false, "distribution", 0, true, true, false, 0, false, false, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.mass_driver, new("mass-driver", 263, 54, "shown", 3, "MassDriver", false, true, "distribution", 55, true, true, false, 120, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.duct, new("duct", 264, 55, "shown", 1, "Duct", false, false, "distribution", 0, true, true, false, 1, true, false, false, false, 10, false, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.armored_duct, new("armored-duct", 265, 229, "shown", 1, "Duct", false, false, "distribution", 0, true, true, false, 1, true, false, false, false, 10, false, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.duct_router, new("duct-router", 266, 56, "shown", 1, "DuctRouter", false, true, "distribution", 0, true, true, false, 1, false, false, false, false, 10, false, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.overflow_duct, new("overflow-duct", 267, 182, "shown", 1, "OverflowDuct", false, false, "distribution", 0, true, true, false, 1, false, false, false, false, 10, false, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.underflow_duct, new("underflow-duct", 268, 244, "shown", 1, "OverflowDuct", false, false, "distribution", 0, true, true, false, 1, false, false, false, false, 10, false, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.duct_bridge, new("duct-bridge", 269, 57, "shown", 1, "DuctBridge", false, false, "distribution", 0, true, true, false, 4, false, true, false, false, 10, false, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.duct_unloader, new("duct-unloader", 270, 166, "shown", 1, "DirectionalUnloader", false, true, "distribution", 0, true, true, false, 0, false, false, false, false, 10, false, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.surge_conveyor, new("surge-conveyor", 271, 165, "shown", 1, "StackConveyor", false, false, "distribution", 0, true, true, false, 10, false, true, false, false, 10, true, true, false, true, true, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.surge_router, new("surge-router", 272, 167, "shown", 1, "StackRouter", false, true, "distribution", 0, true, true, false, 10, false, false, false, false, 10, true, true, false, true, true, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.unit_cargo_loader, new("unit-cargo-loader", 273, 193, "shown", 3, "UnitCargoLoader", false, false, "distribution", 0, true, true, false, 200, false, true, true, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.unit_cargo_unload_point, new("unit-cargo-unload-point", 274, 194, "shown", 2, "UnitCargoUnloadPoint", false, true, "distribution", 0, true, true, false, 100, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.mechanical_pump, new("mechanical-pump", 275, 58, "shown", 1, "Pump", false, false, "liquid", 0, false, false, false, 10, false, true, true, true, 20, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.rotary_pump, new("rotary-pump", 276, 59, "shown", 2, "Pump", false, false, "liquid", 0, false, false, false, 10, false, true, true, true, 80, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.impulse_pump, new("impulse-pump", 277, 176, "shown", 3, "Pump", false, false, "liquid", 0, false, false, false, 10, false, true, true, true, 200, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.conduit, new("conduit", 278, 60, "shown", 1, "Conduit", false, false, "liquid", 0, false, false, false, 10, false, true, true, true, 20, false, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.pulse_conduit, new("pulse-conduit", 279, 61, "shown", 1, "Conduit", false, false, "liquid", 0, false, false, false, 10, false, true, true, true, 40, false, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.plated_conduit, new("plated-conduit", 280, 62, "shown", 1, "ArmoredConduit", false, false, "liquid", 0, false, false, false, 10, false, true, true, true, 50, false, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.liquid_router, new("liquid-router", 281, 63, "shown", 1, "LiquidRouter", false, false, "liquid", 0, false, false, false, 10, false, true, true, true, 120, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.liquid_container, new("liquid-container", 282, 146, "shown", 2, "LiquidRouter", false, false, "liquid", 0, false, false, false, 10, false, true, true, true, 700, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.liquid_tank, new("liquid-tank", 283, 64, "shown", 3, "LiquidRouter", false, false, "liquid", 0, false, false, false, 10, false, true, true, true, 1800, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.liquid_junction, new("liquid-junction", 284, 65, "shown", 1, "LiquidJunction", false, false, "liquid", 0, false, false, false, 10, false, true, true, true, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.bridge_conduit, new("bridge-conduit", 285, 66, "shown", 1, "LiquidBridge", false, true, "liquid", 4, false, false, false, 10, false, false, true, true, 100, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.phase_conduit, new("phase-conduit", 286, 67, "shown", 1, "LiquidBridge", false, true, "liquid", 12, false, false, false, 10, false, false, true, true, 100, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.reinforced_pump, new("reinforced-pump", 287, 177, "shown", 2, "Pump", false, false, "liquid", 0, false, false, false, 10, false, true, true, true, 160, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.reinforced_conduit, new("reinforced-conduit", 288, 168, "shown", 1, "ArmoredConduit", false, false, "liquid", 0, false, false, false, 10, false, true, true, true, 50, false, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.reinforced_liquid_junction, new("reinforced-liquid-junction", 289, 156, "shown", 1, "LiquidJunction", false, false, "liquid", 0, false, false, false, 10, false, true, true, true, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.reinforced_bridge_conduit, new("reinforced-bridge-conduit", 290, 172, "shown", 1, "DirectionLiquidBridge", false, false, "liquid", 0, false, false, false, 10, false, true, true, true, 120, false, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.reinforced_liquid_router, new("reinforced-liquid-router", 291, 169, "shown", 1, "LiquidRouter", false, false, "liquid", 0, false, false, false, 10, false, true, true, true, 150, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.reinforced_liquid_container, new("reinforced-liquid-container", 292, 170, "shown", 2, "LiquidRouter", false, false, "liquid", 0, false, false, false, 10, false, true, true, true, 1000, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.reinforced_liquid_tank, new("reinforced-liquid-tank", 293, 171, "shown", 3, "LiquidRouter", false, false, "liquid", 0, false, false, false, 10, false, true, true, true, 2700, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.power_node, new("power-node", 294, 68, "shown", 1, "PowerNode", false, true, "power", 6, false, false, false, 10, false, true, false, false, 10, true, false, false, true, false, 10, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.power_node_large, new("power-node-large", 295, 69, "shown", 2, "PowerNode", false, true, "power", 15, false, false, false, 10, false, true, false, false, 10, true, false, false, true, false, 15, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.surge_tower, new("surge-tower", 296, 70, "shown", 2, "PowerNode", false, true, "power", 40, false, false, false, 10, false, true, false, false, 10, true, false, false, true, false, 2, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.diode, new("diode", 297, 71, "shown", 1, "PowerDiode", false, false, "power", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.battery, new("battery", 298, 72, "shown", 1, "Battery", false, false, "power", 0, false, false, false, 10, false, true, false, false, 10, true, true, true, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.battery_large, new("battery-large", 299, 73, "shown", 3, "Battery", false, false, "power", 0, false, false, false, 10, false, true, false, false, 10, true, true, true, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.combustion_generator, new("combustion-generator", 300, 74, "shown", 1, "ConsumeGenerator", false, false, "power", 0, true, true, false, 10, false, true, false, false, 10, true, false, true, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.thermal_generator, new("thermal-generator", 301, 75, "shown", 2, "ThermalGenerator", false, false, "power", 0, false, false, false, 10, false, true, false, false, 10, true, false, true, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.steam_generator, new("steam-generator", 302, 76, "shown", 2, "ConsumeGenerator", false, false, "power", 0, true, true, false, 10, false, true, true, false, 10, true, false, true, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.differential_generator, new("differential-generator", 303, 77, "shown", 3, "ConsumeGenerator", false, false, "power", 0, true, true, false, 10, false, true, true, false, 10, true, false, true, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.rtg_generator, new("rtg-generator", 304, 78, "shown", 2, "ConsumeGenerator", false, false, "power", 0, true, true, false, 10, false, true, false, false, 10, true, false, true, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.solar_panel, new("solar-panel", 305, 79, "shown", 1, "SolarGenerator", false, false, "power", 0, false, false, false, 10, false, true, false, false, 10, true, false, true, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.solar_panel_large, new("solar-panel-large", 306, 80, "shown", 3, "SolarGenerator", false, false, "power", 0, false, false, false, 10, false, true, false, false, 10, true, false, true, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.thorium_reactor, new("thorium-reactor", 307, 81, "shown", 3, "NuclearReactor", false, false, "power", 0, true, true, false, 30, false, true, true, false, 30, true, false, true, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.impact_reactor, new("impact-reactor", 308, 82, "shown", 4, "ImpactReactor", false, false, "power", 0, true, true, false, 10, false, true, true, false, 80, true, true, true, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.beam_node, new("beam-node", 309, 160, "shown", 1, "BeamNode", false, false, "power", 0, false, false, false, 10, false, true, false, false, 10, true, true, true, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.beam_tower, new("beam-tower", 310, 161, "shown", 3, "BeamNode", false, false, "power", 0, false, false, false, 10, false, true, false, false, 10, true, true, true, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.beam_link, new("beam-link", 311, 212, "shown", 3, "LongPowerNode", false, true, "power", 500, false, false, false, 10, false, true, false, false, 10, true, false, false, true, false, 1, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.turbine_condenser, new("turbine-condenser", 312, 159, "shown", 3, "ThermalGenerator", false, false, "power", 0, false, false, false, 10, false, true, true, true, 20, true, false, true, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.chemical_combustion_chamber, new("chemical-combustion-chamber", 313, 195, "shown", 3, "ConsumeGenerator", false, false, "power", 0, false, false, false, 10, false, true, true, false, 100, true, false, true, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.pyrolysis_generator, new("pyrolysis-generator", 314, 196, "shown", 3, "ConsumeGenerator", false, false, "power", 0, false, false, false, 10, false, true, true, true, 150, true, false, true, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.flux_reactor, new("flux-reactor", 315, 248, "shown", 5, "VariableReactor", false, false, "power", 0, false, false, false, 10, false, true, true, false, 30, true, false, true, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.neoplasia_reactor, new("neoplasia-reactor", 316, 249, "shown", 5, "HeaterGenerator", false, false, "power", 0, true, true, false, 10, false, true, true, true, 80, true, false, true, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.mechanical_drill, new("mechanical-drill", 317, 83, "shown", 2, "Drill", false, false, "production", 0, true, false, false, 10, false, true, true, false, 5, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.pneumatic_drill, new("pneumatic-drill", 318, 84, "shown", 2, "Drill", false, false, "production", 0, true, false, false, 10, false, true, true, false, 5, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.laser_drill, new("laser-drill", 319, 85, "shown", 3, "Drill", false, false, "production", 0, true, false, false, 10, false, true, true, false, 5, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.blast_drill, new("blast-drill", 320, 86, "shown", 4, "Drill", false, false, "production", 0, true, false, false, 20, false, true, true, false, 5, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.water_extractor, new("water-extractor", 321, 87, "shown", 2, "SolidPump", false, false, "production", 0, false, false, false, 10, false, true, true, true, 40, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.cultivator, new("cultivator", 322, 88, "shown", 2, "AttributeCrafter", false, false, "production", 0, true, false, false, 10, false, true, true, false, 80, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.oil_extractor, new("oil-extractor", 323, 89, "shown", 3, "Fracker", false, false, "production", 0, true, true, false, 10, false, true, true, true, 40, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.vent_condenser, new("vent-condenser", 324, 200, "shown", 3, "AttributeCrafter", false, false, "production", 0, true, false, false, 0, false, true, true, true, 60, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.cliff_crusher, new("cliff-crusher", 325, 154, "shown", 2, "WallCrafter", false, false, "production", 0, true, false, false, 10, false, true, false, false, 10, true, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.large_cliff_crusher, new("large-cliff-crusher", 326, 256, "shown", 3, "WallCrafter", false, false, "production", 0, true, true, false, 20, false, true, true, false, 10, true, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.plasma_bore, new("plasma-bore", 327, 155, "shown", 2, "BeamDrill", false, false, "production", 0, true, false, false, 10, false, true, true, false, 10, true, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.large_plasma_bore, new("large-plasma-bore", 328, 183, "shown", 3, "BeamDrill", false, false, "production", 0, true, false, false, 20, false, true, true, false, 10, true, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.impact_drill, new("impact-drill", 329, 163, "shown", 4, "BurstDrill", false, false, "production", 0, true, false, false, 40, false, true, true, false, 5, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.eruption_drill, new("eruption-drill", 330, 208, "shown", 5, "BurstDrill", false, false, "production", 0, true, false, false, 60, false, true, true, false, 5, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.core_shard, new("core-shard", 331, 90, "corezoneonly", 3, "CoreBlock", false, false, "effect", 0, true, true, true, 4000, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.core_foundation, new("core-foundation", 332, 91, "shown", 4, "CoreBlock", false, false, "effect", 0, true, true, true, 9000, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.core_nucleus, new("core-nucleus", 333, 92, "shown", 5, "CoreBlock", false, false, "effect", 0, true, true, true, 13000, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.core_bastion, new("core-bastion", 334, 158, "shown", 4, "CoreBlock", false, false, "effect", 0, true, true, true, 2000, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.core_citadel, new("core-citadel", 335, 173, "shown", 5, "CoreBlock", false, false, "effect", 0, true, true, true, 3000, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.core_acropolis, new("core-acropolis", 336, 174, "shown", 6, "CoreBlock", false, false, "effect", 0, true, true, true, 4000, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.container, new("container", 337, 94, "shown", 2, "StorageBlock", false, false, "effect", 0, true, true, true, 300, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.vault, new("vault", 338, 93, "shown", 3, "StorageBlock", false, false, "effect", 0, true, true, true, 1000, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.unloader, new("unloader", 339, 95, "shown", 1, "Unloader", false, true, "effect", 0, true, true, false, 0, false, false, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.reinforced_container, new("reinforced-container", 340, 190, "shown", 2, "StorageBlock", false, false, "effect", 0, true, true, true, 160, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.reinforced_vault, new("reinforced-vault", 341, 191, "shown", 3, "StorageBlock", false, false, "effect", 0, true, true, true, 900, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.duo, new("duo", 342, 96, "shown", 1, "ItemTurret", false, false, "turret", 0, true, true, false, 10, false, true, true, false, 20, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.scatter, new("scatter", 343, 97, "shown", 2, "ItemTurret", false, false, "turret", 0, true, true, false, 10, false, true, true, false, 20, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.scorch, new("scorch", 344, 98, "shown", 1, "ItemTurret", false, false, "turret", 0, true, true, false, 10, false, true, true, false, 20, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.hail, new("hail", 345, 99, "shown", 1, "ItemTurret", false, false, "turret", 0, true, true, false, 10, false, true, true, false, 20, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.wave, new("wave", 346, 100, "shown", 2, "LiquidTurret", false, false, "turret", 0, false, false, false, 10, false, true, true, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.lancer, new("lancer", 347, 101, "shown", 2, "PowerTurret", false, false, "turret", 0, false, false, false, 10, false, true, true, false, 20, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.arc, new("arc", 348, 102, "shown", 1, "PowerTurret", false, false, "turret", 0, false, false, false, 10, false, true, true, false, 20, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.parallax, new("parallax", 349, 103, "shown", 2, "TractorBeamTurret", false, false, "turret", 0, false, false, false, 10, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.swarmer, new("swarmer", 350, 104, "shown", 2, "ItemTurret", false, false, "turret", 0, true, true, false, 10, false, true, true, false, 20, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.salvo, new("salvo", 351, 105, "shown", 2, "ItemTurret", false, false, "turret", 0, true, true, false, 10, false, true, true, false, 20, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.segment, new("segment", 352, 106, "shown", 2, "PointDefenseTurret", false, false, "turret", 0, false, false, false, 10, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.tsunami, new("tsunami", 353, 107, "shown", 3, "LiquidTurret", false, false, "turret", 0, false, false, false, 10, false, true, true, false, 40, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.fuse, new("fuse", 354, 108, "shown", 3, "ItemTurret", false, false, "turret", 0, true, true, false, 10, false, true, true, false, 20, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.ripple, new("ripple", 355, 109, "shown", 3, "ItemTurret", false, false, "turret", 0, true, true, false, 10, false, true, true, false, 20, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.cyclone, new("cyclone", 356, 110, "shown", 3, "ItemTurret", false, false, "turret", 0, true, true, false, 10, false, true, true, false, 20, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.foreshadow, new("foreshadow", 357, 111, "shown", 4, "ItemTurret", false, false, "turret", 0, true, true, false, 10, false, true, true, false, 20, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.spectre, new("spectre", 358, 112, "shown", 4, "ItemTurret", false, false, "turret", 0, true, true, false, 10, false, true, true, false, 20, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.meltdown, new("meltdown", 359, 113, "shown", 4, "LaserTurret", false, false, "turret", 0, false, false, false, 10, false, true, true, false, 20, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.breach, new("breach", 360, 157, "shown", 3, "ItemTurret", false, false, "turret", 0, true, true, false, 10, false, true, true, false, 20, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.diffuse, new("diffuse", 361, 231, "shown", 3, "ItemTurret", false, false, "turret", 0, true, true, false, 10, false, true, true, false, 20, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.sublimate, new("sublimate", 362, 189, "shown", 3, "ContinuousLiquidTurret", false, false, "turret", 0, false, false, false, 10, false, true, true, false, 50, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.titan, new("titan", 363, 198, "shown", 4, "ItemTurret", false, false, "turret", 0, true, true, false, 10, false, true, true, false, 20, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.disperse, new("disperse", 364, 216, "shown", 4, "ItemTurret", false, false, "turret", 0, true, true, false, 10, false, true, true, false, 20, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.afflict, new("afflict", 365, 239, "shown", 4, "PowerTurret", false, false, "turret", 0, false, false, false, 10, false, true, false, false, 20, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.lustre, new("lustre", 366, 241, "shown", 4, "ContinuousTurret", false, false, "turret", 0, false, false, false, 10, false, true, true, false, 20, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.scathe, new("scathe", 367, 242, "shown", 4, "ItemTurret", false, false, "turret", 0, true, true, false, 10, false, true, true, false, 20, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.smite, new("smite", 368, 243, "shown", 5, "ItemTurret", false, false, "turret", 0, true, true, false, 10, false, true, true, false, 20, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.malign, new("malign", 369, 245, "shown", 5, "PowerTurret", false, false, "turret", 0, false, false, false, 10, false, true, false, false, 20, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.ground_factory, new("ground-factory", 370, 115, "shown", 3, "UnitFactory", false, true, "units", 0, true, true, false, 60, false, true, false, false, 10, true, true, false, true, false, 0, true, true, "dagger|crawler|nova"));
            Blocks.Add(MindustryChematicCreator.BlockType.air_factory, new("air-factory", 371, 116, "shown", 3, "UnitFactory", false, true, "units", 0, true, true, false, 60, false, true, false, false, 10, true, true, false, true, false, 0, true, true, "flare|mono"));
            Blocks.Add(MindustryChematicCreator.BlockType.naval_factory, new("naval-factory", 372, 117, "shown", 3, "UnitFactory", false, true, "units", 0, true, true, false, 70, false, true, false, false, 10, true, true, false, true, false, 0, true, true, "risso|retusa"));
            Blocks.Add(MindustryChematicCreator.BlockType.additive_reconstructor, new("additive-reconstructor", 373, 118, "shown", 3, "Reconstructor", false, true, "units", 0, true, true, false, 80, false, true, false, false, 10, true, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.multiplicative_reconstructor, new("multiplicative-reconstructor", 374, 119, "shown", 5, "Reconstructor", false, true, "units", 0, true, true, false, 260, false, true, false, false, 10, true, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.exponential_reconstructor, new("exponential-reconstructor", 375, 120, "shown", 7, "Reconstructor", false, true, "units", 0, true, true, false, 1700, false, true, true, false, 60, true, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.tetrative_reconstructor, new("tetrative-reconstructor", 376, 121, "shown", 9, "Reconstructor", false, true, "units", 0, true, true, false, 2000, false, true, true, false, 180, true, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.repair_point, new("repair-point", 377, 122, "shown", 1, "RepairTurret", false, false, "units", 0, false, false, false, 10, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.repair_turret, new("repair-turret", 378, 123, "shown", 2, "RepairTurret", false, false, "units", 0, false, false, false, 10, false, true, true, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.tank_fabricator, new("tank-fabricator", 379, 222, "shown", 3, "UnitFactory", false, false, "units", 0, true, true, false, 100, false, true, false, false, 10, true, true, false, true, false, 0, true, true, "stell"));
            Blocks.Add(MindustryChematicCreator.BlockType.ship_fabricator, new("ship-fabricator", 380, 224, "shown", 3, "UnitFactory", false, false, "units", 0, true, true, false, 140, false, true, false, false, 10, true, true, false, true, false, 0, true, true, "elude"));
            Blocks.Add(MindustryChematicCreator.BlockType.mech_fabricator, new("mech-fabricator", 381, 223, "shown", 3, "UnitFactory", false, false, "units", 0, true, true, false, 140, false, true, false, false, 10, true, true, false, true, false, 0, true, true, "merui"));
            Blocks.Add(MindustryChematicCreator.BlockType.tank_refabricator, new("tank-refabricator", 382, 235, "shown", 3, "Reconstructor", false, true, "units", 0, true, true, false, 80, false, true, true, false, 10, true, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.ship_refabricator, new("ship-refabricator", 383, 237, "shown", 3, "Reconstructor", false, true, "units", 0, true, true, false, 120, false, true, true, false, 10, true, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.mech_refabricator, new("mech-refabricator", 384, 236, "shown", 3, "Reconstructor", false, true, "units", 0, true, true, false, 100, false, true, true, false, 10, true, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.prime_refabricator, new("prime-refabricator", 385, 232, "shown", 5, "Reconstructor", false, true, "units", 0, true, true, false, 200, false, true, true, false, 10, true, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.tank_assembler, new("tank-assembler", 386, 205, "shown", 5, "UnitAssembler", false, false, "units", 0, true, true, false, 10, false, true, true, false, 10, true, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.ship_assembler, new("ship-assembler", 387, 209, "shown", 5, "UnitAssembler", false, false, "units", 0, true, true, false, 10, false, true, true, false, 10, true, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.mech_assembler, new("mech-assembler", 388, 210, "shown", 5, "UnitAssembler", false, false, "units", 0, true, true, false, 10, false, true, true, false, 10, true, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.basic_assembler_module, new("basic-assembler-module", 389, 233, "shown", 5, "UnitAssemblerModule", false, false, "units", 0, false, false, false, 10, false, true, false, false, 10, true, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.unit_repair_tower, new("unit-repair-tower", 390, 230, "shown", 2, "RepairTower", false, false, "units", 0, false, false, false, 10, false, true, true, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.payload_conveyor, new("payload-conveyor", 391, 124, "shown", 3, "PayloadConveyor", false, false, "units", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.payload_router, new("payload-router", 392, 125, "shown", 3, "PayloadRouter", false, true, "units", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, false, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.reinforced_payload_conveyor, new("reinforced-payload-conveyor", 393, 214, "shown", 3, "PayloadConveyor", false, false, "units", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.reinforced_payload_router, new("reinforced-payload-router", 394, 215, "shown", 3, "PayloadRouter", false, true, "units", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, false, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.payload_mass_driver, new("payload-mass-driver", 395, 218, "shown", 3, "PayloadMassDriver", false, true, "units", 87.5f, false, false, false, 10, false, true, false, false, 10, true, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.large_payload_mass_driver, new("large-payload-mass-driver", 396, 251, "shown", 5, "PayloadMassDriver", false, true, "units", 262.5f, false, false, false, 10, false, true, false, false, 10, true, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.small_deconstructor, new("small-deconstructor", 397, 199, "shown", 3, "PayloadDeconstructor", false, false, "units", 0, true, false, false, 100, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.deconstructor, new("deconstructor", 398, 147, "shown", 5, "PayloadDeconstructor", false, false, "units", 0, true, false, false, 250, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.constructor, new("constructor", 399, 148, "shown", 3, "Constructor", false, true, "units", 0, true, true, false, 10, false, true, false, false, 10, true, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.large_constructor, new("large-constructor", 400, 150, "shown", 5, "Constructor", false, true, "units", 0, true, true, false, 10, false, true, false, false, 10, true, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.payload_loader, new("payload-loader", 401, 151, "shown", 3, "PayloadLoader", false, false, "units", 0, true, false, false, 100, false, true, true, false, 100, true, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.payload_unloader, new("payload-unloader", 402, 152, "shown", 3, "PayloadUnloader", false, false, "units", 0, true, false, false, 100, false, true, true, true, 100, true, true, true, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.power_source, new("power-source", 403, 126, "sandboxonly", 1, "PowerSource", false, true, "power", 6, false, false, false, 10, false, true, false, false, 10, true, false, true, true, false, 100, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.power_void, new("power-void", 404, 127, "sandboxonly", 1, "PowerVoid", false, false, "power", 0, false, false, false, 10, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.item_source, new("item-source", 405, 128, "sandboxonly", 1, "ItemSource", false, true, "distribution", 0, true, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.item_void, new("item-void", 406, 129, "sandboxonly", 1, "ItemVoid", false, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.liquid_source, new("liquid-source", 407, 130, "sandboxonly", 1, "LiquidSource", false, true, "liquid", 0, false, false, false, 10, false, true, true, true, 10000, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.liquid_void, new("liquid-void", 408, 131, "sandboxonly", 1, "LiquidVoid", false, false, "liquid", 0, false, false, false, 10, false, true, true, false, 10000, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.payload_source, new("payload-source", 409, 133, "sandboxonly", 5, "PayloadSource", false, true, "units", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.payload_void, new("payload-void", 410, 132, "sandboxonly", 5, "PayloadVoid", false, false, "units", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.heat_source, new("heat-source", 411, 247, "sandboxonly", 1, "HeatProducer", false, false, "crafting", 0, true, false, false, 0, false, true, false, false, 10, false, true, false, true, false, 0, true, true, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.illuminator, new("illuminator", 412, 134, "lightingonly", 1, "LightBlock", false, true, "effect", 0, false, false, false, 10, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.legacy_mech_pad, new("legacy-mech-pad", 413, -1, "hidden", 1, "LegacyMechPad", true, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.legacy_unit_factory, new("legacy-unit-factory", 414, -1, "hidden", 1, "LegacyUnitFactory", true, false, "distribution", 0, true, true, false, 10, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.legacy_unit_factory_air, new("legacy-unit-factory-air", 415, -1, "hidden", 1, "LegacyUnitFactory", true, false, "distribution", 0, true, true, false, 10, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.legacy_unit_factory_ground, new("legacy-unit-factory-ground", 416, -1, "hidden", 1, "LegacyUnitFactory", true, false, "distribution", 0, true, true, false, 10, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.command_center, new("command-center", 417, 114, "hidden", 2, "LegacyCommandCenter", true, false, "distribution", 0, false, true, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.launch_pad, new("launch-pad", 418, 135, "legacylaunchpadonly", 3, "LaunchPad", false, true, "effect", 0, true, false, false, 100, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.advanced_launch_pad, new("advanced-launch-pad", 419, 257, "notlegacylaunchpadonly", 4, "LaunchPad", false, true, "effect", 0, true, false, false, 100, false, true, true, false, 40, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.landing_pad, new("landing-pad", 420, 258, "notlegacylaunchpadonly", 4, "LandingPad", false, true, "effect", 0, true, false, false, 100, false, true, true, false, 3000, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.interplanetary_accelerator, new("interplanetary-accelerator", 421, 136, "campaignonly", 7, "Accelerator", false, true, "effect", 0, true, true, false, 25000, false, true, false, false, 10, true, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.message, new("message", 422, 137, "shown", 1, "MessageBlock", false, true, "logic", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.switch_block, new("switch", 423, 138, "shown", 1, "SwitchBlock", false, true, "logic", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.micro_processor, new("micro-processor", 424, 139, "shown", 1, "LogicBlock", false, true, "logic", 10, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.logic_processor, new("logic-processor", 425, 140, "shown", 2, "LogicBlock", false, true, "logic", 22, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.hyper_processor, new("hyper-processor", 426, 141, "shown", 3, "LogicBlock", false, true, "logic", 42, false, false, false, 10, false, true, true, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.memory_cell, new("memory-cell", 427, 142, "shown", 1, "MemoryBlock", false, false, "logic", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.memory_bank, new("memory-bank", 428, 143, "shown", 2, "MemoryBlock", false, false, "logic", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.logic_display, new("logic-display", 429, 144, "shown", 3, "LogicDisplay", false, false, "logic", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.large_logic_display, new("large-logic-display", 430, 145, "shown", 6, "LogicDisplay", false, false, "logic", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.tile_logic_display, new("tile-logic-display", 431, 259, "shown", 1, "TileableLogicDisplay", false, false, "logic", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.canvas, new("canvas", 432, 228, "shown", 2, "CanvasBlock", false, true, "logic", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.reinforced_message, new("reinforced-message", 433, 252, "shown", 1, "MessageBlock", false, true, "logic", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.world_processor, new("world-processor", 434, 213, "worldprocessoronly", 1, "LogicBlock", false, true, "logic", 4.25352933298161E+37f, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.world_cell, new("world-cell", 435, 219, "worldprocessoronly", 1, "MemoryBlock", false, false, "logic", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.world_message, new("world-message", 436, 253, "worldprocessoronly", 1, "MessageBlock", false, true, "logic", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));
            Blocks.Add(MindustryChematicCreator.BlockType.world_switch, new("world-switch", 437, 254, "worldprocessoronly", 1, "SwitchBlock", false, true, "logic", 0, false, false, false, 10, false, true, false, false, 10, false, true, false, true, false, 0, true, false, ""));


        }
    }

    public enum BlockType
    {
        air,
        spawn,
        remove_wall,
        remove_ore,
        cliff,
        build1,
        build2,
        build3,
        build4,
        build5,
        build6,
        build7,
        build8,
        build9,
        build10,
        build11,
        build12,
        build13,
        build14,
        build15,
        build16,
        deep_water,
        shallow_water,
        tainted_water,
        deep_tainted_water,
        darksand_tainted_water,
        sand_water,
        darksand_water,
        tar,
        pooled_cryofluid,
        molten_slag,
        space,
        empty,
        stone,
        crater_stone,
        char_block,
        basalt,
        hotrock,
        magmarock,
        sand_floor,
        darksand,
        dirt,
        mud,
        dacite,
        rhyolite,
        rhyolite_crater,
        rough_rhyolite,
        regolith,
        yellow_stone,
        carbon_stone,
        ferric_stone,
        ferric_craters,
        beryllic_stone,
        crystalline_stone,
        crystal_floor,
        yellow_stone_plates,
        red_stone,
        dense_red_stone,
        red_ice,
        arkycite_floor,
        arkyic_stone,
        rhyolite_vent,
        carbon_vent,
        arkyic_vent,
        yellow_stone_vent,
        red_stone_vent,
        crystalline_vent,
        stone_vent,
        basalt_vent,
        redmat,
        bluemat,
        grass,
        salt,
        snow,
        ice,
        ice_snow,
        shale,
        moss,
        core_zone,
        spore_moss,
        stone_wall,
        spore_wall,
        dirt_wall,
        dacite_wall,
        ice_wall,
        snow_wall,
        dune_wall,
        regolith_wall,
        yellow_stone_wall,
        rhyolite_wall,
        carbon_wall,
        ferric_stone_wall,
        beryllic_stone_wall,
        arkyic_wall,
        crystalline_stone_wall,
        red_ice_wall,
        red_stone_wall,
        red_diamond_wall,
        sand_wall,
        salt_wall,
        shrubs,
        shale_wall,
        spore_pine,
        snow_pine,
        pine,
        white_tree_dead,
        white_tree,
        spore_cluster,
        redweed,
        pur_bush,
        yellowcoral,
        boulder,
        snow_boulder,
        shale_boulder,
        sand_boulder,
        dacite_boulder,
        basalt_boulder,
        carbon_boulder,
        ferric_boulder,
        beryllic_boulder,
        yellow_stone_boulder,
        arkyic_boulder,
        crystal_cluster,
        vibrant_crystal_cluster,
        crystal_blocks,
        crystal_orbs,
        crystalline_boulder,
        red_ice_boulder,
        rhyolite_boulder,
        red_stone_boulder,
        metal_floor,
        metal_floor_damaged,
        metal_floor_2,
        metal_floor_3,
        metal_floor_4,
        metal_floor_5,
        dark_panel_1,
        dark_panel_2,
        dark_panel_3,
        dark_panel_4,
        dark_panel_5,
        dark_panel_6,
        dark_metal,
        metal_tiles_1,
        metal_tiles_2,
        metal_tiles_3,
        metal_tiles_4,
        metal_tiles_5,
        metal_tiles_6,
        metal_tiles_7,
        metal_tiles_8,
        metal_tiles_9,
        metal_tiles_10,
        metal_tiles_11,
        metal_tiles_12,
        colored_floor,
        colored_wall,
        character_overlay,
        character_overlay_white,
        pebbles,
        tendrils,
        ore_copper,
        ore_lead,
        ore_scrap,
        ore_coal,
        ore_titanium,
        ore_thorium,
        ore_beryllium,
        ore_tungsten,
        ore_crystal_thorium,
        ore_wall_thorium,
        ore_wall_beryllium,
        graphitic_wall,
        ore_wall_tungsten,
        graphite_press,
        multi_press,
        silicon_smelter,
        silicon_crucible,
        kiln,
        plastanium_compressor,
        phase_weaver,
        surge_smelter,
        cryofluid_mixer,
        pyratite_mixer,
        blast_mixer,
        melter,
        separator,
        disassembler,
        spore_press,
        pulverizer,
        coal_centrifuge,
        incinerator,
        silicon_arc_furnace,
        electrolyzer,
        atmospheric_concentrator,
        oxidation_chamber,
        electric_heater,
        slag_heater,
        phase_heater,
        heat_redirector,
        small_heat_redirector,
        heat_router,
        slag_incinerator,
        carbide_crucible,
        slag_centrifuge,
        surge_crucible,
        cyanogen_synthesizer,
        phase_synthesizer,
        heat_reactor,
        copper_wall,
        copper_wall_large,
        titanium_wall,
        titanium_wall_large,
        plastanium_wall,
        plastanium_wall_large,
        thorium_wall,
        thorium_wall_large,
        phase_wall,
        phase_wall_large,
        surge_wall,
        surge_wall_large,
        door,
        door_large,
        scrap_wall,
        scrap_wall_large,
        scrap_wall_huge,
        scrap_wall_gigantic,
        thruster,
        beryllium_wall,
        beryllium_wall_large,
        tungsten_wall,
        tungsten_wall_large,
        blast_door,
        reinforced_surge_wall,
        reinforced_surge_wall_large,
        carbide_wall,
        carbide_wall_large,
        shielded_wall,
        mender,
        mend_projector,
        overdrive_projector,
        overdrive_dome,
        force_projector,
        shock_mine,
        radar,
        build_tower,
        regen_projector,
        shockwave_tower,
        shield_projector,
        large_shield_projector,
        conveyor,
        titanium_conveyor,
        plastanium_conveyor,
        armored_conveyor,
        junction,
        bridge_conveyor,
        phase_conveyor,
        sorter,
        inverted_sorter,
        router,
        distributor,
        overflow_gate,
        underflow_gate,
        mass_driver,
        duct,
        armored_duct,
        duct_router,
        overflow_duct,
        underflow_duct,
        duct_bridge,
        duct_unloader,
        surge_conveyor,
        surge_router,
        unit_cargo_loader,
        unit_cargo_unload_point,
        mechanical_pump,
        rotary_pump,
        impulse_pump,
        conduit,
        pulse_conduit,
        plated_conduit,
        liquid_router,
        liquid_container,
        liquid_tank,
        liquid_junction,
        bridge_conduit,
        phase_conduit,
        reinforced_pump,
        reinforced_conduit,
        reinforced_liquid_junction,
        reinforced_bridge_conduit,
        reinforced_liquid_router,
        reinforced_liquid_container,
        reinforced_liquid_tank,
        power_node,
        power_node_large,
        surge_tower,
        diode,
        battery,
        battery_large,
        combustion_generator,
        thermal_generator,
        steam_generator,
        differential_generator,
        rtg_generator,
        solar_panel,
        solar_panel_large,
        thorium_reactor,
        impact_reactor,
        beam_node,
        beam_tower,
        beam_link,
        turbine_condenser,
        chemical_combustion_chamber,
        pyrolysis_generator,
        flux_reactor,
        neoplasia_reactor,
        mechanical_drill,
        pneumatic_drill,
        laser_drill,
        blast_drill,
        water_extractor,
        cultivator,
        oil_extractor,
        vent_condenser,
        cliff_crusher,
        large_cliff_crusher,
        plasma_bore,
        large_plasma_bore,
        impact_drill,
        eruption_drill,
        core_shard,
        core_foundation,
        core_nucleus,
        core_bastion,
        core_citadel,
        core_acropolis,
        container,
        vault,
        unloader,
        reinforced_container,
        reinforced_vault,
        duo,
        scatter,
        scorch,
        hail,
        wave,
        lancer,
        arc,
        parallax,
        swarmer,
        salvo,
        segment,
        tsunami,
        fuse,
        ripple,
        cyclone,
        foreshadow,
        spectre,
        meltdown,
        breach,
        diffuse,
        sublimate,
        titan,
        disperse,
        afflict,
        lustre,
        scathe,
        smite,
        malign,
        ground_factory,
        air_factory,
        naval_factory,
        additive_reconstructor,
        multiplicative_reconstructor,
        exponential_reconstructor,
        tetrative_reconstructor,
        repair_point,
        repair_turret,
        tank_fabricator,
        ship_fabricator,
        mech_fabricator,
        tank_refabricator,
        ship_refabricator,
        mech_refabricator,
        prime_refabricator,
        tank_assembler,
        ship_assembler,
        mech_assembler,
        basic_assembler_module,
        unit_repair_tower,
        payload_conveyor,
        payload_router,
        reinforced_payload_conveyor,
        reinforced_payload_router,
        payload_mass_driver,
        large_payload_mass_driver,
        small_deconstructor,
        deconstructor,
        constructor,
        large_constructor,
        payload_loader,
        payload_unloader,
        power_source,
        power_void,
        item_source,
        item_void,
        liquid_source,
        liquid_void,
        payload_source,
        payload_void,
        heat_source,
        illuminator,
        legacy_mech_pad,
        legacy_unit_factory,
        legacy_unit_factory_air,
        legacy_unit_factory_ground,
        command_center,
        launch_pad,
        advanced_launch_pad,
        landing_pad,
        interplanetary_accelerator,
        message,
        switch_block,
        micro_processor,
        logic_processor,
        hyper_processor,
        memory_cell,
        memory_bank,
        logic_display,
        large_logic_display,
        tile_logic_display,
        canvas,
        reinforced_message,
        world_processor,
        world_cell,
        world_message,
        world_switch,


    }

}

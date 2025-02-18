///////////////////////////////////////////////////////////////////////////////////////////
//    This File is generated by MineSharp.SourceGenerator and should not be modified.    //
///////////////////////////////////////////////////////////////////////////////////////////
using MineSharp.Core.Common.Biomes;
using MineSharp.Core.Common;

namespace MineSharp.Data.Biomes.Versions;

internal class Biomes_1_19 : DataVersion<BiomeType, BiomeInfo>
{
    private static Dictionary<BiomeType, BiomeInfo> Values { get; } = new()
    {
        { BiomeType.TheVoid, new BiomeInfo(0, BiomeType.TheVoid, "the_void", "The Void", BiomeCategory.None, 0.5f, true, Dimension.Overworld, 0) },
        { BiomeType.Plains, new BiomeInfo(1, BiomeType.Plains, "plains", "Plains", BiomeCategory.Plains, 0.8f, false, Dimension.Overworld, 9286496) },
        { BiomeType.SunflowerPlains, new BiomeInfo(2, BiomeType.SunflowerPlains, "sunflower_plains", "Sunflower Plains", BiomeCategory.Plains, 0.8f, false, Dimension.Overworld, 11918216) },
        { BiomeType.SnowyPlains, new BiomeInfo(3, BiomeType.SnowyPlains, "snowy_plains", "Snowy Plains", BiomeCategory.Plains, 0f, false, Dimension.Overworld, 16777215) },
        { BiomeType.IceSpikes, new BiomeInfo(4, BiomeType.IceSpikes, "ice_spikes", "Ice Spikes", BiomeCategory.Ice, 0f, false, Dimension.Overworld, 11853020) },
        { BiomeType.Desert, new BiomeInfo(5, BiomeType.Desert, "desert", "Desert", BiomeCategory.Desert, 2f, true, Dimension.Overworld, 16421912) },
        { BiomeType.Swamp, new BiomeInfo(6, BiomeType.Swamp, "swamp", "Swamp", BiomeCategory.Swamp, 0.8f, false, Dimension.Overworld, 522674) },
        { BiomeType.MangroveSwamp, new BiomeInfo(7, BiomeType.MangroveSwamp, "mangrove_swamp", "Mangrove Swamp", BiomeCategory.Forest, 0.8f, false, Dimension.Overworld, 0) },
        { BiomeType.Forest, new BiomeInfo(8, BiomeType.Forest, "forest", "Forest", BiomeCategory.Forest, 0.7f, false, Dimension.Overworld, 353825) },
        { BiomeType.FlowerForest, new BiomeInfo(9, BiomeType.FlowerForest, "flower_forest", "Flower Forest", BiomeCategory.Forest, 0.7f, false, Dimension.Overworld, 2985545) },
        { BiomeType.BirchForest, new BiomeInfo(10, BiomeType.BirchForest, "birch_forest", "Birch Forest", BiomeCategory.Forest, 0.6f, false, Dimension.Overworld, 3175492) },
        { BiomeType.DarkForest, new BiomeInfo(11, BiomeType.DarkForest, "dark_forest", "Dark Forest", BiomeCategory.Forest, 0.7f, false, Dimension.Overworld, 4215066) },
        { BiomeType.OldGrowthBirchForest, new BiomeInfo(12, BiomeType.OldGrowthBirchForest, "old_growth_birch_forest", "Old Growth Birch Forest", BiomeCategory.Forest, 0.6f, false, Dimension.Overworld, 5807212) },
        { BiomeType.OldGrowthPineTaiga, new BiomeInfo(13, BiomeType.OldGrowthPineTaiga, "old_growth_pine_taiga", "Old Growth Pine Taiga", BiomeCategory.Taiga, 0.3f, false, Dimension.Overworld, 5858897) },
        { BiomeType.OldGrowthSpruceTaiga, new BiomeInfo(14, BiomeType.OldGrowthSpruceTaiga, "old_growth_spruce_taiga", "Old Growth Spruce Taiga", BiomeCategory.Taiga, 0.25f, false, Dimension.Overworld, 8490617) },
        { BiomeType.Taiga, new BiomeInfo(15, BiomeType.Taiga, "taiga", "Taiga", BiomeCategory.Taiga, 0.25f, false, Dimension.Overworld, 747097) },
        { BiomeType.SnowyTaiga, new BiomeInfo(16, BiomeType.SnowyTaiga, "snowy_taiga", "Snowy Taiga", BiomeCategory.Taiga, -0.5f, false, Dimension.Overworld, 3233098) },
        { BiomeType.Savanna, new BiomeInfo(17, BiomeType.Savanna, "savanna", "Savanna", BiomeCategory.Savanna, 2f, true, Dimension.Overworld, 12431967) },
        { BiomeType.SavannaPlateau, new BiomeInfo(18, BiomeType.SavannaPlateau, "savanna_plateau", "Savanna Plateau", BiomeCategory.Savanna, 2f, true, Dimension.Overworld, 10984804) },
        { BiomeType.WindsweptHills, new BiomeInfo(19, BiomeType.WindsweptHills, "windswept_hills", "Windswept Hills", BiomeCategory.ExtremeHills, 0.2f, false, Dimension.Overworld, 6316128) },
        { BiomeType.WindsweptGravellyHills, new BiomeInfo(20, BiomeType.WindsweptGravellyHills, "windswept_gravelly_hills", "Windswept Gravelly Hills", BiomeCategory.ExtremeHills, 0.2f, false, Dimension.Overworld, 8947848) },
        { BiomeType.WindsweptForest, new BiomeInfo(21, BiomeType.WindsweptForest, "windswept_forest", "Windswept Forest", BiomeCategory.Forest, 0.2f, false, Dimension.Overworld, 2250012) },
        { BiomeType.WindsweptSavanna, new BiomeInfo(22, BiomeType.WindsweptSavanna, "windswept_savanna", "Windswept Savanna", BiomeCategory.Savanna, 2f, true, Dimension.Overworld, 15063687) },
        { BiomeType.Jungle, new BiomeInfo(23, BiomeType.Jungle, "jungle", "Jungle", BiomeCategory.Jungle, 0.95f, false, Dimension.Overworld, 5470985) },
        { BiomeType.SparseJungle, new BiomeInfo(24, BiomeType.SparseJungle, "sparse_jungle", "Sparse Jungle", BiomeCategory.Jungle, 0.95f, false, Dimension.Overworld, 6458135) },
        { BiomeType.BambooJungle, new BiomeInfo(25, BiomeType.BambooJungle, "bamboo_jungle", "Bamboo Jungle", BiomeCategory.Jungle, 0.95f, false, Dimension.Overworld, 7769620) },
        { BiomeType.Badlands, new BiomeInfo(26, BiomeType.Badlands, "badlands", "Badlands", BiomeCategory.Mesa, 2f, true, Dimension.Overworld, 14238997) },
        { BiomeType.ErodedBadlands, new BiomeInfo(27, BiomeType.ErodedBadlands, "eroded_badlands", "Eroded Badlands", BiomeCategory.Mesa, 2f, true, Dimension.Overworld, 16739645) },
        { BiomeType.WoodedBadlands, new BiomeInfo(28, BiomeType.WoodedBadlands, "wooded_badlands", "Wooded Badlands", BiomeCategory.Mesa, 2f, true, Dimension.Overworld, 11573093) },
        { BiomeType.Meadow, new BiomeInfo(29, BiomeType.Meadow, "meadow", "Meadow", BiomeCategory.Mountain, 0.5f, false, Dimension.Overworld, 9217136) },
        { BiomeType.Grove, new BiomeInfo(30, BiomeType.Grove, "grove", "Grove", BiomeCategory.Forest, -0.2f, false, Dimension.Overworld, 14675173) },
        { BiomeType.SnowySlopes, new BiomeInfo(31, BiomeType.SnowySlopes, "snowy_slopes", "Snowy Slopes", BiomeCategory.Mountain, -0.3f, false, Dimension.Overworld, 14348785) },
        { BiomeType.FrozenPeaks, new BiomeInfo(32, BiomeType.FrozenPeaks, "frozen_peaks", "Frozen Peaks", BiomeCategory.Ice, -0.7f, false, Dimension.Overworld, 15399931) },
        { BiomeType.JaggedPeaks, new BiomeInfo(33, BiomeType.JaggedPeaks, "jagged_peaks", "Jagged Peaks", BiomeCategory.Mountain, -0.7f, false, Dimension.Overworld, 14937325) },
        { BiomeType.StonyPeaks, new BiomeInfo(34, BiomeType.StonyPeaks, "stony_peaks", "Stony Peaks", BiomeCategory.Mountain, 1f, false, Dimension.Overworld, 13750737) },
        { BiomeType.River, new BiomeInfo(35, BiomeType.River, "river", "River", BiomeCategory.River, 0.5f, false, Dimension.Overworld, 255) },
        { BiomeType.FrozenRiver, new BiomeInfo(36, BiomeType.FrozenRiver, "frozen_river", "Frozen River", BiomeCategory.Ice, 0f, false, Dimension.Overworld, 10526975) },
        { BiomeType.Beach, new BiomeInfo(37, BiomeType.Beach, "beach", "Beach", BiomeCategory.Beach, 0.8f, false, Dimension.Overworld, 16440917) },
        { BiomeType.SnowyBeach, new BiomeInfo(38, BiomeType.SnowyBeach, "snowy_beach", "Snowy Beach", BiomeCategory.Beach, 0.05f, false, Dimension.Overworld, 16445632) },
        { BiomeType.StonyShore, new BiomeInfo(39, BiomeType.StonyShore, "stony_shore", "Stony Shore", BiomeCategory.Beach, 0.2f, false, Dimension.Overworld, 10658436) },
        { BiomeType.WarmOcean, new BiomeInfo(40, BiomeType.WarmOcean, "warm_ocean", "Warm Ocean", BiomeCategory.Ocean, 0.5f, false, Dimension.Overworld, 172) },
        { BiomeType.LukewarmOcean, new BiomeInfo(41, BiomeType.LukewarmOcean, "lukewarm_ocean", "Lukewarm Ocean", BiomeCategory.Ocean, 0.5f, false, Dimension.Overworld, 144) },
        { BiomeType.DeepLukewarmOcean, new BiomeInfo(42, BiomeType.DeepLukewarmOcean, "deep_lukewarm_ocean", "Deep Lukewarm Ocean", BiomeCategory.Ocean, 0.5f, false, Dimension.Overworld, 64) },
        { BiomeType.Ocean, new BiomeInfo(43, BiomeType.Ocean, "ocean", "Ocean", BiomeCategory.Ocean, 0.5f, false, Dimension.Overworld, 112) },
        { BiomeType.DeepOcean, new BiomeInfo(44, BiomeType.DeepOcean, "deep_ocean", "Deep Ocean", BiomeCategory.Ocean, 0.5f, false, Dimension.Overworld, 48) },
        { BiomeType.ColdOcean, new BiomeInfo(45, BiomeType.ColdOcean, "cold_ocean", "Cold Ocean", BiomeCategory.Ocean, 0.5f, false, Dimension.Overworld, 2105456) },
        { BiomeType.DeepColdOcean, new BiomeInfo(46, BiomeType.DeepColdOcean, "deep_cold_ocean", "Deep Cold Ocean", BiomeCategory.Ocean, 0.5f, false, Dimension.Overworld, 2105400) },
        { BiomeType.FrozenOcean, new BiomeInfo(47, BiomeType.FrozenOcean, "frozen_ocean", "Frozen Ocean", BiomeCategory.Ocean, 0f, false, Dimension.Overworld, 7368918) },
        { BiomeType.DeepFrozenOcean, new BiomeInfo(48, BiomeType.DeepFrozenOcean, "deep_frozen_ocean", "Deep Frozen Ocean", BiomeCategory.Ocean, 0.5f, false, Dimension.Overworld, 4210832) },
        { BiomeType.MushroomFields, new BiomeInfo(49, BiomeType.MushroomFields, "mushroom_fields", "Mushroom Fields", BiomeCategory.Mushroom, 0.9f, false, Dimension.Overworld, 16711935) },
        { BiomeType.DripstoneCaves, new BiomeInfo(50, BiomeType.DripstoneCaves, "dripstone_caves", "Dripstone Caves", BiomeCategory.Underground, 0.8f, false, Dimension.Overworld, 12690831) },
        { BiomeType.LushCaves, new BiomeInfo(51, BiomeType.LushCaves, "lush_caves", "Lush Caves", BiomeCategory.Underground, 0.5f, false, Dimension.Overworld, 14652980) },
        { BiomeType.DeepDark, new BiomeInfo(52, BiomeType.DeepDark, "deep_dark", "Deep Dark", BiomeCategory.Underground, 0.8f, false, Dimension.Overworld, 0) },
        { BiomeType.NetherWastes, new BiomeInfo(53, BiomeType.NetherWastes, "nether_wastes", "Nether Wastes", BiomeCategory.Nether, 2f, true, Dimension.Nether, 12532539) },
        { BiomeType.WarpedForest, new BiomeInfo(54, BiomeType.WarpedForest, "warped_forest", "Warped Forest", BiomeCategory.Nether, 2f, true, Dimension.Nether, 4821115) },
        { BiomeType.CrimsonForest, new BiomeInfo(55, BiomeType.CrimsonForest, "crimson_forest", "Crimson Forest", BiomeCategory.Nether, 2f, true, Dimension.Nether, 14485512) },
        { BiomeType.SoulSandValley, new BiomeInfo(56, BiomeType.SoulSandValley, "soul_sand_valley", "Soul Sand Valley", BiomeCategory.Nether, 2f, true, Dimension.Nether, 6174768) },
        { BiomeType.BasaltDeltas, new BiomeInfo(57, BiomeType.BasaltDeltas, "basalt_deltas", "Basalt Deltas", BiomeCategory.Nether, 2f, true, Dimension.Nether, 4208182) },
        { BiomeType.TheEnd, new BiomeInfo(58, BiomeType.TheEnd, "the_end", "The End", BiomeCategory.TheEnd, 0.5f, true, Dimension.End, 8421631) },
        { BiomeType.EndHighlands, new BiomeInfo(59, BiomeType.EndHighlands, "end_highlands", "End Highlands", BiomeCategory.TheEnd, 0.5f, true, Dimension.End, 12828041) },
        { BiomeType.EndMidlands, new BiomeInfo(60, BiomeType.EndMidlands, "end_midlands", "End Midlands", BiomeCategory.TheEnd, 0.5f, true, Dimension.End, 15464630) },
        { BiomeType.SmallEndIslands, new BiomeInfo(61, BiomeType.SmallEndIslands, "small_end_islands", "Small End Islands", BiomeCategory.TheEnd, 0.5f, true, Dimension.End, 42) },
        { BiomeType.EndBarrens, new BiomeInfo(62, BiomeType.EndBarrens, "end_barrens", "End Barrens", BiomeCategory.TheEnd, 0.5f, true, Dimension.End, 9474162) },
    };
    public override Dictionary<BiomeType, BiomeInfo> Palette => Values;
}

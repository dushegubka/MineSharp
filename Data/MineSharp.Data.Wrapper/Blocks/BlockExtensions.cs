﻿using MineSharp.Core.Types;
using MineSharp.Data.Effects;
using System.Reflection;

namespace MineSharp.Data.Blocks
{
    public static class BlockExtensions
    {

        public static bool IsSolid(this Block block)
        {
            var id = block.Id;
            return !(id == Air.BlockId || id == CaveAir.BlockId || id == VoidAir.BlockId);
        }

        public static int CalculateBreakingTime(this Block block, Item? heldItem, Entity miner)
        {

            //TODO: Gamemode creative
            //if (miner.GameMode == Core.Types.Enums.GameMode.Creative) return 0;

            float toolMultiplier = heldItem?.GetToolMultiplier(block) ?? 1;
            float efficiencyLevel = 0; // TODO: Efficiency level
            float hasteLevel = miner.GetEffectLevel(HasteEffect.EffectId) ?? 0;
            float miningFatiqueLevel = miner.GetEffectLevel(MiningfatigueEffect.EffectId) ?? 0;

            toolMultiplier /= MathF.Pow(1.3f, efficiencyLevel);
            toolMultiplier /= MathF.Pow(1.2f, hasteLevel);
            toolMultiplier *= MathF.Pow(0.3f, miningFatiqueLevel);

            var damage = toolMultiplier / block.Hardness;

            var canHarvest = block.CanBeHarvested(heldItem);
            if (canHarvest)
            {
                damage /= 30f;
            } else
            {
                damage /= 100f;
            }

            if (damage > 1) return 0;

            var ticks = MathF.Ceiling(1 / damage);
            return (int)(ticks / 20 * 1000);
        }

        public static bool CanBeHarvested(this Block block, Item? item)
        {
            if (block.HarvestTools == null) return true;

            if (item == null) return false;

            return block.HarvestTools.Contains(item!.Id);
        }


        public static BlockShape[] GetBlockShape(this Block block)
        {

            var blockType = block.GetType();
            var shapeIndices = (int[])blockType.GetField("BlockShapeIndices", BindingFlags.Static | BindingFlags.NonPublic)!.GetValue(null)!;
            var idx = 0;
            if (shapeIndices.Length > 1)
            {
                idx = block.Metadata;
            }
            var shapeData = BlockShapePalette.AllBlockShapes[shapeIndices[idx]];

            return shapeData.Select(x => new BlockShape(x)).ToArray();
        }

        public static AABB[] GetBoundingBoxes(this Block block)
        {
            var blockType = block.GetType();
            var shapeIndices = (int[])blockType.GetField("BlockShapeIndices", BindingFlags.Static | BindingFlags.NonPublic)!.GetValue(null)!;
            var idx = shapeIndices.Length > 1 ? block.Metadata : 0;
            var shapeData = BlockShapePalette.AllBlockShapes[shapeIndices[idx]];
            return shapeData.Select(x => new BlockShape(x).ToBoundingBox().Offset(block.Position!.X, block.Position.Y, block.Position.Z)).ToArray();
        }
    }
}

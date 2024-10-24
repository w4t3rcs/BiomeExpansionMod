﻿using BiomeExpansion.Common.Generation;
using BiomeExpansion.Content.Tiles;
using BiomeExpansion.Content.Walls;
using BiomeExpansion.Helpers;
using Terraria;
using Terraria.IO;
using Terraria.ModLoader;
using Terraria.WorldBuilding;

namespace BiomeExpansion.Common.GenPasses;

public class InfectedMushroomCaveGenPass(string name, double loadWeight) : GenPass(name, loadWeight)
{
    protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
    { 
        progress.Message = "Generating Cave Infected Mushroom biome...";
        var caveBiomeBuilder = GenerationHelper.CreateCaveBiomeBuilder()
            .Biome(BEBiome.InfectedMushroomCave)
            .Deepness(125)
            .IsDependentBiome()
            .AboveBiome(BEBiome.InfectedMushroomSurface)
            .GroundModification(GenerationHelper.TwoDirectionDiagonalTunnelModification);
        if (WorldGen.crimson)
        {
            caveBiomeBuilder = caveBiomeBuilder
                .DefaultCaveTileGenerationStep()
                    .GenerationId(GenerationHelper.MainGenerationId)
                    .TileType(ModContent.TileType<CrimsonInfectedMushroomStone>())
                    .AndCave()
                .DefaultCaveTileGenerationStep()
                    .GenerationId(GenerationHelper.WallGenerationId)
                    .TileType(ModContent.WallType<CrimsonInfectedMushroomCaveWall>())
                    .AndCave()
                .GroundDecorationGenerationStep()
                    .TileType(ModContent.TileType<CrimsonInfectedMushroomCaveBigPlant>())
                    .Rarity(25)
                    .Width(2)
                    .Height(5)
                    .AndCave()
                .GroundDecorationGenerationStep()
                    .TileType(ModContent.TileType<CrimsonInfectedMushroomCaveRock>())
                    .Rarity(15)
                    .Width(3)
                    .Height(2)
                    .FrameCount(3)
                    .AndCave()
                .GroundDecorationGenerationStep()
                    .TileType(ModContent.TileType<CrimsonInfectedMushroomCaveBigMushroom>())
                    .Rarity(15)
                    .Width(3)
                    .Height(3)
                    .FrameCount(2)
                    .AndCave()
                .GroundDecorationGenerationStep()
                    .TileType(ModContent.TileType<CrimsonInfectedMushroomCaveVines>())
                    .SoilTiles([(ushort)ModContent.TileType<CrimsonInfectedMushroomStone>()])
                    .Rarity(4)
                    .IsPlant()
                    .IsHanging()
                    .AndCave()
                .GroundDecorationGenerationStep()
                    .TileType(ModContent.TileType<CrimsonInfectedMushroomCaveBulbVines>())
                    .SoilTiles([(ushort)ModContent.TileType<CrimsonInfectedMushroomStone>()])
                    .Rarity(4)
                    .IsPlant()
                    .IsHanging()
                    .AndCave()
                .GroundDecorationGenerationStep()
                    .TileType(ModContent.TileType<CrimsonInfectedMushroomCaveThorns>())
                    .SoilTiles([(ushort)ModContent.TileType<CrimsonInfectedMushroomStone>()])
                    .Rarity(75)
                    .IsPlant()
                    .IsBunch()
                    .AndCave()
                .GroundDecorationGenerationStep()
                    .TileType(ModContent.TileType<CrimsonInfectedMushroomCaveTallGrass>())
                    .SoilTiles([(ushort)ModContent.TileType<CrimsonInfectedMushroomStone>()])
                    .FrameCount(16)
                    .IsPlant()
                    .AndCave()
                .OreGenerationStep()
                    .TileType(ModContent.TileType<CrimsoomOre>())
                    .Rarity(100)
                    .Strength(WorldGen.genRand.Next(3, 6))
                    .Steps(WorldGen.genRand.Next(2, 6))
                    .AndCave();
        }
        else 
        {
            caveBiomeBuilder = caveBiomeBuilder
                .DefaultCaveTileGenerationStep()
                    .GenerationId(GenerationHelper.MainGenerationId)
                    .TileType(ModContent.TileType<CorruptionInfectedMushroomStone>())
                    .AndCave()
                .DefaultCaveTileGenerationStep()
                    .GenerationId(GenerationHelper.WallGenerationId)
                    .TileType(ModContent.WallType<CorruptionInfectedMushroomCaveWall>())
                    .AndCave()
                .GroundDecorationGenerationStep()
                    .TileType(ModContent.TileType<CorruptionInfectedMushroomCaveBigPlant>())
                    .Rarity(25)
                    .Width(2)
                    .Height(5)
                    .AndCave()
                .GroundDecorationGenerationStep()
                    .TileType(ModContent.TileType<CorruptionInfectedMushroomCaveRock>())
                    .Rarity(15)
                    .Width(3)
                    .Height(2)
                    .FrameCount(3)
                    .AndCave()
                .GroundDecorationGenerationStep()
                    .TileType(ModContent.TileType<CorruptionInfectedMushroomCaveBigMushroom>())
                    .Rarity(15)
                    .Width(3)
                    .Height(3)
                    .FrameCount(2)
                    .AndCave()
                .GroundDecorationGenerationStep()
                    .TileType(ModContent.TileType<CorruptionInfectedMushroomCaveVines>())
                    .SoilTiles([(ushort)ModContent.TileType<CorruptionInfectedMushroomStone>()])
                    .Rarity(4)
                    .IsPlant()
                    .IsHanging()
                    .AndCave()
                .GroundDecorationGenerationStep()
                    .TileType(ModContent.TileType<CorruptionInfectedMushroomCaveBulbVines>())
                    .SoilTiles([(ushort)ModContent.TileType<CorruptionInfectedMushroomStone>()])
                    .Rarity(4)
                    .IsPlant()
                    .IsHanging()
                    .AndCave()
                .GroundDecorationGenerationStep()
                    .TileType(ModContent.TileType<CorruptionInfectedMushroomCaveThorns>())
                    .SoilTiles([(ushort)ModContent.TileType<CorruptionInfectedMushroomStone>()])
                    .Rarity(75)
                    .IsPlant()
                    .IsBunch()
                    .AndCave()
                .GroundDecorationGenerationStep()
                    .TileType(ModContent.TileType<CorruptionInfectedMushroomCaveTallGrass>())
                    .SoilTiles([(ushort)ModContent.TileType<CorruptionInfectedMushroomStone>()])
                    .FrameCount(16)
                    .IsPlant()
                    .AndCave()
                .OreGenerationStep()
                    .TileType(ModContent.TileType<CorruptoomOre>())
                    .Rarity(100)
                    .Strength(WorldGen.genRand.Next(3, 6))
                    .Steps(WorldGen.genRand.Next(2, 6))
                    .AndCave();
        }
        
        caveBiomeBuilder.Generate();
    }
}
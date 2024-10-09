﻿using System.Collections.Generic;
using BiomeExpansion.Common.Dtos;
using BiomeExpansion.Content.Tiles;
using BiomeExpansion.Content.Walls;
using BiomeExpansion.Helpers;
using Terraria;
using Terraria.GameContent.Generation;
using Terraria.ModLoader;
using Terraria.WorldBuilding;

namespace BiomeExpansion.Common.Systems;

public class WorldGenSystem : ModSystem
{
    public override void ModifyWorldGenTasks(List<GenPass> tasks, ref double totalWeight)
    {
        int biomeGenIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Quick Cleanup"));
        if (biomeGenIndex != -1)
        {
            tasks.Insert(biomeGenIndex + 1, new PassLegacy("Infected Mushroom Biome", (progress, configuration) =>
            {
                progress.Message = "Generating BiomeExpansion biomes...";
                if (WorldGen.crimson)
                {
                    BiomeHelper.GenerateBiomeNextToEvilBiome(BEBiome.InfectedMushroom, 500, 20,
                        (ushort)ModContent.TileType<InfectedMushroomDirt>(),
                        (ushort)ModContent.TileType<CrimsonInfectedMushroomGrass>(),
                        (ushort)ModContent.TileType<CrimsonInfectedMushroomStone>(),
                        (ushort)ModContent.WallType<CrimsonInfectedMushroomWall>());
                    PlantHelper.GeneratePlant(BEBiome.InfectedMushroom, 5, 
                        (ushort)ModContent.TileType<CrimsonInfectedSmallMushroom>(), 
                        [(ushort)ModContent.TileType<CrimsonInfectedMushroomGrass>()], 5);
                    PlantHelper.GeneratePlant(BEBiome.InfectedMushroom, 3,
                        (ushort)ModContent.TileType<CrimsonInfectedMushroomTallGrass>(),
                        [(ushort)ModContent.TileType<CrimsonInfectedMushroomGrass>()], 9);
                }
                else
                {
                    BiomeHelper.GenerateBiomeNextToEvilBiome(BEBiome.InfectedMushroom, 500, 20,
                        (ushort)ModContent.TileType<InfectedMushroomDirt>(), 
                        (ushort)ModContent.TileType<CorruptionInfectedMushroomGrass>(), 
                        (ushort)ModContent.TileType<CorruptionInfectedMushroomStone>(),
                        (ushort)ModContent.WallType<CorruptionInfectedMushroomWall>());
                    PlantHelper.GeneratePlant(BEBiome.InfectedMushroom, 5,
                        (ushort)ModContent.TileType<CorruptionInfectedSmallMushroom>(),
                        [(ushort)ModContent.TileType<CorruptionInfectedMushroomGrass>()],5);
                    PlantHelper.GeneratePlant(BEBiome.InfectedMushroom, 3,
                        (ushort)ModContent.TileType<CorruptionInfectedMushroomTallGrass>(),
                        [(ushort)ModContent.TileType<CorruptionInfectedMushroomGrass>()], 9);
                }
                
                BiomeHelper.BEBiomesXCoordinates.Remove(BEBiome.InfectedMushroom);
            }));
        }
    }
}
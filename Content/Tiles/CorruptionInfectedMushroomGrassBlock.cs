﻿using BiomeExpansion.Common.Dtos;
using Microsoft.Xna.Framework;
using Terraria.ID;

namespace BiomeExpansion.Content.Tiles;

public class CorruptionInfectedMushroomGrassBlock : InfectedMushroomGrassTile
{
    public override string Texture => "BiomeExpansion/Assets/Tiles/CorruptionInfectedMushroomGrassBlock";
    
    public override void SetStaticDefaults()
    {
        base.SetStaticDefaults();
        DustType = DustID.Corruption;
        AddMapEntry(Color.MediumPurple);
    }
}
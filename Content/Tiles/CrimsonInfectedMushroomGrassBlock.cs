﻿using BiomeExpansion.Common.Dtos;
using BiomeExpansion.Common.Utils;
using Microsoft.Xna.Framework;
using Terraria.ID;

namespace BiomeExpansion.Content.Tiles;

public class CrimsonInfectedMushroomGrassBlock : InfectedMushroomGrassTile
{
    public override string Texture => TextureUtil.GetDynamicTileTexture("CrimsonInfectedMushroomGrassBlock");
    
    public override void SetStaticDefaults()
    {
        base.SetStaticDefaults();
        DustType = DustID.Crimson;
        AddMapEntry(Color.Crimson);
    }
}
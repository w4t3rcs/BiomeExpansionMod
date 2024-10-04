﻿using BiomeExpansion.Common.Utils;
using Terraria.ModLoader;

namespace BiomeExpansion.Content.Items.Placeable;

public class CorruptionInfectedSmallMushroom : ModItem
{
    public override string Texture => TextureUtil.GetDynamicTileItemTexture("CorruptionInfectedSmallMushroom");
    
    public override void SetStaticDefaults()
    {
        Item.ResearchUnlockCount = 100;
    }

    public override void SetDefaults()
    {
        Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.CorruptionInfectedSmallMushroom>());
        Item.width = 12;
        Item.height = 12;
    }
}
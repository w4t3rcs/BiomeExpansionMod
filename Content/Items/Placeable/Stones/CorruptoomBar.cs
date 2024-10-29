﻿using BiomeExpansion.Helpers;
using Terraria.ModLoader;

namespace BiomeExpansion.Content.Items.Placeable.Stones;

public class CorruptoomBar : ModItem
{
    public override string Texture => TextureHelper.GetDynamicItemTexture("CorruptoomBar");
    
    public override void SetStaticDefaults()
    {
        Item.ResearchUnlockCount = 100;
    }

    public override void SetDefaults()
    {
        Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Stones.CorruptoomBar>());
        Item.width = 12;
        Item.height = 12;
    }
}
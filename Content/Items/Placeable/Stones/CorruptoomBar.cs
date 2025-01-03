﻿namespace BiomeExpansion.Content.Items.Placeable.Stones;

public class CorruptoomBar : ModItem
{
    public override string Texture => TextureHelper.DynamicItemsTextures["CorruptoomBar"];
    
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
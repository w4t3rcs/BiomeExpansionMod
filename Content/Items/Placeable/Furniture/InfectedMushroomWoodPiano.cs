﻿using BiomeExpansion.Helpers;
using Terraria.ModLoader;

namespace BiomeExpansion.Content.Items.Placeable.Furniture;

public class InfectedMushroomWoodPiano : ModItem
{
    public override string Texture => TextureHelper.GetDynamicItemTexture("InfectedMushroomWoodPiano");
    
    public override void SetStaticDefaults()
    {
        Item.ResearchUnlockCount = 100;
    }

    public override void SetDefaults()
    {
        Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.InfectedMushroomWoodPiano>());
        Item.width = 34;
        Item.height = 26;
    }
}
﻿using BiomeExpansion.Content.Tiles.Furniture;

namespace BiomeExpansion.Content.Items.Placeable.Furniture;

public class CrimsonInfectedMushroomWoodDoor : ModItem
{
    public override string Texture => TextureHelper.DynamicItemsTextures["InfectedMushroomWoodDoor"];
    
    public override void SetStaticDefaults()
    {
        Item.ResearchUnlockCount = 100;
    }

    public override void SetDefaults()
    {
        Item.DefaultToPlaceableTile(ModContent.TileType<CrimsonInfectedMushroomWoodDoorClosed>());
        Item.width = 20;
        Item.height = 32;
    }
}
﻿namespace BiomeExpansion.Content.Items.Walls;

public class CrimsonInfectedMushroomWoodFence : ModItem
{
    public override string Texture => TextureHelper.DynamicItemsTextures["CrimsonInfectedMushroomWoodFence"];
    
    public override void SetStaticDefaults()
    {
        Item.ResearchUnlockCount = 100;
    }

    public override void SetDefaults()
    {
        Item.DefaultToPlaceableWall(ModContent.WallType<Content.Walls.CrimsonInfectedMushroomWoodFence>());
        Item.width = 30;
        Item.height = 30;
    }
}
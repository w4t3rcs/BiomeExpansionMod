﻿namespace BiomeExpansion.Content.Items.Walls;

public class CrimsonInfectedMushroomWoodWall : ModItem
{
    public override string Texture => TextureHelper.DynamicItemsTextures["CrimsonInfectedMushroomWoodWall"];
    
    public override void SetStaticDefaults()
    {
        Item.ResearchUnlockCount = 100;
    }

    public override void SetDefaults()
    {
        Item.DefaultToPlaceableWall(ModContent.WallType<Content.Walls.CrimsonInfectedMushroomWoodWall>());
        Item.width = 24;
        Item.height = 24;
    }
}
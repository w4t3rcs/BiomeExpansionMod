﻿namespace BiomeExpansion.Content.Items.Placeable.Plants;

public class CrimsonInfectedSmallMushroom : ModItem
{
    public override string Texture => TextureHelper.DynamicItemsTextures["CrimsonInfectedSmallMushroom"];
    
    public override void SetStaticDefaults()
    {
        Item.ResearchUnlockCount = 100;
    }

    public override void SetDefaults()
    {
        Item.width = 12;
        Item.height = 12;
        Item.maxStack = Item.CommonMaxStack;
    }
}
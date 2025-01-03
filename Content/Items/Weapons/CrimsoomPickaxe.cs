﻿namespace BiomeExpansion.Content.Items.Weapons;

public class CrimsoomPickaxe : ModItem
{
    public override string Texture => TextureHelper.DynamicItemsTextures["CrimsoomPickaxe"];

    public override void SetDefaults()
    {
        Item.width = 50;
        Item.height = 40;
        Item.useStyle = ItemUseStyleID.Swing;
        Item.useTime = 20;
        Item.useAnimation = 20;
        Item.autoReuse = true;
        Item.DamageType = DamageClass.Melee;
        Item.damage = 10;
        Item.knockBack = 2;
        Item.UseSound = SoundID.Item1;
        Item.pick = 60;
        Item.attackSpeedOnlyAffectsWeaponAnimation = true;
    }
    
    public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
    {
        FrameHelper.DrawItemWithGlowMask(spriteBatch, Texture, Item, rotation);
    }
}
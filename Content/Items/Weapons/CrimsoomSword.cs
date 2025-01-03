﻿using BiomeExpansion.Core.Particle;

namespace BiomeExpansion.Content.Items.Weapons;

public class CrimsoomSword : ModItem
{
    public override string Texture => TextureHelper.DynamicItemsTextures["CrimsoomSword"];

    public override void SetDefaults()
    {
        Item.width = 60;
        Item.height = 62;
        Item.useStyle = ItemUseStyleID.Swing;
        Item.useTime = 20;
        Item.useAnimation = 20;
        Item.autoReuse = true;
        Item.DamageType = DamageClass.Melee;
        Item.damage = 31;
        Item.knockBack = 5;
        Item.crit = 6;
        Item.UseSound = SoundID.Item1;
    }
    
    public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
    {
        FrameHelper.DrawItemWithGlowMask(spriteBatch, Texture, Item, rotation);
    }

    public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
    {
        // ParticleOrchestraHelper.SpawnOnHit(new TrueNightEdgeParticleOrchestraType(), player.whoAmI, target, [new Color(0.6f, 0.1f, 0.1f, 0.5f), Color.Gold], DustID.CrimsonTorch);
        ParticleOrchestraHelper.SpawnOnHit(new TerraBladeParticleOrchestraType(), player.whoAmI, target, [new Color(0.6f, 0.1f, 0.1f, 0.6f), new Color(0.9f, 0.6f, 0.1f, 0.6f), new Color(1.0f, 0.9f, 0.0f, 0.6f)], DustID.RedTorch);
    }
}
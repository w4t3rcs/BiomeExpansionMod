using BiomeExpansion.Content.Biomes;
using BiomeExpansion.Content.Buffs;
using BiomeExpansion.Helpers;
using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.ID;
using Terraria.ModLoader;

namespace BiomeExpansion.Content.NPCs;

internal class CrimsonInfectedSmallWormHead : WormHead
{
    public override string Texture => TextureHelper.DynamicNPCsTextures["CrimsonInfectedSmallWormHead"];
    public override int BodyType => ModContent.NPCType<CrimsonInfectedSmallWormBody>();
    public override int TailType => ModContent.NPCType<CrimsonInfectedSmallWormTail>();

    public override void SetDefaults() {
        NPC.aiStyle = -1;
        NPC.CloneDefaults(NPCID.DiggerHead);
        NPC.damage = 30;
        NPC.defense = 2;
        NPC.lifeMax = 30;
        NPC.value = Item.buyPrice(0, 0, 10, 0);
        Banner = NPC.type;
        SpawnModBiomes = [ModContent.GetInstance<CrimsonInfectedMushroomSurfaceBiome>().Type];
        // BannerItem = ModContent.ItemType<>();
        NPCHelper.AdjustExpertMode(NPC, false);
        NPCHelper.AdjustMasterMode(NPC, false);
    }

    public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
    {
        bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[]
        {
            BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.TheCrimson,
            new FlavorTextBestiaryInfoElement("Mods.BiomeExpansion.Bestiary.CrimsonInfectedSmallWorm")
        });
    }

    public override float SpawnChance(NPCSpawnInfo spawnInfo)
    {
        if (spawnInfo.Player.InModBiome<CrimsonInfectedMushroomSurfaceBiome>())
        {
            if (spawnInfo.Player.ZoneDirtLayerHeight || spawnInfo.Player.ZoneRockLayerHeight)
            {
                return 0.33f;
            }

            return 0.15f;
        }
        
        return 0;
    }

    public override void OnHitPlayer(Player target, Player.HurtInfo hurtInfo)
    {
        if (hurtInfo.Damage > 0)
        {
            target.AddBuff(ModContent.BuffType<CrimsonSporeInfectionDebuff>(), 1200, true);
        }
    }

    public override void HitEffect(NPC.HitInfo hit)
    {
        NPCHelper.DoHitDust(NPC, hit.HitDirection, DustID.Crimson);
    }

    public override void Init() {
		MinSegmentLength = 6;
		MaxSegmentLength = 12;
		CommonWormInit(this);
	}

	internal static void CommonWormInit(Worm worm) {
		worm.MoveSpeed = 6f;
		worm.Acceleration = 0.12f;
	}
}

internal class CrimsonInfectedSmallWormBody : WormBody
{
    public override string Texture => TextureHelper.DynamicNPCsTextures["CrimsonInfectedSmallWormBody"];
    public override void SetStaticDefaults()
    {
        NPCID.Sets.NPCBestiaryDrawModifiers value = new NPCID.Sets.NPCBestiaryDrawModifiers() {
			Hide = true
        };
        NPCID.Sets.NPCBestiaryDrawOffset.Add(NPC.type, value);
    }

    public override void SetDefaults() {
		NPC.aiStyle = -1;
        NPC.CloneDefaults(NPCID.DiggerBody);
        NPC.damage = 13;
        NPC.defense = 7;
        NPC.lifeMax = 30;
        NPCHelper.AdjustExpertMode(NPC, false);
        NPCHelper.AdjustMasterMode(NPC, false);
    }

    public override void OnHitPlayer(Player target, Player.HurtInfo hurtInfo)
    {
        if (hurtInfo.Damage > 0)
        {
            target.AddBuff(ModContent.BuffType<CrimsonSporeInfectionDebuff>(), 1200, true);
        }
    }

    public override void HitEffect(NPC.HitInfo hit)
    {
        NPCHelper.DoHitDust(NPC, hit.HitDirection, DustID.Crimson);
    }

    public override void Init()
    {
        CrimsonInfectedSmallWormHead.CommonWormInit(this);
    }
}

internal class CrimsonInfectedSmallWormTail : WormTail
{
    public override string Texture => TextureHelper.DynamicNPCsTextures["CrimsonInfectedSmallWormTail"];
    public override void SetStaticDefaults()
    {
        NPCID.Sets.NPCBestiaryDrawModifiers value = new NPCID.Sets.NPCBestiaryDrawModifiers() {
			Hide = true
        };
        NPCID.Sets.NPCBestiaryDrawOffset.Add(NPC.type, value);
    }

    public override void SetDefaults() {
		NPC.aiStyle = -1;
        NPC.CloneDefaults(NPCID.DiggerTail);
        NPC.damage = 15;
        NPC.defense = 15;
        NPC.lifeMax = 30;
        NPCHelper.AdjustExpertMode(NPC, false);
        NPCHelper.AdjustMasterMode(NPC, false);
    }

    public override void OnHitPlayer(Player target, Player.HurtInfo hurtInfo)
    {
        if (hurtInfo.Damage > 0)
        {
            target.AddBuff(ModContent.BuffType<CrimsonSporeInfectionDebuff>(), 1200, true);
        }
    }

    public override void HitEffect(NPC.HitInfo hit)
    {
        NPCHelper.DoHitDust(NPC, hit.HitDirection, DustID.Crimson);
    }

    public override void Init()
    {
        CrimsonInfectedSmallWormHead.CommonWormInit(this);
    }
}
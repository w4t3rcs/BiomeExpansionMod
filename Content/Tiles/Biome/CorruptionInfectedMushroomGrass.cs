﻿using BiomeExpansion.Content.Tiles.Stones;
using BiomeExpansion.Content.Waters;

namespace BiomeExpansion.Content.Tiles.Biome;

public class CorruptionInfectedMushroomGrass : ModTile
{
    public override string Texture => TextureHelper.DynamicTilesTextures["CorruptionInfectedMushroomGrass"];
    
    public override void SetStaticDefaults()
    {
        TileHelper.SetGrass(Type, (ushort)ModContent.TileType<InfectedMushroomDirt>());
        Main.tileMerge[Type][ModContent.TileType<CorruptionInfectedMushroomStone>()] = true;
        Main.tileMerge[Type][ModContent.TileType<CorruptoomOre>()] = true;
        HitSound = SoundID.Grass;
        DustType = DustID.Corruption;
        AddMapEntry(Color.MediumPurple);
        RegisterItemDrop(ModContent.ItemType<Items.Placeable.Biome.InfectedMushroomDirt>());
    }
    
    public override void ChangeWaterfallStyle(ref int style)
    {
        style = ModContent.GetInstance<CorruptionInfectedMushroomWaterfallStyle>().Slot;
    }
}
﻿using BiomeExpansion.Content.Tiles.Stones;
using BiomeExpansion.Content.Waters;

namespace BiomeExpansion.Content.Tiles.Biome;

public class CrimsonInfectedMushroomGrass : ModTile
{
    public override string Texture => TextureHelper.DynamicTilesTextures["CrimsonInfectedMushroomGrass"];
    public override void SetStaticDefaults()
    {
        TileHelper.SetGrass(Type, (ushort)ModContent.TileType<InfectedMushroomDirt>());
        Main.tileMerge[Type][ModContent.TileType<CrimsonInfectedMushroomStone>()] = true;
        Main.tileMerge[Type][ModContent.TileType<CrimsoomOre>()] = true;
        HitSound = SoundID.Grass;
        DustType = DustID.Crimson;
        AddMapEntry(Color.Crimson);
        RegisterItemDrop(ModContent.ItemType<Items.Placeable.Biome.InfectedMushroomDirt>());
    }
    
    
    public override void ChangeWaterfallStyle(ref int style)
    {
        style = ModContent.GetInstance<CrimsonInfectedMushroomWaterfallStyle>().Slot;
    }
}
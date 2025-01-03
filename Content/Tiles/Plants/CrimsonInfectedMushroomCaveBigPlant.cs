﻿using BiomeExpansion.Content.Tiles.Stones;
using BiomeExpansion.Core.Generation;
using Terraria.ObjectData;

namespace BiomeExpansion.Content.Tiles.Plants;

public class CrimsonInfectedMushroomCaveBigPlant : ModTile
{
    public override string Texture => TextureHelper.DynamicTilesTextures["CrimsonInfectedMushroomCaveBigPlant"];

    public override void SetStaticDefaults()
    {
        TileHelper.SetCustomXCustomBiomeSurfaceDecoration(Type, 2, 5);
        TileObjectData.newTile.AnchorValidTiles = [ModContent.TileType<CorruptionInfectedMushroomOldStone>()];
        this.AddGenerationTileData(TileObjectData.newTile);
        TileObjectData.addTile(Type);
        HitSound = SoundID.Dig;
        DustType = DustID.CrimsonPlants;
        AddMapEntry(Color.Crimson);
    }

    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
}
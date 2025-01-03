﻿namespace BiomeExpansion.Content.Tiles.Stones;

public class CorruptionInfectedMushroomOldStone : ModTile
{
    public override string Texture => TextureHelper.DynamicTilesTextures["CorruptionInfectedMushroomOldStone"];

    public override void SetStaticDefaults()
    {
        TileHelper.SetStone(Type);
        Main.tileMerge[Type][ModContent.TileType<CorruptionInfectedMushroomStone>()] = true;
        HitSound = SoundID.Tink;
        DustType = DustID.Corruption;
        AddMapEntry(Color.Purple);
        RegisterItemDrop(ModContent.ItemType<Items.Placeable.Stones.CorruptionInfectedMushroomOldStone>());
    }

    public override bool IsTileBiomeSightable(int i, int j, ref Color sightColor)
    {
        sightColor = Color.Purple;
        return true;
    }
    
    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
}
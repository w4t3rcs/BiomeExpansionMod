﻿using BiomeExpansion.Content.Tiles.Biome;
using BiomeExpansion.Content.Tiles.Stones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiomeExpansion.Content.Tiles.Gel;

public class CorruptionInfectedGelPlatform : ModTile
{
    public override string Texture => TextureHelper.DynamicTilesTextures["CorruptionInfectedGelPlatform"];

    public override void SetStaticDefaults()
    {
        TileHelper.SetPlatform(this);
        HitSound = SoundID.Dig;
        DustType = DustID.Corruption;
        AddMapEntry(Color.Purple);
        RegisterItemDrop(ModContent.ItemType<Items.Placeable.Gel.CorruptionInfectedGelPlatform>());
    }
}
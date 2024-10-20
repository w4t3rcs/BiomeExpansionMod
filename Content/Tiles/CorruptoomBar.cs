﻿using BiomeExpansion.Helpers;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace BiomeExpansion.Content.Tiles;

public class CorruptoomBar : ModTile
{
    public override string Texture => TextureHelper.GetDynamicTileTexture("CorruptoomBar");

    public override void SetStaticDefaults()
    {
        TileHelper.SetBar(Type);
        TileObjectData.addTile(Type);
        HitSound = SoundID.Dig;
        DustType = DustID.Corruption;
        AddMapEntry(Color.Purple);
        RegisterItemDrop(ModContent.ItemType<Items.Placeable.CorruptoomBar>());
    }
}
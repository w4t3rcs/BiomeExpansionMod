﻿using BiomeExpansion.Content.Tiles;
using Terraria;
using Terraria.GameContent.Metadata;
using Terraria.ID;
using Terraria.ModLoader;

namespace BiomeExpansion.Common.Dtos;

public abstract class InfectedMushroomGrassTile : ModTile
{
    public override void SetStaticDefaults()
    {
        Main.tileSolid[Type] = true;
        Main.tileMerge[Type][ModContent.TileType<InfectedMushroomDirt>()] = true;
        Main.tileMergeDirt[Type] = true;
        Main.tileBlockLight[Type] = true;
        Main.tileLighted[Type] = true;
        TileMaterials.SetForTileId(Type, TileMaterials._materialsByName["Grass"]);
        TileID.Sets.Grass[Type] = true;
        TileID.Sets.Conversion.Grass[Type] = true;
        TileID.Sets.NeedsGrassFraming[Type] = true;
        TileID.Sets.NeedsGrassFramingDirt[Type] = ModContent.TileType<InfectedMushroomDirt>();
        TileID.Sets.CanBeDugByShovel[Type] = true;
        RegisterItemDrop(ModContent.ItemType<Content.Items.Placeable.InfectedMushroomDirt>());
    }
}
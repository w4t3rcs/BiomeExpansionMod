﻿using Terraria.DataStructures;
using Terraria.ObjectData;

namespace BiomeExpansion.Content.Tiles.Furniture;

public class CrimsonInfectedMushroomWoodLantern : ModTile
{
    public override string Texture => TextureHelper.DynamicTilesTextures["CrimsonInfectedMushroomWoodLantern"];

    public override void SetStaticDefaults()
    {
        TileHelper.SetLantern(this);
        TileObjectData.addTile(Type);
        HitSound = SoundID.Dig;
        DustType = DustID.OrangeTorch;
        AddMapEntry(Color.Cyan);
        RegisterItemDrop(ModContent.ItemType<Items.Placeable.Furniture.CrimsonInfectedMushroomWoodLantern>());
    }

    public override void SetDrawPositions(int i, int j, ref int width, ref int offsetY, ref int height, ref short tileFrameX, ref short tileFrameY)
    {
        Tile tile = Main.tile[i, j];
        TileObjectData data = TileObjectData.GetTileData(tile);
        int topLeftX = i - tile.TileFrameX / 18 % data.Width;
        int topLeftY = j - tile.TileFrameY / 18 % data.Height;
        if (WorldGen.IsBelowANonHammeredPlatform(topLeftX, topLeftY))
            offsetY -= 8;
    }

    public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
    {
        Tile tile = Main.tile[i, j];
        if (tile.TileFrameX < 18)
        {
            r = 1.5f;
            g = 0.7f;
            b = 0.1f;
        }
        else
        {
            r = 0f;
            g = 0f;
            b = 0f;
        }
    }
    
    public override void PostDraw(int i, int j, SpriteBatch spriteBatch)
    {
        // FrameHelper.DrawFlameEffect(ModContent.Request<Texture2D>("BiomeExpansion/Assets/Tiles/Furniture/CrimsonInfectedMushroomWoodLanternFlame").Value, i, j, 0, -8);
    }

    public override void DrawEffects(int i, int j, SpriteBatch spriteBatch, ref TileDrawInfo drawData)
    {
        if (Main.tile[i, j].TileFrameX < 18)
            FrameHelper.DrawFlameSparks(DustID.Flare, 7, i, j);
    }
    
    public override void HitWire(int i, int j)
    {
        FrameHelper.LightHitWire(Type, i, j, 1, 2);
    }
    
    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
}
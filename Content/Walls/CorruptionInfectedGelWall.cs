﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiomeExpansion.Content.Walls;

public class CorruptionInfectedGelWall : ModWall
{
    public override string Texture => TextureHelper.DynamicWallsTextures["CorruptionInfectedGelWall"];

    public override void SetStaticDefaults()
    {
        Main.wallHouse[Type] = true;
        DustType = DustID.Corruption;
        AddMapEntry(Color.Purple);
    }

    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
}
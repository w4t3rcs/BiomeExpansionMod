﻿using BiomeExpansion.Helpers;

namespace BiomeExpansion.Common.Generation;

public class GroundDecorationGenerationStep
{
    public GenerationHelper.SurfaceBiomeBuilder SurfaceBiomeBuilder;
    public GenerationHelper.CaveBiomeBuilder CaveBiomeBuilder;
    public sbyte rarity = 1;
    public int tileType;
    public ushort[] soilTiles = [];
    public sbyte frameCount = 0;
    public sbyte width = 1;
    public sbyte height = 1;
    public bool isPlant = false;
    public bool isHanging = false;
    public bool isBunch = false;
    public bool isSeaOats = false;
    public bool isLilyPad = false;

    public GroundDecorationGenerationStep(GenerationHelper.SurfaceBiomeBuilder surfaceBiomeBuilder)
    {
        this.SurfaceBiomeBuilder = surfaceBiomeBuilder;
    }
    
    public GroundDecorationGenerationStep(GenerationHelper.CaveBiomeBuilder caveBiomeBuilder)
    {
        this.CaveBiomeBuilder = caveBiomeBuilder;
    }
    
    public GroundDecorationGenerationStep Rarity(sbyte rarity)
    {
        this.rarity = rarity;
        return this;
    }
    
    public GroundDecorationGenerationStep TileType(int tileType)
    {
        this.tileType = tileType;
        return this;
    }
    
    public GroundDecorationGenerationStep SoilTiles(ushort[] soilTiles)
    {
        this.soilTiles = soilTiles;
        return this;
    }

    public GroundDecorationGenerationStep FrameCount(sbyte frameCount)
    {
        this.frameCount = frameCount;
        return this;
    }
    
    public GroundDecorationGenerationStep Width(sbyte width)
    {
        this.width = width;
        return this;
    }
    
    public GroundDecorationGenerationStep Height(sbyte height)
    {
        this.height = height;
        return this;
    }
    
    public GroundDecorationGenerationStep IsPlant()
    {
        this.isPlant = true;
        return this;
    }
    
    public GroundDecorationGenerationStep IsHanging()
    {
        this.isHanging = true;
        return this;
    }
    
    public GroundDecorationGenerationStep IsBunch()
    {
        this.isBunch = true;
        return this;
    }

    public GroundDecorationGenerationStep IsSeaOats()
    {
        this.isSeaOats = true;
        return this;
    }
    
    public GroundDecorationGenerationStep IsLilyPad()
    {
        this.isLilyPad = true;
        return this;
    }

    public GenerationHelper.SurfaceBiomeBuilder AndSurface()
    {
        SurfaceBiomeBuilder.GroundDecorationGenerationSteps.Add(this);
        return SurfaceBiomeBuilder;
    }
    
    public GenerationHelper.CaveBiomeBuilder AndCave()
    {
        CaveBiomeBuilder.GroundDecorationGenerationSteps.Add(this);
        return CaveBiomeBuilder;
    }
}
﻿/*
 * Copyright (C) 2011 - 2013 Voxeliq Engine - http://www.voxeliq.org - https://github.com/raistlinthewiz/voxeliq
 *
 * This program is free software; you can redistribute it and/or modify 
 * it under the terms of the Microsoft Public License (Ms-PL).
 */

using VoxeliqEngine.Blocks;

namespace VoxeliqEngine.Chunks.Generators.Biomes
{
    /// <summary>
    /// Antartic tundra generator.
    /// </summary>
    public sealed class AntarticTundra : BiomeGenerator
    {
        private const byte SnowDepth = 5;

        public override void ApplyBiome(Chunk chunk, int groundLevel, int groundOffset, int worldPositionX, int worldPositionZ)
        {
            for (int y = 0; y < SnowDepth; y++)
            {
                BlockStorage.Blocks[groundOffset + y].Type = BlockType.Snow;
            }

            if (groundLevel + SnowDepth > chunk.HighestSolidBlockOffset)
                chunk.HighestSolidBlockOffset = (byte)(groundLevel + SnowDepth);
        }
    }
}
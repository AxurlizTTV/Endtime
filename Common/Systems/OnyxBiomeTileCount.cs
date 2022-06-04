using System;
using Endtime.Content.Tiles;
using Terraria.ModLoader;

namespace Endtime.Common.Systems
{
    public class OnyxBiomeTileCount : ModSystem
    {
        public int OnyxBlockCount;

        public override void TileCountsAvailable(ReadOnlySpan<int> tileCounts)
        {
            OnyxBlockCount = tileCounts[ModContent.TileType<OnyxBlock>()];
        }
    }
}
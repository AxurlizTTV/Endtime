using Terraria;
using Terraria.ModLoader;
using Terraria.IO;
using Terraria.WorldBuilding;
using Endtime.Content.Tiles;
using Terraria.ID;

namespace Endtime.Common.Systems.GenPasses
{
    internal class EndtimeOreGenPass : GenPass
    {
        public EndtimeOreGenPass(string name, float weight) : base(name, weight) {}

        protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
        {
            progress.Message = "Spawning End Time Ores";

            for (int k = 0; k < (int)(Main.maxTilesX * Main.maxTilesY * 1E-3); k++) {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY);

                Tile tile = Framing.GetTileSafely(x, y);
				if (tile.TileType == TileID.Sandstone || tile.TileType == TileID.DesertFossil)
				{
					WorldGen.TileRunner(x, y, WorldGen.genRand.Next(5, 8), WorldGen.genRand.Next(3, 6), ModContent.TileType<ElectrumOre>());
				}
            }

            for (int k = 0; k < (int)(Main.maxTilesX * Main.maxTilesY * 6E-05); k++) {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next((int)WorldGen.rockLayer, Main.maxTilesY);

                    WorldGen.TileRunner(x, y, WorldGen.genRand.Next(5, 8), WorldGen.genRand.Next(3, 6), ModContent.TileType<InfernalOre>());
            }
        }
    }
}
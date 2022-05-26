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

            for (int k = 0; k < (int)(Main.maxTilesX * Main.maxTilesY * 6E-05); k++) {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY);

                    WorldGen.TileRunner(x, y, WorldGen.genRand.Next(5, 8), WorldGen.genRand.Next(3, 6), ModContent.TileType<ElectrumOre>());
            }

            for (int k = 0; k < (int)(Main.maxTilesX * Main.maxTilesY * 6E-05); k++) {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY);

                    WorldGen.TileRunner(x, y, WorldGen.genRand.Next(5, 8), WorldGen.genRand.Next(3, 6), ModContent.TileType<InfernalOre>());
            }

            // int maxToSpawn = (int)(Main.maxTilesX * Main.maxTilesY * 6E-05);
            // for(int i = 0; i < maxToSpawn; i++)
            // {
            //     int x = WorldGen.genRand.Next(0, Main.maxTilesX);
            //     int y = WorldGen.genRand.Next((int)WorldGen.worldSurface, Main.maxTilesY);

            //     WorldGen.TileRunner(x, y, WorldGen.genRand.Next(5, 8), WorldGen.genRand.Next(3, 6), ModContent.TileType<ElectrumOre>());
            // }

            // maxToSpawn = WorldGen.genRand.Next(100, 250);
            // int numSpawned = 0;
            // int attempts = 0;
            // while(numSpawned < maxToSpawn)
            // {
            //     int x = WorldGen.genRand.Next(0, Main.maxTilesX);
            //     int y = WorldGen.genRand.Next((int)WorldGen.rockLayerLow, Main.maxTilesY);

            //     Tile tile = Framing.GetTileSafely(x, y);
            //     if(tile.TileType == TileID.Ash || tile.TileType == TileID.Hellstone)
            //     {
            //         WorldGen.TileRunner(x, y, WorldGen.genRand.Next(2, 5), WorldGen.genRand.Next(1, 4), ModContent.TileType<FierymOre>());
            //         numSpawned++;
            //     }

            //     attempts++;
            //     if(attempts >= 100000)
            //     {
            //         break;
            //     }
            // }
        }
    }
}
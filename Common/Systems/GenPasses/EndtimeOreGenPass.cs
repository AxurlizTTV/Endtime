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

            int maxElectrum = (int)(Main.maxTilesX * Main.maxTilesY * 6E-05);
            int electrumSpawned = 0;
            int electrumAttempts = 0;

            while(electrumSpawned < maxElectrum)
            {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX); 
                int y = WorldGen.genRand.Next(0, Main.maxTilesY);

                Tile tile = Framing.GetTileSafely(x, y);
                if(tile.TileType == TileID.Sandstone || tile.TileType == TileID.DesertFossil)
                {
                    WorldGen.TileRunner(x, y, WorldGen.genRand.Next(5, 8), WorldGen.genRand.Next(3, 6), ModContent.TileType<ElectrumOre>());
                    electrumSpawned++;
                }

                electrumAttempts++;
                if(electrumAttempts >= 10000)
                {
                    break;
                }
            }

            int maxInfernal = (int)(Main.maxTilesX * Main.maxTilesY * 6E-03);
            int infernalSpawned = 0;
            int infernalAttempts = 0;
            
            while(infernalSpawned < maxInfernal)
            {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next(0, Main.maxTilesY);

                Tile tile = Framing.GetTileSafely(x, y);
				if (tile.LiquidType == LiquidID.Lava)
				{
					WorldGen.TileRunner(x, y, 8, WorldGen.genRand.Next(3, 6), ModContent.TileType<InfernalOre>());
                    infernalSpawned++;
				}

                infernalAttempts++;
                if(infernalAttempts >= 250000)
                {
                    break;
                }
            }

            int maxHailstone = (int)(Main.maxTilesX * Main.maxTilesY * 6E-05);
            int hailstoneSpawned = 0;
            int hailstoneAttempts = 0;

            while(hailstoneSpawned < maxHailstone)
            {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next(0, Main.maxTilesY);

                Tile tile = Framing.GetTileSafely(x, y);
                if(tile.TileType == TileID.Slush || tile.TileType == TileID.SnowBlock || tile.TileType == TileID.IceBlock)
                {
                    WorldGen.TileRunner(x, y, WorldGen.genRand.Next(5, 8), WorldGen.genRand.Next(3, 6), ModContent.TileType<HailstoneOre>());
                    hailstoneSpawned++;
                }

                hailstoneAttempts++;
                if(hailstoneAttempts >= 10000)
                {
                    break;
                }
            }
        }
    }
}
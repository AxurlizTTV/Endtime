using Terraria;
using Terraria.ModLoader;
using Terraria.IO;
using Terraria.WorldBuilding;
using Endtime.Content.Tiles;

namespace Endtime.Common.Systems.GenPasses
{
    internal class EndtimeOreGenPass : GenPass
    {
        public EndtimeOreGenPass(string name, float weight) : base(name, weight) {}

        protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
        {
            progress.Message = "Spawning End Time Ores";

            // ElectrumOre
            int maxToSpawn = (int)(Main.maxTilesX * Main.maxTilesY * 6E-05);
            for(int i = 0; i < maxToSpawn; i++)
            {
                int x = WorldGen.genRand.Next(100, Main.maxTilesX - 100);
                int y = WorldGen.genRand.Next((int)WorldGen.worldSurface, Main.maxTilesY - 300);

                WorldGen.TileRunner(x, y, WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 5), ModContent.TileType<ElectrumOre>());
            }
        }
    }
}
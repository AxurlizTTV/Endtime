using Terraria.ModLoader;
using Terraria.WorldBuilding;
using System.Collections.Generic;
using Endtime.Common.Systems.GenPasses;
using System;
using Terraria;
using Terraria.ID;
using Terraria.Utilities;
using Terraria.ModLoader.IO;
using static Terraria.ModLoader.ModContent;
using Terraria.GameContent.Biomes;

namespace Endtime.Common.Systems
{
    internal class WorldSystem : ModSystem
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int shiniesIndex = tasks.FindIndex(t => t.Name.Equals("Shinies"));
            if(shiniesIndex != -1)
            {
                tasks.Insert(shiniesIndex + 1, new EndtimeOreGenPass("EndTime Ore Pass", 320f));
            }
        }
    }
}
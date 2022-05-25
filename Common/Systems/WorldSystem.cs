using Terraria.ModLoader;
using Terraria.WorldBuilding;
using System.Collections.Generic;
using Endtime.Common.Systems.GenPasses;

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
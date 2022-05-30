using Endtime.Content.Items;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Endtime.Common.Players
{
	public class StartInventoryPLayer : ModPlayer
	{
		public override IEnumerable<Item> AddStartingItems(bool mediumCoreDeath)
        {
			return new[]
            {
				new Item(ModContent.ItemType<ElectrumFragment>(), 999),
				new Item(ModContent.ItemType<ZephyriteFragment>(), 999),
				new Item(ModContent.ItemType<HailstoneFragment>(), 999),
				new Item(ModContent.ItemType<InfernalFragment>(), 999)
			};
		}
	}
}
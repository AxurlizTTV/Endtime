using Endtime.Content.Items;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Endtime.Common.Players
{
	public class StartInventoryPLayer : ModPlayer
	{
		// AddStartingItems is a method you can use to add items to the player's starting inventory.
		// It is also called when the player dies a mediumcore death
		// Return an enumerable with the items you want to add to the inventory.
		// This method adds an ExampleItem and 256 gold ore to the player's inventory.
		//
		// If you know what 'yield return' is, you can also use that here, if you prefer so.
		public override IEnumerable<Item> AddStartingItems(bool mediumCoreDeath)
        {
			return new[]
            {
				new Item(ModContent.ItemType<ElementalCatalyst>())
			};
		}
	}
}
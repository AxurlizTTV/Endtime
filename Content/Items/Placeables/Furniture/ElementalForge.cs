using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;

namespace Endtime.Content.Items.Placeables.Furniture
{
    internal class ElementalForge : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 48;
            Item.height = 34;
            Item.maxStack = 999;
            Item.consumable = true;
            Item.value = Item.buyPrice(silver: 50);

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useTurn = true;
            Item.autoReuse = true;

            Item.rare = -12;

            Item.createTile = ModContent.TileType<Tiles.Furniture.ElementalForge>();
        }

        public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.Hellforge)
				.AddIngredient(ModContent.ItemType<ElementalCatalyst>(), 1)
                .AddTile(TileID.Anvils)
				.Register();
		}  
    }
}
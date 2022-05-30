using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace Endtime.Content.Items
{
  internal class ElementalImbuedBook : ModItem
  {
    public override void SetStaticDefaults()
    {
      CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
      Item.width = 28;
      Item.height = 30;
      Item.value = Item.buyPrice(gold: 2);
      Item.maxStack = 999;
      Item.rare = -12;
    }

    public override void AddRecipes()
    {
      CreateRecipe()
        .AddIngredient(ItemID.Book, 1)
        .AddIngredient(ItemID.Obsidian, 5)
        .AddIngredient(ModContent.ItemType<ElementalCatalyst>(), 1)
        .AddTile<Tiles.Furniture.ElementalAnvil>()
        .Register();
    }
  }
}
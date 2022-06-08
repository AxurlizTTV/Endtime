using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace Endtime.Content.Items
{
  internal class ElementalCatalyst : ModItem
  {
    public override void SetStaticDefaults()
    {
      CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
      Item.width = 30;
      Item.height = 24;
      Item.value = Item.buyPrice(gold: 2);
      Item.maxStack = 999;
      Item.rare = -12;
    }

    public override void AddRecipes()
    {
      CreateRecipe()
        .AddIngredient(ModContent.ItemType<InfernalFragment>(), 1)
        .AddIngredient(ModContent.ItemType<HailstoneFragment>(), 1)
        .AddIngredient(ModContent.ItemType<ZephyriteFragment>(), 1)
        .AddIngredient(ModContent.ItemType<ElectrumFragment>(), 1)
        .AddTile(TileID.Anvils)
        .Register();
    }
  }
}
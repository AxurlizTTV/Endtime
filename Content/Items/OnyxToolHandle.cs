using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace Endtime.Content.Items
{
  internal class OnyxToolHandle : ModItem
  {
    public override void SetStaticDefaults()
    {
      CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 5;
    }

    public override void SetDefaults()
    {
      Item.width = 26;
      Item.height = 26;
      Item.value = Item.buyPrice(gold: 2);
      Item.maxStack = 999;
      Item.rare = -1;
    }

    public override void AddRecipes()
        {
        CreateRecipe()
            .AddIngredient(ModContent.ItemType<Onyx>(), 5)
            .AddTile(TileID.Anvils)
            .Register();
        }
  }
}
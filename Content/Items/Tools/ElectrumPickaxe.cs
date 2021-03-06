using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Endtime.Content.Items.Placeables;

namespace Endtime.Content.Items.Tools
{
  internal class ElectrumPickaxe : ModItem
  {
    public override void SetStaticDefaults()
    {
      CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
        Item.width = 48;
        Item.height = 48;

        Item.useTime = 15;
        Item.useAnimation = 20;
        Item.autoReuse = true;
        Item.useStyle = ItemUseStyleID.Swing;
        Item.useTurn = true;

        Item.DamageType = DamageClass.Melee;
        Item.damage = 15;
        Item.knockBack = 2f;

        Item.value = Item.buyPrice(silver: 70);
        Item.rare = ItemRarityID.Yellow;

        Item.pick = 110;
    }

    public override void AddRecipes()
    {
      CreateRecipe()
        .AddIngredient(ModContent.ItemType<OnyxToolHandle>(), 1)
        .AddIngredient(ModContent.ItemType<ElectrumBar>(), 20)
        .AddTile<Tiles.Furniture.ElementalAnvil>()
        .Register();
    }
  }
}
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace Endtime.Content.Items.Tools
{
  internal class DevHamaxe : ModItem
  {
    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Dev Hamaxe");
      Tooltip.SetDefault("How did you get your hand on this?");
      CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
        Item.width = 64;
        Item.height = 64;

        Item.useTime = 1;
        Item.useAnimation = 5;
        Item.autoReuse = true;
        Item.useStyle = ItemUseStyleID.Swing;
        Item.useTurn = true;

        Item.DamageType = DamageClass.Melee;
        Item.damage = 1000;
        Item.knockBack = 3f;

        Item.value = Item.buyPrice(gold: 10);
        Item.rare = ItemRarityID.Red;

        Item.axe = 1000;
        Item.hammer = 1000;
    }

    public override void AddRecipes()
    {
      CreateRecipe()
       .AddRecipeGroup(RecipeGroupID.Wood, 8)
        .AddIngredient(ModContent.ItemType<DevCrystal>(), 25)
        .AddTile(TileID.MythrilAnvil)
        .Register();
    }
  }
}
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace Endtime.Content.Items.Weapons
{
  internal class DevSword : ModItem
  {
    public override void SetStaticDefaults()
    {
      CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
      Item.width = 128;
      Item.height = 128;

      Item.useStyle = ItemUseStyleID.Swing;
      Item.useTime = 5;
      Item.useAnimation = 5;
      Item.autoReuse = true;
      Item.useTurn = true;

      Item.DamageType = DamageClass.Melee;
      Item.damage = 9999;
      Item.knockBack = 3.5f;
      Item.crit = 100;

      Item.value = Item.buyPrice(gold: 10);
      Item.rare = ItemRarityID.Red;

      Item.UseSound = SoundID.Item1;
    }

    public override void AddRecipes()
    {
      CreateRecipe()
        .AddIngredient(ModContent.ItemType<DevCrystal>(), 25)
        .AddTile(TileID.MythrilAnvil)
        .Register();
    }
  }
}
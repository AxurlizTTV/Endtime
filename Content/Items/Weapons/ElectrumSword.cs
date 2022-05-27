using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Endtime.Content.Items.Placeables;

namespace Endtime.Content.Items.Weapons
{
  internal class ElectrumSword : ModItem
  {
    public override void SetStaticDefaults()
    {
      CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
      Item.width = 84;
      Item.height = 84;

      Item.useStyle = ItemUseStyleID.Swing;
      Item.useTime = 25;
      Item.useAnimation = 25;
      Item.autoReuse = true;
      Item.useTurn = true;

      Item.DamageType = DamageClass.Melee;
      Item.damage = 45;
      Item.knockBack = 6.5f;
      Item.crit = 5;

      Item.value = Item.buyPrice(silver: 70);
      Item.rare = ItemRarityID.Yellow;

      Item.UseSound = SoundID.Item1;
    }

    public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
            
      target.AddBuff(BuffID.Confused, 120);
    }

    public override void AddRecipes()
    {
      CreateRecipe()
        .AddIngredient(ModContent.ItemType<ElectrumBar>(), 20)
        .AddTile<Tiles.Furniture.ElementalAnvil>()
        .Register();
    }
  }
}
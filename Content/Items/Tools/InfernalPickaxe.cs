using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Endtime.Content.Items.Placeables;
using Microsoft.Xna.Framework;

namespace Endtime.Content.Items.Tools
{
  internal class InfernalPickaxe : ModItem
  {
    public override void SetStaticDefaults()
    {
      CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
      Item.width = 42;
      Item.height = 42;

      Item.useTime = 15;
      Item.useAnimation = 20;
      Item.autoReuse = true;
      Item.useStyle = ItemUseStyleID.Swing;
      Item.useTurn = true;

      Item.DamageType = DamageClass.Melee;
      Item.damage = 15;
      Item.knockBack = 2f;

      Item.value = Item.buyPrice(silver: 70);
      Item.rare = 4;

      Item.pick = 110;
    }

    public override Color? GetAlpha(Color lightColor)
    {
      return Color.White;
    }

    public override void MeleeEffects(Player player, Rectangle hitbox)
    {
		if (Main.rand.NextBool(3))
      {
        Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 6);
      }
	  }


    public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
            
      target.AddBuff(BuffID.OnFire, 300);
    }

    public override void AddRecipes()
    {
      CreateRecipe()
        .AddIngredient(ModContent.ItemType<OnyxToolHandle>(), 1)
        .AddIngredient(ModContent.ItemType<InfernalBar>(), 20)
        .AddTile<Tiles.Furniture.ElementalAnvil>()
        .Register();
    }
  }
}
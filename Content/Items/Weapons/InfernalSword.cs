using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Endtime.Content.Items.Placeables;
using Microsoft.Xna.Framework;

namespace Endtime.Content.Items.Weapons
{
  internal class InfernalSword : ModItem
  {
    public override void SetStaticDefaults()
    {
      CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
      Item.width = 60;
      Item.height = 68;
      Item.scale = 1.25f;

      Item.useStyle = ItemUseStyleID.Swing;
      Item.useTime = 35;
      Item.useAnimation = 35;
      Item.autoReuse = false;
      Item.useTurn = false;

      Item.DamageType = DamageClass.Melee;
      Item.damage = 55;
      Item.knockBack = 10f;
      Item.crit = 7;

      Item.value = Item.buyPrice(silver: 70);
      Item.rare = 4;

      Item.UseSound = SoundID.Item1;
    }

    public override Color? GetAlpha(Color lightColor)
    {
        return Color.White;
    }

    public override void MeleeEffects(Player player, Rectangle hitbox)
    {
		if (Main.rand.Next(1) == 0)
        {
            Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 6);
        }
	  }


    public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
            
      target.AddBuff(BuffID.OnFire, 60 * 5);
    }

    public override void AddRecipes()
    {
      CreateRecipe()
        .AddIngredient(ModContent.ItemType<InfernalBar>(), 30)
        .AddIngredient(ModContent.ItemType<ElementalImbuedHilt>(), 1)
        .AddTile<Tiles.Furniture.ElementalAnvil>()
        .Register();
    }
  }
}
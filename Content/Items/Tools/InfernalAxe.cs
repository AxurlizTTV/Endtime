using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Endtime.Content.Items.Placeables;
using Microsoft.Xna.Framework;

namespace Endtime.Content.Items.Tools
{
  internal class InfernalAxe : ModItem
  {
    public override void SetStaticDefaults()
    {
      CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
        Item.width = 50;
        Item.height = 50;

        Item.useTime = 14;
        Item.useAnimation = 25;
        Item.autoReuse = true;
        Item.useStyle = ItemUseStyleID.Swing;
        Item.useTurn = false;

        Item.DamageType = DamageClass.Melee;
        Item.damage = 30;
        Item.knockBack = 7f;

        Item.value = Item.buyPrice(silver: 70);
        Item.rare = 4;

        Item.axe = 20;
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
        .AddIngredient(ModContent.ItemType<ObsidianToolHandle>(), 1)
        .AddIngredient(ModContent.ItemType<InfernalBar>(), 15)
        .AddTile<Tiles.Furniture.ElementalAnvil>()
        .Register();
    }
  }
}
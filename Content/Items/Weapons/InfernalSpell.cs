using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Endtime.Content.Items.Placeables;
using Endtime.Content.Projectiles.Weapons;

namespace Endtime.Content.Items.Weapons
{
	public class InfernalSpell : ModItem
	{
		public override void SetStaticDefaults() {

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 30;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.autoReuse = true;
            Item.rare = 4;

            Item.DamageType = DamageClass.Magic;
            Item.noMelee = true;
            Item.mana = 12;
            Item.damage = 40;
            Item.knockBack = 2f;

            Item.useTime = 20;
            Item.useAnimation = 15;

            Item.UseSound = SoundID.Item71;

            Item.shoot = 837;
            Item.shoot = ModContent.ProjectileType<InfernalSpellProjectile>();
            Item.shootSpeed = 5f;
        }

        public override void AddRecipes()
        {
        CreateRecipe()
            .AddIngredient(ModContent.ItemType<InfernalBar>(), 20)
            .AddIngredient(ModContent.ItemType<ElementalImbuedBook>(), 1)
            .AddTile<Tiles.Furniture.ElementalAnvil>()
            .Register();
        }
	}
}
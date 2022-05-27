using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Endtime.Content.Items.Placeables;

namespace Endtime.Content.Items.Weapons
{
	public class ElectrumStaff : ModItem
	{
		public override void SetStaticDefaults() {

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 27;
			Item.DamageType = DamageClass.Magic;
			Item.width = 60;
			Item.height = 60;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 5;
            Item.staff[Item.type] = true;
			Item.noMelee = true;
			Item.knockBack = 4;
			Item.value = Item.buyPrice(silver: 70);
			Item.rare = ItemRarityID.Yellow;
			Item.UseSound = SoundID.Item71;
			Item.autoReuse = true;
			Item.shoot = ProjectileID.PurpleLaser;
			Item.shootSpeed = 10;
			Item.crit = 25;
			Item.mana = 15;
		}

        public override void AddRecipes()
        {
        CreateRecipe()
            .AddIngredient(ModContent.ItemType<ElectrumBar>(), 15)
            .AddTile<Tiles.Furniture.ElementalAnvil>()
            .Register();
        }
	}
}
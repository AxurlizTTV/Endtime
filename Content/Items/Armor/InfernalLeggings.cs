using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Endtime.Content.Items.Placeables;
using Microsoft.Xna.Framework;

namespace Endtime.Content.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class InfernalLeggings : ModItem
	{
		public override void SetStaticDefaults() {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 18;
			Item.height = 12;
			Item.value = Item.sellPrice(silver: 85);
			Item.rare = 4;
			Item.defense = 10;
		}

		public override void UpdateEquip(Player player) {
			player.moveSpeed -= 0.1f;
            player.GetAttackSpeed(DamageClass.Melee) += 0.10f;
		}

		public override void AddRecipes()
        {
        CreateRecipe()
            .AddIngredient(ModContent.ItemType<Onyx>(), 20)
            .AddIngredient(ModContent.ItemType<InfernalBar>(), 15)
            .AddTile<Tiles.Furniture.ElementalAnvil>()
            .Register();
        }
	}
}
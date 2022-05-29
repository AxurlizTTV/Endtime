using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using Endtime.Content.Items.Placeables;
using Microsoft.Xna.Framework;

namespace Endtime.Content.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class InfernalBreastplate : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 18;
			Item.height = 18;
			Item.value = Item.sellPrice(silver: 85);
			Item.rare = 4;
			Item.defense = 11;
		}

		public override void UpdateEquip(Player player) {
            player.GetCritChance(DamageClass.Melee) += 9f;
		}

		public override void AddRecipes()
        {
        CreateRecipe()
            .AddIngredient(ModContent.ItemType<InfernalBar>(), 20)
            .AddTile<Tiles.Furniture.ElementalAnvil>()
            .Register();
        }
	}
}
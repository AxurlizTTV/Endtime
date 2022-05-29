using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Endtime.Content.Items.Placeables;
using Microsoft.Xna.Framework;

namespace Endtime.Content.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class InfernalHelmet : ModItem
	{
		public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 26;
			Item.height = 28;
			Item.value = Item.sellPrice(gold: 1);
			Item.rare = 4;
			Item.defense = 10;
		}

        public override void UpdateEquip(Player player) {
			player.GetDamage(DamageClass.Melee) += 0.09f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
        {
		    return body.type == ModContent.ItemType<InfernalBreastplate>() && legs.type == ModContent.ItemType<InfernalLeggings>();
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = "Increases melee damage by 20%"
                            + "\nGrants immunity to fire and lava";
			player.GetDamage(DamageClass.Melee) += 0.2f;
            player.buffImmune[BuffID.OnFire] = true;
            player.buffImmune[BuffID.Burning] = true;
            player.lavaImmune = true;
		}

		public override void AddRecipes()
        {
        CreateRecipe()
            .AddIngredient(ModContent.ItemType<InfernalBar>(), 12)
            .AddTile<Tiles.Furniture.ElementalAnvil>()
            .Register();
        }
	}
}
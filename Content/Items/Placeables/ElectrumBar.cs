using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace Endtime.Content.Items.Placeables
{
    internal class ElectrumBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 25;
            ItemID.Sets.SortingPriorityMaterials[Type] = 59;
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 999;
            Item.consumable = true;
            Item.value = Item.buyPrice(silver: 30);

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.autoReuse = true;

            Item.rare = ItemRarityID.Yellow;

            Item.createTile = ModContent.TileType<Tiles.ElectrumBars>();
            Item.placeStyle = 0;
        }
        
        public override void AddRecipes()
        {
        CreateRecipe()
            .AddIngredient(ModContent.ItemType<ElectrumOre>(), 3)
            .AddTile(TileID.Furnaces)
            .Register();
        }
    }
}
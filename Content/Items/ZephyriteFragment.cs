using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace Endtime.Content.Items
{
  internal class ZephyriteFragment : ModItem
  {
    public override void SetStaticDefaults()
    {
      CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 25;
    }

    public override void SetDefaults()
    {
      Item.width = 18;
      Item.height = 28;
      Item.value = Item.buyPrice(silver: 50);
      Item.maxStack = 999;
      Item.rare = 0;
    }
  }
}
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace Endtime.Content.Items
{
  internal class Onyx : ModItem
  {
    public override void SetStaticDefaults()
    {
      CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
    }

    public override void SetDefaults()
    {
      Item.width = 26;
      Item.height = 26;
      Item.value = Item.buyPrice(copper: 5);
      Item.maxStack = 999;
      Item.rare = -1;
    }
  }
}
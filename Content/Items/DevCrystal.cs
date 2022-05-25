using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace Endtime.Content.Items
{
  internal class DevCrystal : ModItem
  {
    public override void SetStaticDefaults()
    {
      CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
    }

    public override void SetDefaults()
    {
      Item.width = 32;
      Item.height = 32;
      Item.value = Item.buyPrice(gold: 3, silver: 4, copper: 5);
      Item.maxStack = 999;
    }
  }
}
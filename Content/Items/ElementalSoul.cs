using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace Endtime.Content.Items
{
  internal class ElementalSoul : ModItem
  {
    public override void SetStaticDefaults()
    {
      CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
      Item.width = 38;
      Item.height = 46;
      Item.value = Item.buyPrice(gold: 2);
      Item.maxStack = 999;
      Item.rare = -12;
    }
  }
}
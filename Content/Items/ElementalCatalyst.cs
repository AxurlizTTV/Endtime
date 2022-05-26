using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace Endtime.Content.Items
{
  internal class ElementalCatalyst : ModItem
  {
    public override void SetStaticDefaults()
    {
      CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
      Item.width = 32;
      Item.height = 32;
      Item.value = Item.buyPrice(gold: 2);
      Item.maxStack = 999;
      Item.rare = -12;
    }
  }
}
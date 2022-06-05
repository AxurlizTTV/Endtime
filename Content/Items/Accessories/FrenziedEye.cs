using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria.Audio;
using Microsoft.Xna.Framework;

namespace Endtime.Content.Items.Accessories
{
    public class FrenziedEye : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 34;
            Item.height = 34;
            Item.accessory = true;
            Item.rare = 4;
        }

        private int state = 0;
        private int secondsBetweenChange = 30;
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            Main.LocalPlayer.autoReuseGlove = true;

            if (Main.GameUpdateCount % (60 * secondsBetweenChange) == 0) 
            {
                state++;
                SoundEngine.PlaySound(SoundID.Zombie97 with { Volume = 1f });
            }
            switch (state)
            {
                case 0:
                    player.GetDamage(DamageClass.Melee) += 0.15f;
                    player.GetAttackSpeed(DamageClass.Melee) += 0.35f;
                    player.moveSpeed += 0.5f;
                    if (Main.rand.Next(5) == 0)
                    {
                        Dust.NewDustPerfect(new Vector2(player.position.X + Main.rand.Next(player.width), player.position.Y + player.height - Main.rand.Next(50)), 64, Vector2.Zero);
                    }
                    break;
                case 1:
                    break;
                default:
                    state = 0;
                    break;
            }
        }
    }
}
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.Audio;

namespace Endtime.Content.Tiles
{
    internal class HailstoneOre : ModTile
    {
        public override void SetStaticDefaults()
        {
            TileID.Sets.Ore[Type] = true;

            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileShine[Type] = 900;
            Main.tileShine2[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileOreFinderPriority[Type] = 550;

            AddMapEntry(new Color(0,206,209), CreateMapEntryName());

            DustType = DustID.Ice;
            ItemDrop = ModContent.ItemType<Items.Placeables.HailstoneOre>();
            HitSound = SoundID.Tink;

            MineResist = 1.5f;
            MinPick = 65;
        }
    }
}
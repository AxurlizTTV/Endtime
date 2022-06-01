using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.Audio;

namespace Endtime.Content.Tiles
{
    internal class InfernalOre : ModTile
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

            AddMapEntry(new Color(166, 44, 35), CreateMapEntryName());

            DustType = 6;
            ItemDrop = ModContent.ItemType<Items.Placeables.InfernalOre>();
            HitSound = SoundID.Tink;

            MineResist = 1.5f;
            MinPick = 65;
        }
    }
}
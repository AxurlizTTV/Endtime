using Endtime.Common.Systems;
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.Graphics.Capture;

namespace Endtime.Content.Biomes
{
  public class OnyxSurfaceBiome : ModBiome
  {
    public override ModWaterStyle WaterStyle => ModContent.Find<ModWaterStyle>("Endtime/OnyxWaterStyle");
    public override ModSurfaceBackgroundStyle SurfaceBackgroundStyle => ModContent.Find<ModSurfaceBackgroundStyle>("Endtime/OnyxSurfaceBackgroundStyle");
    public override CaptureBiome.TileColorStyle TileColorStyle => CaptureBiome.TileColorStyle.Crimson;

    public override int Music => MusicLoader.GetMusicSlot(Mod, "Assets/Music/OnyxSurfaceBiome");

    public override string BestiaryIcon => base.BestiaryIcon;
    public override string BackgroundPath => base.BackgroundPath;
    public override Color? BackgroundColor => base.BackgroundColor;

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Onyx Biome");
    }

    public override bool IsBiomeActive(Player player)
    {
      bool b1 = ModContent.GetInstance<OnyxBiomeTileCount>().OnyxBlockCount >= 40;

      bool b2 = Math.Abs(player.position.ToTileCoordinates().X - Main.maxTilesX / 2) < Main.maxTilesX / 6;

      bool b3 = player.ZoneSkyHeight || player.ZoneOverworldHeight;
      return b1 && b2 && b3;
    }
  }
}
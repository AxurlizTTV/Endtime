using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Endtime.Content.Biomes
{
	public class OnyxWaterfallStyle : ModWaterfallStyle
	{
		public override void AddLight(int i, int j) =>
			Lighting.AddLight(new Vector2(i, j).ToWorldCoordinates(), Color.White.ToVector3() * 0.5f);
	}
}
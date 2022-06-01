using Terraria;
using Terraria.ModLoader;

namespace Endtime.Content.Dusts
{
    internal class InfernalSpellDust : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.noGravity = true;
            dust.noLight = true;
        }

        public override bool Update(Dust dust)
        {
            dust.position += dust.velocity;
            dust.rotation += dust.velocity.X * 0.15f;
            dust.scale *= 0.99f;
            if(dust.scale < 0.3f)
            {
                dust.active = false;
            }

            Lighting.AddLight(dust.position, 166, 44, 35);

            return false;
        }
    }
}
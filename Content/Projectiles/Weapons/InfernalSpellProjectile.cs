using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Endtime.Content.Dusts;

namespace Endtime.Content.Projectiles.Weapons
{
  internal class InfernalSpellProjectile : ModProjectile
  {
    public override void SetDefaults()
    {
      Projectile.width = 52;
      Projectile.height = 52;

      Projectile.friendly = true;
      Projectile.tileCollide = false;
      Projectile.ignoreWater = true;
      
      Projectile.DamageType = DamageClass.Magic;

      Projectile.aiStyle = -1;

      Projectile.penetrate = -1;
    }

    public override void PostAI()
    {
      Projectile.ai[0]++;
      if(Projectile.ai[0] < 60f)
      {
        Projectile.velocity *= 1.01f;
      } else {
        Projectile.velocity *= 1.05f;
        if(Projectile.ai[0] >= 180)
        {
          Projectile.Kill();
        }
      }

      float rotateSpeed = 0.35f * (float)Projectile.direction;
      Projectile.rotation += rotateSpeed;

      Lighting.AddLight(Projectile.Center, 166, 44, 35);

      if(Main.rand.NextBool(2))
      {
        int numToSpawn = Main.rand.Next(3);
        for(int i = 0; i < numToSpawn; i++)
        {
          Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, ModContent.DustType<InfernalSpellDust>(), Projectile.velocity.X * 0.1f, Projectile.velocity.Y * 0.1f,
                       0, default(Color), 1f);
        }
      }
    }
  }
}
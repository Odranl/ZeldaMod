using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZeldaMod.Projectiles
{


    //ported from my tAPI mod because I'm lazy
    public class LightArrow : ModProjectile
    {
        bool manaCostSubtracted = false;
        public override void SetDefaults()
        {
            // projectile.CloneDefaults(ProjectileID.FlamingArrow);
            projectile.friendly = true;
            projectile.name = "LightArrow";
            projectile.width = 6;
            projectile.height = 20;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.ranged = true;
            projectile.damage = 100;
            projectile.light = 1f;
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            int dust = Dust.NewDust(projectile.position, 50, 50, 6, 0f, 0f, 0, Color.Yellow, 3f);
            return true;
        }
        public override void PostAI()
        {

            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
            CreateDust();

        }
        public virtual void CreateDust()
        {
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 6,0f,0f,0,Color.Yellow);
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            if(!target.buffImmune[BuffID.OnFire])
                target.AddBuff(BuffID.OnFire, 60);

        }
    }
}
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Miscellanaria.Content.Projectiles.Friendly
{
	public class PhasicWarpDiscProjectile : ModProjectile
	{
		public override void SetStaticDefaults() 
		{
			Main.projFrames[Projectile.type] = 2;
		}

		public override void SetDefaults()
		{
//			Projectile.CloneDefaults(ProjectileID.Stake);

			Projectile.width = 7;
			Projectile.height = 11;

			Projectile.friendly = true;
			Projectile.DamageType = DamageClass.Ranged;
			Projectile.aiStyle = 1;
            AIType = ProjectileID.Stake;
        	
//            Projectile.hostile = true;

            Projectile.scale = 0.9f;
            Projectile.alpha = 0;

 //           Projectile.timeLeft = 900;
	        Projectile.penetrate = 10;
//			Projectiles.extraUpdates = 3;

//           Projectile.light = 1f;
        }
		public override void AI() 
		{
			Projectile.ai[0] += 1f;

			if (++Projectile.frameCounter >= 2) {
				Projectile.frameCounter = 0;
			}
			Projectile.direction = Projectile.spriteDirection = (Projectile.velocity.X > 0f) ? -1 : 1;

			Projectile.rotation = Projectile.velocity.ToRotation();
			// Since our sprite has an orientation, we need to adjust rotation to compensate for the draw flipping
			if (Projectile.spriteDirection == 1) {
				Projectile.rotation += MathHelper.Pi;
				// For vertical sprites use MathHelper.PiOver2
			}
		}
	}
}
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Illegalaria.Content.Projectiles.Friendly.Pets 
{
    public class OrbOfLightProjectile : ModProjectile 
	{
        public override void SetStaticDefaults () 
		{
            Main.projFrames [Projectile.type] = 1;
            Main.projPet [Projectile.type] = true;
			ProjectileID.Sets.TrailingMode[Projectile.type] = 0;
			ProjectileID.Sets.LightPet[Projectile.type] = true;
        }

        public override void SetDefaults () 
		{
            Projectile.CloneDefaults(ProjectileID.ShadowOrb);
            AIType = ProjectileID.ShadowOrb;

            int width = 32; int height = 32;
            Projectile.Size = new Vector2(width, height);
        }

        public override void AI () 
		{
            Player player = Main.player [Projectile.owner];
            if (!player.dead && player.HasBuff(ModContent.BuffType<Buffs.OrbOfLightBuff>()))
                Projectile.timeLeft = 2;
        }
    }
}
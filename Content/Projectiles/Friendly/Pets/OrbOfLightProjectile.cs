//FIXNĄĆ FIXNĄĆ FIXNĄĆ
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Illegalaria.Content.Projectiles.Friendly.Pets
{
	public class OrbOfLightProjectile : ModProjectile
	{
		private const int DashCooldown = 1000; // How frequently this pet will dash at enemies.
		private const float DashSpeed = 20f; // The speed with which this pet will dash at enemies.
		private const int FullBrightTicks = 200;
		private const int FadeOutTicks = 30;
		private const float Range = 500f;

		private static readonly float RangeHypoteneus = (float)(Math.Sqrt(2.0) * Range); // This comes from the formula for calculating the diagonal of a square (a * √2)
		private static readonly float RangeHypoteneusSquared = RangeHypoteneus * RangeHypoteneus;

		// The following 2 lines of code are ref properties (learn about them in google) to the Projectile.ai array entries, which will help us make our code way more readable.
		// We're using the ai array because it's automatically synchronized by the base game in multiplayer, which saves us from writing a lot of boilerplate code.
		// Note that the Projectile.ai array is only 3 entries big. If you need more than 3 synchronized variables - you'll have to use fields and sync them manually.
		public ref float AIDashCharge => ref Projectile.ai[1];

		public override void SetStaticDefaults() {
			Main.projFrames[Projectile.type] = 1;
			Main.projPet[Projectile.type] = true;
			ProjectileID.Sets.TrailingMode[Projectile.type] = 0;
			ProjectileID.Sets.LightPet[Projectile.type] = true;
		}

		public override void SetDefaults() {
			Projectile.width = 32;
			Projectile.height = 32;
			Projectile.penetrate = -1;
			Projectile.netImportant = true;
			Projectile.timeLeft *= 5;
			Projectile.friendly = true;
			Projectile.ignoreWater = true;
			Projectile.scale = 0.8f;
			Projectile.tileCollide = false;
		}

		public override void AI() {
			Player player = Main.player[Projectile.owner];

			// If the player is no longer active (online) - deactivate (remove) the projectile.
			if (!player.active) {
				Projectile.active = false;
				return;
			}

			// Keep the projectile disappearing as long as the player isn't dead and has the pet buff.
			if (!player.dead && player.HasBuff(ModContent.BuffType<Content.Buffs.OrbOfLightBuff>())) {
				Projectile.timeLeft = 2;
			}

			UpdateDash(player);
			UpdateExtraMovement();

			// Rotates the pet when it moves horizontally.
			Projectile.rotation += Projectile.velocity.X / 20f;

			// Lights up area around it.
			if (!Main.dedServ) {
				Lighting.AddLight(Projectile.Center, Projectile.Opacity * 0.9f, Projectile.Opacity * 0.1f, Projectile.Opacity * 0.3f);
			}
		}

		private void UpdateDash(Player player) {
			// The following code makes our pet dash at enemies when certain conditions are met

			AIDashCharge++;

			if (AIDashCharge <= DashCooldown) {
				return;
			}

			// Enumerate
			for (int i = 0; i < Main.maxNPCs; i++) {
				var npc = Main.npc[i];

				// Ignore this npc if it's not active, or if it's friendly.
				if (!npc.active || npc.friendly) {
					continue;
				}

				// Ignore this npc if it's too far away. Note that we're using squared values for our checks, to avoid square root calculations as a small, but effective optimization.
				if (player.DistanceSQ(npc.Center) >= RangeHypoteneusSquared) {
					continue;
				}

				Projectile.velocity += Vector2.Normalize(npc.Center - Projectile.Center) * DashSpeed; // Fling the projectile towards the npc.
				AIDashCharge = 0f; // Reset the charge.

				break;
			}
		}

		private void UpdateExtraMovement() {
			// Adds some friction to the pet's movement as long as its speed is above 1
			if (Projectile.velocity.Length() > 1f) {
				Projectile.velocity *= 0.98f;
			}

			// If the pet stops - launch it into a random direction at a low speed.
			if (Projectile.velocity == Vector2.Zero) {
				Projectile.velocity = Vector2.UnitX.RotatedBy(Main.rand.NextFloat() * MathHelper.TwoPi) * 2f;
			}
		}
	}
}
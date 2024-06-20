using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Miscellanaria.Content.Projectiles.Friendly;

namespace Miscellanaria.Content.Items.Weapons.Ranged
{
	public class PhasicWarpEjector : ModItem
	{
		public override void SetStaticDefaults()
		{
			Item.ResearchUnlockCount = 1;
		}

		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.StakeLauncher);
			Item.width = 58;
			Item.height = 32;

			Item.damage = 50;
			Item.knockBack = 3f;
			Item.DamageType = DamageClass.Ranged;

			Item.useStyle = ItemUseStyleID.Shoot;	
			Item.useTime = 12;
			Item.useAnimation = 12;

			Item.useAmmo = ModContent.ItemType<Items.Ammo.PhasicWarpDisc>();
			Item.shoot = ModContent.ProjectileType<Projectiles.Friendly.PhasicWarpDiscProjectile>();
			Item.shootSpeed = 14f;

			Item.value = Item.sellPrice(gold: 15);
			Item.rare = ItemRarityID.Yellow;
			Item.UseSound = SoundID.Item158;

			Item.autoReuse = true;
			Item.noMelee = true;
		}

		public override Vector2? HoldoutOffset() {
			return new Vector2(-8f, -1f);
		}

		public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback) {
			Vector2 muzzleOffset = Vector2.Normalize(velocity) * 25f;

			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 30, 0)) {
				position += muzzleOffset;
			}
		}

	}
}
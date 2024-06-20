using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Miscellanaria.Content.Items.Ammo
{
	public class PhasicWarpDisc : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Item.ResearchUnlockCount = 99;
		}

		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.Stake);
			Item.width = 14;
			Item.height = 14;

			Item.DamageType = DamageClass.Ranged;

			Item.maxStack = Item.CommonMaxStack;
			Item.consumable = true;
			Item.rare = ItemRarityID.White;
			Item.shoot = ModContent.ProjectileType<Projectiles.Friendly.PhasicWarpDiscProjectile>();

			Item.ammo = Item.type;
        }
	}
}
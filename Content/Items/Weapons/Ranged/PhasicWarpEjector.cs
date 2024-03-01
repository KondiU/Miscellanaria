using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

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
			Item.width = 58;
			Item.height = 32;

			Item.damage = 50;
			Item.knockBack = 3f;
			Item.DamageType = DamageClass.Ranged;

			Item.useStyle = ItemUseStyleID.Shoot;	
			Item.useTime = 10;
			Item.useAnimation = 20;

			Item.useAmmo = AmmoID.Arrow;
			Item.shoot = ProjectileID.WoodenArrowFriendly;
			Item.shootSpeed = 14f;

			Item.value = Item.sellPrice(gold: 15);
			Item.rare = ItemRarityID.Yellow;
			Item.UseSound = SoundID.Item41;

			Item.autoReuse = true;
			Item.noMelee = true;
		}
	}
}
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace Miscellanaria.Content.Items.Weapons.Ranged;

public class DragonsVisage : ModItem
{	
	public override void SetStaticDefaults()
	{
		Item.ResearchUnlockCount = 1;
	}
	public override void SetDefaults () 
	{
			Item.CloneDefaults(ItemID.Tsunami);

			int width = 20; int height = 46;
			Item.Size = new Vector2(width, height);

			Item.damage = 24;
			Item.knockBack = 1.75f;
			Item.DamageType = DamageClass.Ranged;

			Item.useStyle = ItemUseStyleID.Shoot;
			Item.useTime = Item.useAnimation = 20;

			Item.useAmmo = AmmoID.Arrow;
			Item.shoot = ProjectileID.CursedArrow;
			Item.shootSpeed = 12f;

			Item.value = Item.sellPrice(gold: 1, silver: 5);
			Item.rare = ItemRarityID.Orange;
			Item.UseSound = SoundID.Item5;

			Item.autoReuse = true;
			Item.noMelee = true;
		}

		public override Vector2? HoldoutOffset() {
			return new Vector2(-2f, 0f);
		}

}

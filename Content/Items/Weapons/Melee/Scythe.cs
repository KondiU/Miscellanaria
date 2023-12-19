using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Miscellanaria.Content.Items.Weapons.Melee
{
	public class Scythe : ModItem
	{
		public override void SetStaticDefaults()
		{
			Item.ResearchUnlockCount = 1;
		}

		public override void SetDefaults()
		{
			Item.damage = 39;
			Item.DamageType = DamageClass.Melee;
			Item.width = 64;
			Item.height = 56;
			Item.useTime = 25;
			Item.useAnimation = 17;
			Item.useStyle = 1;
			Item.knockBack = 6f;
			Item.value = Item.buyPrice(silver: 1035);
			Item.rare = ItemRarityID.LightRed;
			Item.UseSound = SoundID.Item71;
			Item.autoReuse = false;
		}
	}
}
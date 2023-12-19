using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Miscellanaria.Content.Items.Weapons.Melee
{
	public class SoulScythe : ModItem
	{
		public override void SetStaticDefaults()
		{
			Item.ResearchUnlockCount = 1;
		}

		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.TentacleSpike);
			Item.damage = 55;
			Item.DamageType = DamageClass.Melee;
			Item.width = 92;
			Item.height = 78;
			Item.useTime = 36;
			Item.useAnimation = 17;
			Item.useStyle = 1;
			Item.knockBack = 8.75f;
			Item.value = Item.buyPrice(gold: 5);
			Item.rare = ItemRarityID.Pink;
			Item.UseSound = SoundID.Item71;
			Item.autoReuse = true;
		}
	}
}
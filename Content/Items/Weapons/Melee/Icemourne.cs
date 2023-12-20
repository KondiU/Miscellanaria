using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Miscellanaria.Content.Items.Weapons.Melee
{
	public class Icemourne : ModItem
	{
		public override void SetStaticDefaults()
		{
			Item.ResearchUnlockCount = 1;
		}

		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.IceBlade);
			Item.damage = 44;
			Item.DamageType = DamageClass.Melee;
			Item.width = 74;
			Item.height = 74;
			Item.useTime = 32;
			Item.useAnimation = 17;
			Item.useStyle = 1;
			Item.knockBack = 8f;
			Item.value = Item.buyPrice(gold: 5);
			Item.rare = ItemRarityID.Pink;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}
	}
}
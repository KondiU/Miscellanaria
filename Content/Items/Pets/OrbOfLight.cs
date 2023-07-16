using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Miscellanaria.Content.Items.Pets {
    public class OrbOfLight : PetItem {
		public override void SetStaticDefaults () {
			Item.ResearchUnlockCount = 1;
			ItemID.Sets.ShimmerTransformToItem[Type] = ItemID.ShadowOrb;
			ItemID.Sets.ShimmerTransformToItem[ItemID.ShadowOrb] = Type;
		}

		public override void SetDefaults () {
			Item.CloneDefaults(ItemID.ShadowOrb);
			Item.DefaultToVanitypet(ModContent.ProjectileType<Projectiles.Friendly.Pets.OrbOfLightProjectile>(), ModContent.BuffType<Buffs.OrbOfLightBuff>());
		}
	}
}
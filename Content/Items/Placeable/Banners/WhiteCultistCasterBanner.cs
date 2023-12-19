using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Miscellanaria.Content.Items.Placeable.Banners
{
	public class WhiteCultistCasterBanner : GlobalItem
	{
		public override bool AppliesToEntity(Item entity, bool lateInstantiation)
		{
			return entity.type == 2990;
		}

		public override void SetStaticDefaults()
		{
			ItemID.Sets.Deprecated [2990] = false;

			ItemID.Sets.ShimmerTransformToItem [2990] = 2902;
			ItemID.Sets.ShimmerTransformToItem [2902] = 2990;
		}
	}
}
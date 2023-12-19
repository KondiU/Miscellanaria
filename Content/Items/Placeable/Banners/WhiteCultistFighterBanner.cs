using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Miscellanaria.Content.Items.Placeable.Banners
{
	public class WhiteCultistFighterBanner : GlobalItem
	{
		public override bool AppliesToEntity(Item entity, bool lateInstantiation)
		{
			return entity.type == 2991;
		}

		public override void SetStaticDefaults()
		{
			ItemID.Sets.Deprecated [2991] = false;

			ItemID.Sets.ShimmerTransformToItem [2991] = 2903;
			ItemID.Sets.ShimmerTransformToItem [2903] = 2991;
		}
	}
}

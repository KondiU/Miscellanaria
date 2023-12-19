using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Miscellanaria.Content.Items.Placeable.Banners
{
	public class WhiteCultistArcherBanner : GlobalItem
	{
		public override bool AppliesToEntity(Item entity, bool lateInstantiation)
		{
			return entity.type == 2989;
		}

		public override void SetStaticDefaults()
		{
			ItemID.Sets.Deprecated [2989] = false;

			ItemID.Sets.ShimmerTransformToItem [2989] = 2901;
			ItemID.Sets.ShimmerTransformToItem [2901] = 2989;
		}
	}
}
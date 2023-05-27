using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace Illegalaria.Content.Items.Dyes
{
	public class ColorOnlyDye : GlobalItem
	{
		public override bool AppliesToEntity(Item entity, bool lateInstantiation)
		{
			return entity.type == 3978;
		}

		public override void SetStaticDefaults()
		{
			ItemID.Sets.Deprecated [3978] = false;
		}

//		public override string FunctionalTexture => "Illegalaria/Content/Items/Dyes/ColorOnlyDye";

// how the fuck are you supposed to change vanilla item sprite bruh
	}
}
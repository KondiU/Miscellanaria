using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace Miscellanaria.Content.Items.BossBags
{
	public class LunaticCultistBossBag : GlobalItem
	{
		public override bool AppliesToEntity(Item entity, bool lateInstantiation)
		{
			return entity.type == 3331;
		}

		public override void SetStaticDefaults()
		{
			ItemID.Sets.Deprecated [3331] = false;
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[3331] = 3;
		}
	}
}

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
//Ancient Manipulator - dodać
//silver coin - usunąć

		public override void SetStaticDefaults()
		{
			ItemID.Sets.Deprecated [4722] = false;
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[4722] = 3;
		}
	}
}

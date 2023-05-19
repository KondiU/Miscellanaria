using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace Illegalaria.Content.Items.Weapons.Melee
{
	public class FirstFractal : GlobalItem
	{
		public override bool AppliesToEntity(Item entity, bool lateInstantiation)
		{
			return entity.type == 4722;
		}

		public override void SetDefaults(Item item)
		{
			item.UseSound = SoundID.Item163;
		}

		public override void SetStaticDefaults()
		{
			ItemID.Sets.Deprecated [4722] = false;
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[4722] = 1;
			ItemID.Sets.ShimmerTransformToItem [4722] = ItemID.Zenith;
			ItemID.Sets.ShimmerTransformToItem [ItemID.Zenith] = 4722;
		}
	}
}

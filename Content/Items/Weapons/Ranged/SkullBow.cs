using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace Illegalaria.Content.Items.Weapons.Ranged;

public class SkullBow : GlobalItem
{
	public override bool AppliesToEntity(Item entity, bool lateInstantiation)
	{
		return entity.type == 4058;
	}

	public override void SetStaticDefaults()
	{
		ItemID.Sets.Deprecated[4058] = false;
		CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[4058] = 1;
	}

	public override void ModifyShootStats(Item item, Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
	{
		if (type == 117)
		{
			damage = (int)((float)damage * 1.3f);
			knockback *= 2f;
		}
	}
}

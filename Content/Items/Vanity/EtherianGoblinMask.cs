using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Illegalaria.Content.Items.Vanity
{
	[AutoloadEquip(EquipType.Head)]

	public class EtherianGoblinMask : ModItem
	{
		public override void SetStaticDefaults() 
		{
			ArmorIDs.Head.Sets.DrawHatHair [Item.headSlot] = false;
			Item.ResearchUnlockCount = 1;
		}

		public override void SetDefaults() 
		{
			int width = 26; int height = 20;
			Item.Size = new Vector2(width, height);

			Item.rare = ItemRarityID.Orange;
			Item.value = Item.sellPrice(silver: 50);
			Item.vanity = true;
		}
	}
}
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Miscellanaria.Content.Items.Vanity
{
	[AutoloadEquip(EquipType.Head)]

	public class EtherianGoblinBomberCap : ModItem
	{
		public override void SetStaticDefaults() 
		{
			ArmorIDs.Head.Sets.DrawHatHair[Item.headSlot] = true;
			Item.ResearchUnlockCount = 1;
		}

		public override void SetDefaults() 
		{
			int width = 18; int height = 16;
			Item.Size = new Vector2(width, height);

			Item.rare = ItemRarityID.Orange;
			Item.value = Item.sellPrice(silver: 50);
			Item.vanity = true;
		}
	}
}
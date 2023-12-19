using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Miscellanaria.Content.Items.Vanity
{
	[AutoloadEquip(EquipType.Head)]

	public class MutatedOgreMask : ModItem
	{
		public override void SetStaticDefaults() 
		{
			ArmorIDs.Head.Sets.DrawHatHair [Item.headSlot] = false;
			Item.ResearchUnlockCount = 1;
			ItemID.Sets.ShimmerTransformToItem [Type] = 3865;
			ItemID.Sets.ShimmerTransformToItem [3865] = Type;
		}

		public override void SetDefaults() 
		{
			int width = 30; int height = 26;
			Item.Size = new Vector2(width, height);

			Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(silver: 75);
			Item.vanity = true;
		}
	}
}
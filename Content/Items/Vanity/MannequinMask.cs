using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Miscellanaria.Content.Items.Vanity
{
	[AutoloadEquip(EquipType.Head)]

	public class MannequinMask : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Item.ResearchUnlockCount = 1;
			
			ArmorIDs.Head.Sets.DrawHatHair [Item.headSlot] = false;
		}

		public override void SetDefaults() 
		{
			int width = 38; int height = 34;
			Item.Size = new Vector2(width, height);

			Item.rare = ItemRarityID.White;
			Item.value = Item.sellPrice(silver: 50);
			Item.vanity = true;
		}
		public override void AddRecipes() 
		{
        CreateRecipe()
			.AddIngredient(ItemID.Silk, 20)		
            .AddRecipeGroup("Wood", 5)
            .AddTile(TileID.Loom)
            .Register();
		}
	}
}
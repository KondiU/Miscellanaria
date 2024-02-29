using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Miscellanaria.Content.Items.Vanity 
{
	[AutoloadEquip(EquipType.Body)]

	public class MannequinShirt : ModItem 
	{
		public override void SetStaticDefaults ()
		{
			Item.ResearchUnlockCount = 1;
		}
		public override void SetDefaults () 
		{
			int width = 30; int height = 18;
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
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Miscellanaria.Content.Items.Placeable.Banners
{
	public class BlueCultistFighterBannerRecipe : ModSystem
	{
		public override void AddRecipes() 
		{
			Recipe recipe = Recipe.Create(2903);
			recipe.AddIngredient(2901);
			recipe.AddIngredient(2902);
			recipe.AddTile(TileID.Loom);
			recipe.AddCondition(Condition.InGraveyard);
			recipe.Register();
		}
	}
}
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Miscellanaria.Content.Items.Placeable.Banners
{
	public class WhiteCultistFighterBannerRecipe : ModSystem
	{
		public override void AddRecipes() 
		{
			Recipe recipe = Recipe.Create(2991);
			recipe.AddIngredient(2989);
			recipe.AddIngredient(2990);
			recipe.AddTile(TileID.Loom);
			recipe.AddCondition(Condition.InGraveyard);
			recipe.Register();
		}
	}
}
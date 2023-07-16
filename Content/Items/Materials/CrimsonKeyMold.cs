using Miscellanaria.Content.Items.Materials;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Miscellanaria.Content.Items.Materials
{
    public class CrimsonKeyMold : ModItem
    {
		public override void SetStaticDefaults()
		{
			Item.ResearchUnlockCount = 1;
		}

		public override void SetDefaults()
		{
        	int width = 42; int height = 42;
        	Item.Size = new Vector2(width, height);

        	Item.rare = ItemRarityID.Yellow;
        	Item.maxStack = 9999;
        }

		public override void AddRecipes()
		{
			Recipe.Create(ItemID.CrimsonKey)
				.AddIngredient(ItemID.TempleKey)
				.AddIngredient<CrimsonKeyMold>()
				.AddIngredient(ItemID.SoulofFright, 5)
				.AddIngredient(ItemID.SoulofMight, 5)
				.AddIngredient(ItemID.SoulofSight, 5)
				.Register();
		}
    }
}
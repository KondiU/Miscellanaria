using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Miscellanaria.Content.Items.Tools;

public class StardustChainsaw : GlobalItem
{
	public override bool AppliesToEntity(Item entity, bool lateInstantiation)
	{
		return entity.type == 3463;
	}

	public override void SetStaticDefaults()
	{
		ItemID.Sets.Deprecated [3463] = false;
	}

	public override void AddRecipes()
	{
		Recipe.Create(ItemID.StardustChainsaw)
				.AddIngredient(ItemID.FragmentStardust, 14)
				.AddIngredient(ItemID.LunarBar, 12)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
	}
}

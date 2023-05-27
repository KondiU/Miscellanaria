using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Illegalaria.Content.Items.Tools;

public class SolarFlareChainsaw : GlobalItem
{
	public override bool AppliesToEntity(Item entity, bool lateInstantiation)
	{
		return entity.type == 2783;
	}

	public override void SetStaticDefaults()
	{
		ItemID.Sets.Deprecated [2783] = false;
	}

	public override void AddRecipes()
	{
		Recipe.Create(ItemID.SolarFlareChainsaw)
				.AddIngredient(ItemID.FragmentSolar, 14)
				.AddIngredient(ItemID.LunarBar, 12)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
	}
}

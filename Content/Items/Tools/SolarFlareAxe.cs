using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Miscellanaria.Content.Items.Tools;

public class SolarFlareAxe : GlobalItem
{
	public override bool AppliesToEntity(Item entity, bool lateInstantiation)
	{
		return entity.type == 2782;
	}

	public override void SetStaticDefaults()
	{
		ItemID.Sets.Deprecated [2782] = false;
	}

	public override void AddRecipes()
	{
		Recipe.Create(ItemID.SolarFlareAxe)
				.AddIngredient(ItemID.FragmentSolar, 14)
				.AddIngredient(ItemID.LunarBar, 12)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
	}
}

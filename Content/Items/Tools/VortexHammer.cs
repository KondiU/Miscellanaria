using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Miscellanaria.Content.Items.Tools;

public class VortexHammer : GlobalItem
{
	public override bool AppliesToEntity(Item entity, bool lateInstantiation)
	{
		return entity.type == 2775;
	}

	public override void SetStaticDefaults()
	{
		ItemID.Sets.Deprecated [2775] = false;
	}

	public override void AddRecipes()
	{
		Recipe.Create(ItemID.VortexHammer)
				.AddIngredient(ItemID.FragmentVortex, 14)
				.AddIngredient(ItemID.LunarBar, 12)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
	}
}

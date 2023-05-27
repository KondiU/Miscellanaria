using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Illegalaria.Content.Items.Tools;

public class VortexAxe : GlobalItem
{
	public override bool AppliesToEntity(Item entity, bool lateInstantiation)
	{
		return entity.type == 2772;
	}

	public override void SetStaticDefaults()
	{
		ItemID.Sets.Deprecated [2772] = false;
	}

	public override void AddRecipes()
	{
		Recipe.Create(ItemID.VortexAxe)
				.AddIngredient(ItemID.FragmentVortex, 14)
				.AddIngredient(ItemID.LunarBar, 12)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
	}
}

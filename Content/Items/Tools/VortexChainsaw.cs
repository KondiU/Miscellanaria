using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Miscellanaria.Content.Items.Tools;

public class VortexChainsaw : GlobalItem
{
	public override bool AppliesToEntity(Item entity, bool lateInstantiation)
	{
		return entity.type == 2773;
	}

	public override void SetStaticDefaults()
	{
		ItemID.Sets.Deprecated [2773] = false;
	}

	public override void AddRecipes()
	{
		Recipe.Create(ItemID.VortexChainsaw)
				.AddIngredient(ItemID.FragmentVortex, 14)
				.AddIngredient(ItemID.LunarBar, 12)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
	}
}

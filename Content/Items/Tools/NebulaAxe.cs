using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Illegalaria.Content.Items.Tools;

public class NebulaAxe : GlobalItem
{
	public override bool AppliesToEntity(Item entity, bool lateInstantiation)
	{
		return entity.type == 2777;
	}

	public override void SetStaticDefaults()
	{
		ItemID.Sets.Deprecated [2777] = false;
	}

	public override void AddRecipes()
	{
		Recipe.Create(ItemID.NebulaAxe)
				.AddIngredient(ItemID.FragmentNebula, 14)
				.AddIngredient(ItemID.LunarBar, 12)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
	}
}

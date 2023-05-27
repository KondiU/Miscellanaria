using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Illegalaria.Content.Items.Tools;

public class NebulaHammer : GlobalItem
{
	public override bool AppliesToEntity(Item entity, bool lateInstantiation)
	{
		return entity.type == 2780;
	}

	public override void SetStaticDefaults()
	{
		ItemID.Sets.Deprecated [2780] = false;
	}

	public override void AddRecipes()
	{
		Recipe.Create(ItemID.NebulaHammer)
				.AddIngredient(ItemID.FragmentNebula, 14)
				.AddIngredient(ItemID.LunarBar, 12)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
	}
}

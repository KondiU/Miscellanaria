using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Illegalaria.Content.Items.Tools;

public class StardustAxe : GlobalItem
{
	public override bool AppliesToEntity(Item entity, bool lateInstantiation)
	{
		return entity.type == 3462;
	}

	public override void SetStaticDefaults()
	{
		ItemID.Sets.Deprecated [3462] = false;
	}

	public override void AddRecipes()
	{
		Recipe.Create(ItemID.StardustAxe)
				.AddIngredient(ItemID.FragmentStardust, 14)
				.AddIngredient(ItemID.LunarBar, 12)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
	}
}

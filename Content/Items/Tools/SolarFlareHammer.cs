using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Illegalaria.Content.Items.Tools;

public class SolarFlareHammer : GlobalItem
{
	public override bool AppliesToEntity(Item entity, bool lateInstantiation)
	{
		return entity.type == 2785;
	}

	public override void SetStaticDefaults()
	{
		ItemID.Sets.Deprecated [2785] = false;
	}

	public override void AddRecipes()
	{
		Recipe.Create(ItemID.SolarFlareHammer)
				.AddIngredient(ItemID.FragmentSolar, 14)
				.AddIngredient(ItemID.LunarBar, 12)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
	}
}

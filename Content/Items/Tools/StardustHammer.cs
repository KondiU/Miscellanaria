using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Miscellanaria.Content.Items.Tools;

public class StardustHammer : GlobalItem
{
	public override bool AppliesToEntity(Item entity, bool lateInstantiation)
	{
		return entity.type == 3465;
	}

	public override void SetStaticDefaults()
	{
		ItemID.Sets.Deprecated [3465] = false;
	}

	public override void AddRecipes()
	{
		Recipe.Create(ItemID.StardustHammer)
				.AddIngredient(ItemID.FragmentStardust, 14)
				.AddIngredient(ItemID.LunarBar, 12)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
	}
}

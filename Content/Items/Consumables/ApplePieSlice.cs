using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace Miscellanaria.Content.Items.Consumables;

public class ApplePieSlice : GlobalItem
{
	public override bool AppliesToEntity(Item entity, bool lateInstantiation)
	{
		return entity.type == 4010;
	}

	public override void SetStaticDefaults()
	{
		ItemID.Sets.Deprecated[4010] = false;
		CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[4010] = 5;
		int width = 32; int height = 20;

		ItemID.Sets.IsFood[4010] = true;
		ItemID.Sets.FoodParticleColors[4010] = new Color[3] {
				new Color(134, 45, 45),
				new Color(239, 182, 113),
				new Color(224, 143, 91)
			};
	}
	
	public override void SetDefaults(Item item) 
	{
			item.DefaultToFood(22, 22, BuffID.WellFed, 28800);
			item.value = Item.sellPrice(silver: 30);
			item.rare = ItemRarityID.Orange;
	}

	public override void AddRecipes()
	{
		Recipe.Create(4010, 2)
				.AddIngredient(ItemID.ApplePie)
				.Register();
	}
}

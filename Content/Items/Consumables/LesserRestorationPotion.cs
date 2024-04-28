using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Miscellanaria.Content.Items.Consumables
{
	public class LesserRestorationPotion : ModItem
	{
		public override void SetStaticDefaults()
		{
			ItemID.Sets.DrinkParticleColors[Type] = new Color[3] 
			{
				new Color(240, 240, 240),
				new Color(200, 200, 200),
				new Color(140, 140, 140)
			};
			Item.ResearchUnlockCount = 30;
		}

		public override void SetDefaults()
		{
//			Item.CloneDefaults(ItemID.RestorationPotion);
			int width = 14; int height = 24;
            Item.Size = new Vector2(width, height);

			Item.maxStack = 9999;

			Item.healLife = 40;
			Item.potion = false;

			Item.useStyle = ItemUseStyleID.DrinkLiquid;
			Item.useAnimation = 17;
			Item.useTime = 17;
			Item.useTurn = true;
			Item.UseSound = SoundID.Item3;
			Item.consumable = true;

			Item.rare = ItemRarityID.White;
			Item.value = Item.buyPrice(silver: 5);
		}
		public override void OnConsumeItem(Player player) 
		{
			player.AddBuff(BuffID.PotionSickness, 2700);
		}

		public override void AddRecipes() 
		{
		CreateRecipe()
            .AddIngredient(ItemID.Mushroom)
			.AddIngredient(ItemID.PinkGel)
			.AddIngredient(ItemID.Bottle)
            .AddTile(TileID.Bottles)
            .Register();
        }

//		public static int SicknessDuration = 2700;
    }
}
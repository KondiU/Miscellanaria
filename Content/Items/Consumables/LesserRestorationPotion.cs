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
			int width = 14; int height = 24;
            Item.Size = new Vector2(width, height);
			Item.maxStack = 9999;
			Item.healLife = 40;
			Item.potion = true;
			Item.useStyle = ItemUseStyleID.DrinkLiquid;
			Item.useAnimation = 17;
			Item.useTime = 17;
			Item.useTurn = true;
			Item.UseSound = SoundID.Item3;
			Item.consumable = true;
			Item.rare = ItemRarityID.White;
			Item.value = Item.sellPrice(copper: 90);
		}
		public override void Load() 
		{
    		On_Player.ApplyPotionDelay += On_Player_ApplyPotionDelay;
		}

		private void On_Player_ApplyPotionDelay(On_Player.orig_ApplyPotionDelay orig, Player self, Item sItem) 
		{
    		if(sItem.type == Type) 
			{
        		int delay = 45 * 60;
        		if (self.pStone)
        		    delay = (int)((float)delay * Player.PhilosopherStoneDurationMultiplier);
        		self.AddBuff(21, delay );
    		}

    		else 
			{
        	orig(self, sItem);
			}
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
    }
}
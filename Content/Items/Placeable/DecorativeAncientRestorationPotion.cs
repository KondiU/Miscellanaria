using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Miscellanaria.Content.Items.Consumables;
using Miscellanaria.Content.Tiles;

namespace Miscellanaria.Content.Items.Placeable;

public class DecorativeAncientRestorationPotion : ModItem
{

    public override void SetDefaults() 
    {
        Item.DefaultToPlaceableTile(ModContent.TileType<DecorativeAncientRestorationPotionTile>());
        Item.rare = ItemRarityID.White;
		Item.value = Item.sellPrice(silver: 2);

        Item.maxStack = Item.CommonMaxStack;
        Item.width = 20;
        Item.height = 20;
    }

    public override void AddRecipes()
    {
        if (Main.rand.NextBool()) 
        {
            if (ModLoader.TryGetMod("DecorativePotions", out Mod DecorativePotions))
            {
                CreateRecipe()
                    .AddIngredient(ModContent.ItemType<AncientRestorationPotion>())
                    .AddTile(TileID.HeavyWorkBench)
                    .Register();
            }
        }
    }
}
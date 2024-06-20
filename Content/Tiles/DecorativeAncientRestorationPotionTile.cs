using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Miscellanaria.Content.Items.Consumables;

namespace Miscellanaria.Content.Tiles;

public class DecorativeAncientRestorationPotionTile : ModTile
{
    public override void SetStaticDefaults() 
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;

        AdjTiles = new int[] { TileID.Bottles };

        TileObjectData.newTile.CopyFrom(TileObjectData.StyleOnTable1x1);
        TileObjectData.addTile(Type);

        AddMapEntry(Color.White, Lang.GetItemName(ItemID.Bottle));
    }

    public override IEnumerable<Item> GetItemDrops(int i, int j) 
    {
        yield return new Item(ModContent.ItemType<Content.Items.Consumables.AncientRestorationPotion>());
    }

    public override void MouseOver(int i, int j) 
    {
        Player player = Main.LocalPlayer;
        player.noThrow = 2;
        player.cursorItemIconEnabled = true;
        player.cursorItemIconID = ModContent.ItemType<Content.Items.Consumables.AncientRestorationPotion>();
    }

    public override bool RightClick(int i, int j) 
    {
        WorldGen.KillTile(i, j);
        if (Main.netMode != NetmodeID.SinglePlayer) 
        {
            NetMessage.SendTileSquare(Main.myPlayer, i, j);
        }
        return true;
    }
}

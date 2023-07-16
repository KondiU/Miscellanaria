using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Miscellanaria.Common.GlobalNPCs
{
	public class MiscellanariaShops : GlobalNPC
	{
		public override void ModifyShop(NPCShop shop) 
		{
            if (shop.NpcType == NPCID.DyeTrader) 
            {
					shop.Add(ItemID.ColorOnlyDye, Condition.DownedMartians);
            }
        }
    }
}
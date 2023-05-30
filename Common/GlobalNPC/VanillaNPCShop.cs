using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Illegalaria.Common.GlobalNPCs
{
	public class IllegalariaShops : GlobalNPC
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
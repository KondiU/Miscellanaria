using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Miscellanaria.Content.Items.Weapons.Melee;

namespace Miscellanaria.Common.GlobalItems
{
	public class BossBagLoot : GlobalItem
	{
		public override void ModifyItemLoot(Item item, ItemLoot itemLoot) 
        {
            if(item.type == 3331) 
                itemLoot.Add(ItemDropRule.Common(3549, 1));
				
			if(item.type == 3331) 
				itemLoot.Add(ItemDropRule.Common(ItemID.GreaterHealingPotion, 1, 5, 15));

			if(item.type == 3323) 
                itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<Scythe>(), 7));
		}
	}
}
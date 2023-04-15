using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Illegalaria.Content.Items.Materials;
using Illegalaria.Common.ItemDropRules.DropConditions;
using System.Linq;

namespace Illegalaria.Common.GlobalNPCs
{
	public class IllegalariaDrops : GlobalNPC
	{
		public override void ModifyGlobalLoot(GlobalLoot globalLoot) 
		{
			globalLoot.Add(ItemDropRule.ByCondition(new CorruptionKeyMoldCondition(), ModContent.ItemType<CorruptionKeyMold>(), 2000));
			globalLoot.Add(ItemDropRule.ByCondition(new CrimsonKeyMoldCondition(), ModContent.ItemType<CrimsonKeyMold>(), 2000));
			globalLoot.Add(ItemDropRule.ByCondition(new FrozenKeyMoldCondition(), ModContent.ItemType<FrozenKeyMold>(), 2000));
			globalLoot.Add(ItemDropRule.ByCondition(new HallowedKeyMoldCondition(), ModContent.ItemType<HallowedKeyMold>(), 2000));
			globalLoot.Add(ItemDropRule.ByCondition(new JungleKeyMoldCondition(), ModContent.ItemType<JungleKeyMold>(), 2000));
		}
	}
}
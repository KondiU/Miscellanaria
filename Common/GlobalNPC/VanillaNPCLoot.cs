using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Illegalaria.Content.Items.Materials;
using Illegalaria.Content.Items.Vanity;
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

		public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot) 
		{
			if (npc.type == NPCID.BigPantlessSkeleton || npc.type == NPCID.SmallPantlessSkeleton || npc.type == NPCID.BigMisassembledSkeleton || npc.type == NPCID.SmallMisassembledSkeleton || npc.type == NPCID.BigHeadacheSkeleton || npc.type == NPCID.SmallHeadacheSkeleton || npc.type == NPCID.BigSkeleton || npc.type == NPCID.SmallSkeleton || npc.type == NPCID.Skeleton || npc.type == NPCID.HeadacheSkeleton || npc.type == NPCID.MisassembledSkeleton || npc.type == NPCID.PantlessSkeleton || npc.type == NPCID.SkeletonTopHat || npc.type == NPCID.SkeletonAstonaut || npc.type == NPCID.SkeletonAlien || npc.type == NPCID.BoneThrowingSkeleton || npc.type == NPCID.BoneThrowingSkeleton2 || npc.type == NPCID.BoneThrowingSkeleton3 || npc.type == NPCID.BoneThrowingSkeleton4)
			{
				npcLoot.Add(ItemDropRule.Common(ItemID.SkeletonBow, 200));
			}

			if (npc.type == NPCID.CultistBoss && Main.expertMode)
			{
				npcLoot.Add(ItemDropRule.Common(ItemID.CultistBossBag, 1));
			}

			if (npc.type == NPCID.DD2GoblinT1 || npc.type == NPCID.DD2GoblinT2 || npc.type == NPCID.DD2GoblinT3)
			{
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<EtherianGoblinMask>(), 200));
			}
		}
	}
}
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Miscellanaria.Content.Items.Materials;
using Miscellanaria.Content.Items.Placeable;
using Miscellanaria.Content.Items.Weapons.Melee;
using Miscellanaria.Content.Items.Vanity;
using Miscellanaria.Common.ItemDropRules.DropConditions;
using System.Linq;

namespace Miscellanaria.Common.GlobalNPCs
{
	public class MiscellanariaDrops : GlobalNPC
	{
		public override void ModifyGlobalLoot(GlobalLoot globalLoot) 
		{
			globalLoot.Add(ItemDropRule.ByCondition(new CorruptionKeyMoldCondition(), ModContent.ItemType<CorruptionKeyMold>(), 2000));
			globalLoot.Add(ItemDropRule.ByCondition(new CrimsonKeyMoldCondition(), ModContent.ItemType<CrimsonKeyMold>(), 2000));
			globalLoot.Add(ItemDropRule.ByCondition(new FrozenKeyMoldCondition(), ModContent.ItemType<FrozenKeyMold>(), 2000));
			globalLoot.Add(ItemDropRule.ByCondition(new HallowedKeyMoldCondition(), ModContent.ItemType<HallowedKeyMold>(), 2000));
			globalLoot.Add(ItemDropRule.ByCondition(new JungleKeyMoldCondition(), ModContent.ItemType<JungleKeyMold>(), 2000));
			globalLoot.Add(ItemDropRule.ByCondition(new DesertKeyMoldCondition(), ModContent.ItemType<DesertKeyMold>(), 2000));
		}

		public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot) 
		{
			if (npc.type == NPCID.BigPantlessSkeleton || npc.type == NPCID.SmallPantlessSkeleton || npc.type == NPCID.BigMisassembledSkeleton || npc.type == NPCID.SmallMisassembledSkeleton || npc.type == NPCID.BigHeadacheSkeleton || npc.type == NPCID.SmallHeadacheSkeleton || npc.type == NPCID.BigSkeleton || npc.type == NPCID.SmallSkeleton || npc.type == NPCID.Skeleton || npc.type == NPCID.HeadacheSkeleton || npc.type == NPCID.MisassembledSkeleton || npc.type == NPCID.PantlessSkeleton || npc.type == NPCID.SkeletonTopHat || npc.type == NPCID.SkeletonAstonaut || npc.type == NPCID.SkeletonAlien || npc.type == NPCID.BoneThrowingSkeleton || npc.type == NPCID.BoneThrowingSkeleton2 || npc.type == NPCID.BoneThrowingSkeleton3 || npc.type == NPCID.BoneThrowingSkeleton4  || npc.type == NPCID.SporeSkeleton)
			{
				npcLoot.Add(ItemDropRule.Common(ItemID.SkeletonBow, 200));
			}

			if (npc.type == NPCID.ArmoredViking || npc.type == NPCID.IceElemental || npc.type == NPCID.IceTortoise || npc.type == NPCID.IcyMerman)
			{
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Icemourne>(), 100));
			}

			if (npc.type == NPCID.CultistBoss)
			{
				npcLoot.RemoveWhere(
					rule => rule is CommonDrop commonDrop 
						&& commonDrop.itemId == ItemID.LunarCraftingStation
				);

				npcLoot.RemoveWhere(
					rule => rule is CommonDrop commonDrop 
						&& commonDrop.itemId == 3372
				);

				npcLoot.RemoveWhere(
					rule => rule is CommonDrop commonDrop
						&& commonDrop.itemId == ItemID.GreaterHealingPotion
				);

				npcLoot.RemoveWhere(
					rule => rule is CommonDrop commonDrop 
						&& commonDrop.itemId == ItemID.SilverCoin
				);

				npcLoot.Add(ItemDropRule.BossBag(ItemID.CultistBossBag));
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotExpert(), ItemID.LunarCraftingStation));
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotExpert(), 3372 , chanceDenominator: 7, chanceNumerator: 1, minimumDropped: 1, maximumDropped: 1));
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotExpert(), ItemID.GreaterHealingPotion, chanceDenominator: 1, chanceNumerator: 1, minimumDropped: 5, maximumDropped: 15));

			}

			if (npc.type == NPCID.BloodNautilus)
			{
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<DreadnautilusTrophy>(), 10));
			}

			if (npc.type == NPCID.SkeletronHead)
			{
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotExpert(), ModContent.ItemType<Scythe>(), 7));
			}

			if (npc.type == NPCID.DD2GoblinT1 || npc.type == NPCID.DD2GoblinT2 || npc.type == NPCID.DD2GoblinT3)
			{
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<EtherianGoblinMask>(), 200));
			}

			if (npc.type == NPCID.DD2GoblinBomberT1 || npc.type == NPCID.DD2GoblinBomberT2 || npc.type == NPCID.DD2GoblinBomberT3)
			{
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<EtherianGoblinBomberCap>(), 200));
			}

			if (npc.type == NPCID.DD2KoboldWalkerT2 || npc.type == NPCID.DD2KoboldWalkerT3 || npc.type == NPCID.DD2KoboldFlyerT2 || npc.type == NPCID.DD2KoboldFlyerT3)
			{
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<KoboldDynamiteBackpack>(), 200));
			}

		}
	}
}
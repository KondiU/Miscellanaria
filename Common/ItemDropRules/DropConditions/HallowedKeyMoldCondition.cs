using Terraria;
using Terraria.ID;
using Terraria.GameContent.ItemDropRules;
using Terraria.Localization;

namespace Miscellanaria.Common.ItemDropRules.DropConditions
{
	public class HallowedKeyMoldCondition : IItemDropRuleCondition
	{
		private static LocalizedText Description;

		public HallowedKeyMoldCondition() 
		{
			Description ??= Language.GetOrRegister("Mods.Miscellanaria.DropConditions.HallowedKeyMold");
		}

		public bool CanDrop(DropAttemptInfo info) 
		{
			NPC npc = info.npc;
			return Main.hardMode
				&& !npc.friendly
				&& npc.lifeMax > 1
				&& npc.value > 0f
				&& info.player.ZoneHallow;
		}

		public bool CanShowItemDropInUI() 
		{
			return true;
		}

		public string GetConditionDescription() 
		{
			return Description.Value;
		}
	}
}
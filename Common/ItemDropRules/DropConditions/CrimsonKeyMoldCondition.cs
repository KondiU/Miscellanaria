using Terraria;
using Terraria.ID;
using Terraria.GameContent.ItemDropRules;
using Terraria.Localization;

namespace Illegalaria.Common.ItemDropRules.DropConditions
{
	public class CrimsonKeyMoldCondition : IItemDropRuleCondition
	{
		private static LocalizedText Description;

		public CrimsonKeyMoldCondition() 
		{
			Description ??= Language.GetOrRegister("Mods.Illegalaria.DropConditions.CrimsonKeyMold");
		}

		public bool CanDrop(DropAttemptInfo info) 
		{
			NPC npc = info.npc;
			return Main.hardMode
				&& !npc.friendly
				&& npc.lifeMax > 1
				&& npc.value > 0f
				&& info.player.ZoneCrimson;
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
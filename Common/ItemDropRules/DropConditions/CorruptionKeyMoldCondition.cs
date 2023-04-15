using Terraria;
using Terraria.ID;
using Terraria.GameContent.ItemDropRules;
using Terraria.Localization;

namespace Illegalaria.Common.ItemDropRules.DropConditions
{
	public class CorruptionKeyMoldCondition : IItemDropRuleCondition
	{
		private static LocalizedText Description;

		public CorruptionKeyMoldCondition() 
		{
			Description ??= Language.GetOrRegister("Mods.Illegalaria.DropConditions.CorruptionKeyMold");
		}

		public bool CanDrop(DropAttemptInfo info) 
		{
			NPC npc = info.npc;
			return Main.hardMode
				&& !npc.friendly
				&& npc.lifeMax > 1
				&& npc.value > 0f
				&& info.player.ZoneCorrupt;
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
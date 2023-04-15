using Terraria;
using Terraria.ID;
using Terraria.GameContent.ItemDropRules;
using Terraria.Localization;

namespace Illegalaria.Common.ItemDropRules.DropConditions
{
	public class FrozenKeyMoldCondition : IItemDropRuleCondition
	{
		private static LocalizedText Description;

		public FrozenKeyMoldCondition() 
		{
			Description ??= Language.GetOrRegister("Mods.Illegalaria.DropConditions.FrozenKeyMold");
		}

		public bool CanDrop(DropAttemptInfo info) 
		{
			NPC npc = info.npc;
			return Main.hardMode
				&& !npc.friendly
				&& npc.lifeMax > 1
				&& npc.value > 0f
				&& info.player.ZoneSnow;
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
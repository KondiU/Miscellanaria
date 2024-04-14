using Microsoft.Xna.Framework;
using Terraria.GameContent.UI;
using Terraria.ModLoader;

namespace Miscellanaria.Content.EmoteBubbles
{
	public class ScragglerEmote : ModEmoteBubble
	{
		public override void SetStaticDefaults() {
			AddToCategory(EmoteID.Category.Town);
		}
	}
}
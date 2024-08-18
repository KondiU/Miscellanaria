using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.ID;
using Terraria.ModLoader;

namespace Miscellanaria.Common {
    internal class UnderworldMenu : ModMenu {
        public override string DisplayName => "Journey's End (Underworld)";

        public override Asset<Texture2D> Logo => ModContent.Request<Texture2D>("Miscellanaria/Assets/Textures/UnderworldLogo");

        public override bool PreDrawLogo (SpriteBatch spriteBatch, ref Vector2 logoDrawCenter, ref float logoRotation, ref float logoScale, ref Color drawColor) {
            logoDrawCenter += new Vector2(0, 14);
            logoScale *= 1f;
            return true;
        }
    }
}

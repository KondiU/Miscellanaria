using Terraria;
using Terraria.ModLoader;

namespace Illegalaria.Content.Items.Pets {
    public abstract class PetItem : ModItem {
        public override bool CanRightClick () => false;

        public override bool? UseItem (Player player) {
            if (player.whoAmI == Main.myPlayer && player.itemAnimation >= player.itemAnimationMax) {
                player.AddBuff(Item.buffType, 3600);
            }
            return true;
        }
    }
}
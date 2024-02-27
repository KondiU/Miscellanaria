using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Miscellanaria.Content.Items.Pets 
{
    public class BrainCandy : PetItem 
	{
		public override void SetStaticDefaults () 
		{
			Item.ResearchUnlockCount = 1;
		}

		public override void SetDefaults () 
		{
			Item.DefaultToVanitypet(ModContent.ProjectileType<Content.Projectiles.Friendly.Pets.BabyZombieProjectile>(), ModContent.BuffType<Content.Buffs.BabyZombieBuff>());

			int width = 26; int height = 26;
			Item.Size = new Vector2(width, height);

			Item.rare = ItemRarityID.Pink;
			Item.value = Item.buyPrice(gold: 25);
		}
	}
}
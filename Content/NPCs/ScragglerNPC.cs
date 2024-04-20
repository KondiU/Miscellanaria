using Miscellanaria.Content.EmoteBubbles;
using Miscellanaria.Content.Items;
using Miscellanaria.Content.Items.Weapons;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.GameContent;
using Terraria.GameContent.Bestiary;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace Miscellanaria.Content.NPCs
{
	public class ScragglerNPC : ModNPC
	{
		private static Profiles.StackedNPCProfile NPCProfile;

		public override void SetStaticDefaults() {
			Main.npcFrameCount[Type] = 21;

			NPCID.Sets.ExtraFramesCount[Type] = 9; // Generally for Town NPCs, but this is how the NPC does extra things such as sitting in a chair and talking to other NPCs.
			NPCID.Sets.AttackFrameCount[Type] = 4;
			NPCID.Sets.DangerDetectRange[Type] = 150; // The amount of pixels away from the center of the npc that it tries to attack enemies.
			NPCID.Sets.PrettySafe[Type] = 300;
			NPCID.Sets.AttackType[Type] = 3; // Shoots a weapon.
			NPCID.Sets.AttackTime[Type] = 15; // The amount of time it takes for the NPC's attack animation to be over once it starts.
			NPCID.Sets.AttackAverageChance[Type] = 30;
			NPCID.Sets.HatOffsetY[Type] = 4; // For when a party is active, the party hat spawns at a Y offset.
			NPCID.Sets.ShimmerTownTransform[NPC.type] = true; // This set says that the Town NPC has a Shimmered form. Otherwise, the Town NPC will become transparent when touching Shimmer like other enemies.

			NPCID.Sets.ActsLikeTownNPC[Type] = true;
			NPCID.Sets.NoTownNPCHappiness[Type] = true;
			NPCID.Sets.SpawnsWithCustomName[Type] = true;
			NPCID.Sets.FaceEmote[Type] = ModContent.EmoteBubbleType<ScragglerEmote>();
			NPCID.Sets.AllowDoorInteraction[Type] = true;

			NPCID.Sets.NPCBestiaryDrawModifiers drawModifiers = new NPCID.Sets.NPCBestiaryDrawModifiers() {
				Velocity = 1f,
				Direction = -1
			};

			NPCID.Sets.NPCBestiaryDrawOffset.Add(Type, drawModifiers);

			NPCProfile = new Profiles.StackedNPCProfile(
				new Profiles.DefaultNPCProfile(Texture, -1),
				new Profiles.DefaultNPCProfile(Texture + "_Shimmer", -1)
			);
		}

		public override void SetDefaults() {
			NPC.friendly = true;
			NPC.width = 18;
			NPC.height = 40;
			NPC.aiStyle = 7;
			NPC.damage = 10;
			NPC.defense = 15;
			NPC.lifeMax = 250;
			NPC.HitSound = SoundID.NPCHit1;
			NPC.DeathSound = SoundID.NPCDeath1;
			NPC.knockBackResist = 0.5f;

			AnimationType = NPCID.Dryad;
		}
		public override bool CanChat() {
			return true;
		}

		public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry) {
			bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[] {
				BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.UndergroundJungle,

				new FlavorTextBestiaryInfoElement("Scraggler text."),
				new FlavorTextBestiaryInfoElement("Mods.Miscellanaria.Bestiary.Scraggler")
			});
		}

		public override void HitEffect(NPC.HitInfo hit) {
			int num = NPC.life > 0 ? 1 : 5;

//			for (int k = 0; k < num; k++) {
//				Dust.NewDust(NPC.position, NPC.width, NPC.height, ModContent.DustType<Sparkle>());
//			}

			// Create gore when the NPC is killed.
			if (Main.netMode != NetmodeID.Server && NPC.life <= 0) {
				string variant = "";
				if (NPC.IsShimmerVariant) variant += "_Shimmer";
				int headGore = Mod.Find<ModGore>($"{Name}_Gore{variant}Head").Type;
				int armGore = Mod.Find<ModGore>($"{Name}_Gore{variant}Hand").Type;
				int legGore = Mod.Find<ModGore>($"{Name}_Gore{variant}Leg").Type;

				// Spawn the gores. The positions of the arms and legs are lowered for a more natural look.
				Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, headGore, 1f);
				Gore.NewGore(NPC.GetSource_Death(), NPC.position + new Vector2(0, 20), NPC.velocity, armGore);
				Gore.NewGore(NPC.GetSource_Death(), NPC.position + new Vector2(0, 20), NPC.velocity, armGore);
				Gore.NewGore(NPC.GetSource_Death(), NPC.position + new Vector2(0, 34), NPC.velocity, legGore);
				Gore.NewGore(NPC.GetSource_Death(), NPC.position + new Vector2(0, 34), NPC.velocity, legGore);
			}
		}

		public override ITownNPCProfile TownNPCProfile() {
			return NPCProfile;
		}

		public override List<string> SetNPCNameList() {
			return new List<string> {
				"Benjamin",
				"Someone's Ribcage",
				"Underground Blockster",
				"Darkness"
			};
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			if (spawnInfo.Player.ZoneJungle) {
				return 0.1f;
			}
			return 0f;
		}

		public override string GetChat() {
			WeightedRandom<string> chat = new WeightedRandom<string>();

			chat.Add(Language.GetTextValue("Mods.Miscellanaria.Dialogue.ExampleBoneMerchant.StandardDialogue1"));
			chat.Add(Language.GetTextValue("Mods.Miscellanaria.Dialogue.ExampleBoneMerchant.StandardDialogue2"));
			chat.Add(Language.GetTextValue("Mods.Miscellanaria.Dialogue.ExampleBoneMerchant.StandardDialogue3"));
			return chat;
		}

		public override void SetChatButtons(ref string button, ref string button2) 
		{
			button = Language.GetTextValue("LegacyInterface.28");
		}

		public override void OnChatButtonClicked(bool firstButton, ref string shop) 
		{
			if (firstButton) {
				shop = "Shop";
			}
		}

/*		public override void AddShops() 
		{
			Shop = new ScragglerShop(NPC.type);
				Shop.Add(ItemID.AngelStatue);
				Shop.Add(ItemID.FartinaJar);
				Shop.Add(ItemID.StinkPotion);
				Shop.Add(ItemID.Coal);
				Shop.Add(ItemID.RedPotion);
				Shop.Add(ItemID.GoldenShower);
				Shop.Add(ItemID.MasterBait);
				Shop.Add(ItemID.WaterGun);
				Shop.Add(ItemID.PoopBlock);
				Shop.Add(ItemID.GelBalloon);
			Shop.Register();
		}
*/
		public override void TownNPCAttackStrength(ref int damage, ref float knockback) 
		{
			damage = 20;
			knockback = 2f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown) 
		{
			cooldown = 10;
			randExtraCooldown = 1;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay) {
			projType = ProjectileID.NanoBullet;
			attackDelay = 1;

			// This code progressively delays subsequent shots.
			if (NPC.localAI[3] > attackDelay) {
				attackDelay = 12;
			}
			if (NPC.localAI[3] > attackDelay) {
				attackDelay = 24;
			}
		}

		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset) {
			multiplier = 10f;
			randomOffset = 0.2f;
		}

		public override void TownNPCAttackShoot(ref bool inBetweenShots) {
			if (NPC.localAI[3] > 1) {
				inBetweenShots = true;
			}
		}

//		public override void DrawTownAttackGun(ref Texture2D item, ref Rectangle itemFrame, ref float scale, ref int horizontalHoldoutOffset) {
//			if (!NPC.IsShimmerVariant) {
//				// If using an existing item, use this approach
//				int itemType = ModContent.ItemType<ExampleCustomAmmoGun>();
//				Main.GetItemDrawFrame(itemType, out item, out itemFrame);
//				horizontalHoldoutOffset = (int)Main.DrawPlayerItemPos(1f, itemType).X - 12;
//			}
//			else {
//				// This texture isn't actually an existing item, but can still be used.
//				item = shimmerGun.Value;
//				itemFrame = item.Frame();
//				horizontalHoldoutOffset = -2;
//			}
//		}
	}
}
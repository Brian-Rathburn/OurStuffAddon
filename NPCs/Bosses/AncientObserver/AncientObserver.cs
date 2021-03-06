using Microsoft.Xna.Framework;
using OurStuffAddon.Items.Consumables;
using OurStuffAddon.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.NPCs.Bosses.AncientObserver
{
	[AutoloadBossHead]
	public class AncientObserver : ModNPC
	{
		public int attackTimer = 30;

		public int attackState = 0;

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Observer");
		}

		public override void SetDefaults()
		{
			npc.width = 92;
			npc.height = 68;
			npc.damage = 30;
			npc.lifeMax = 5000;
			npc.life = 5000;
			npc.defense = 5;
			npc.HitSound = SoundID.NPCHit7;
			npc.DeathSound = SoundID.NPCDeath5;
			npc.value = 17000f;
			npc.knockBackResist = 0f;
			npc.boss = true;
			Lighting.AddLight(npc.Center, 0.7f, 0.7f, 0f);
			bossBag = ModContent.ItemType<AncientObserverTreasureBag>();
			music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/boss2");
			npc.lavaImmune = true;
			npc.noGravity = true;
			npc.noTileCollide = true;
		}

		public override void NPCLoot()
		{
			if (!Main.expertMode)
			{
				//Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<AncientShard>(), Main.rand.Next(3, 5)); TODO non existant
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ChippedStone>(), Main.rand.Next(10, 20));
			}

			/* {
                 int loots2 = Main.rand.Next(10);
                 switch (loots2)
                 {
                     case 1: Item.NewItem(npc.getRect(), ModContent.ItemType<GiantSandSifterTrophy>(), 1); break;
                     case 2: break;
                 }
             }*/
			MyWorld.downedAncientObserver = true;
			if (Main.expertMode)
			{
				npc.DropBossBags();
			}
		}

		public override bool PreAI()
		{
			npc.TargetClosest(true);
			return true;
		}

		public override void BossLoot(ref string name, ref int potionType)
		{
			potionType = 188;
			if (MyWorld.downedAncientObserver)
			{
				if (MyWorld.downedAncientObserver == false)
				{
					Main.NewText("*Unintelligable Screech*", 70, 70, 0);
					Main.NewText("Ancient knowledge has been given to you.", 70, 70, 0);
				}
				else
					Main.NewText("Very well...", 70, 70, 0);
			}
		}

		public override void AI()
		{
			if (attackState >= 1 && attackState <= 4)
			{
				Vector2 goalPosition = Main.LocalPlayer.position + new Vector2(240, 0).RotatedBy(MathHelper.Pi / 2 * attackState) - npc.position;
				Vector2 shootDirection = new Vector2(-6, 0).RotatedBy(MathHelper.Pi / 2 * attackState);
				npc.position += goalPosition * 0.4f;
				if (attackTimer % 30 == 0)
				{
					Projectile.NewProjectile(npc.Center, shootDirection, ModContent.ProjectileType<AncientPebbleShot>(), 5, 5, Main.LocalPlayer.whoAmI);
				}
			}
			else if (attackState == 5 && attackTimer == 0)
			{
				npc.velocity = npc.DirectionTo(Main.LocalPlayer.position) * 8f;
			}

			attackTimer--;

			if (attackTimer == 0)
			{
				if (attackState >= 1 && attackState <= 4)
				{
					attackState = 5;
					attackTimer = 35;
				}
				else
				{
					attackState = Main.rand.Next(4) + 1;
					attackTimer = 35;
				}
			}
		}
	}
}
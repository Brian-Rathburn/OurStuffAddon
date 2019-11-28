using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.NPCs.Bosses
{
    [AutoloadBossHead]
    public class OvergrownPumpkin : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Overgrown Pumpkin");
            Main.npcFrameCount[npc.type] = 3;

        }
        public int phase = 0;
        public override void SetDefaults()
        {
            npc.width = 128;
            npc.height = 120;
            npc.damage = 80;
            npc.lifeMax = 50000;
            npc.life = 50000;
            npc.defense = 0;
            phase = 1;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 10000f;
            npc.knockBackResist = 0f;
            npc.aiStyle = 41;
            aiType = NPCID.Derpling;
            animationType = NPCID.Derpling;
            npc.boss = true;
            music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/CosmicSlimeTheme");
            bossBag = mod.ItemType("CosmicSlimeTreasureBag");
        }
      /*  public override void NPCLoot()
        {
            if (!Main.expertMode)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CosmicFragment"), Main.rand.Next(10, 15));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CosmicJelly"), Main.rand.Next(30, 45));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, (3458), Main.rand.Next(10, 15));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, (3456), Main.rand.Next(10, 15));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, (3457), Main.rand.Next(10, 15));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, (3459), Main.rand.Next(10, 15));
            }


             {
                 int loots2 = Main.rand.Next(10);
                 switch (loots2)
                 {
                     case 1: Item.NewItem(npc.getRect(), mod.ItemType("GiantSandSifterTrophy"), 1); break;
                     case 2: break;
                 }
             }
            OurStuffAddonWorld.downedCosmicSlime = true;
            if (Main.expertMode)
            {
                npc.DropBossBags();
            }
        }*/
        public override bool PreAI()
        {
            npc.TargetClosest(true);
            return true;
        }
        public override void BossLoot(ref string name, ref int potionType)
        {
            potionType = 188;
        }

       /* public override void AI()
        {
            //Phases
            if (npc.life < npc.lifeMax * .8 && phase == 1)
            {
                phase = 2;
                NPC.NewNPC((int)npc.position.X - 50, (int)npc.position.Y, mod.NPCType<CosmicSlimeMinion>());
                Main.PlaySound(15, (int)npc.position.X, (int)npc.position.Y, 0);
                Main.NewText("Assist me my minion!", 200, 0, 200);
            }
            if (npc.life < npc.lifeMax * .6 && phase == 2)
            {
                NPC.NewNPC((int)npc.position.X - 50, (int)npc.position.Y, mod.NPCType<CosmicSlimeMinion>());
                phase = 3;
                Main.PlaySound(15, (int)npc.position.X, (int)npc.position.Y, 0);
                Main.NewText("I see you are stronger then I first thought. No matter!", 200, 0, 100);
                npc.damage += 20;
            }
            if (npc.life < npc.lifeMax * .4 && phase == 3)
            {
                NPC.NewNPC((int)npc.position.X - 50, (int)npc.position.Y, mod.NPCType<CosmicSlimeMinion>());
                phase = 4;
                Main.PlaySound(15, (int)npc.position.X, (int)npc.position.Y, 0);
                Main.NewText("ENOUGH!", 200, 0, 0);
                npc.damage += 50;
            }
            if (npc.life < npc.lifeMax * .2 && phase == 4 && Main.expertMode)
            {
                NPC.NewNPC((int)npc.position.X - 50, (int)npc.position.Y, mod.NPCType<CosmicSlimeMinion>());
                NPC.NewNPC((int)npc.position.X - 50, (int)npc.position.Y, mod.NPCType<SolarSlimeMinion>());
                NPC.NewNPC((int)npc.position.X - 50, (int)npc.position.Y, mod.NPCType<NebulaSlimeMinion>());
                NPC.NewNPC((int)npc.position.X - 50, (int)npc.position.Y, mod.NPCType<StardustSlimeMinion>());
                NPC.NewNPC((int)npc.position.X - 50, (int)npc.position.Y, mod.NPCType<VortexSlimeMinion>());
                phase = 5;
                Main.PlaySound(15, (int)npc.position.X, (int)npc.position.Y, 0);
                Main.NewText("ASSIST ME MY COMRADES! WE MUST DEFEAT THIS MENACE!", 225, 0, 0);
                npc.damage += 50;
            }
        }*/
    }
}
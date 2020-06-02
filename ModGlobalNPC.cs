﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace OurStuffAddon
{
    public class ModGlobalNPC : GlobalNPC
    {
        /*public override bool InstancePerEntity
        {
            get
            {
                return true;
            }
        }

        public bool Obsidiflame;

        public override void ResetEffects(NPC npc)
        {
            Obsidiflame = false;
        }

        public override void DrawEffects(NPC npc, ref Color drawColor)
        {
            if (Obsidiflame)
            {
                if (Main.rand.Next(4) < 3)
                {
                    int dust = Dust.NewDust(new Vector2(npc.position.X - 2f, npc.position.Y - 2f), npc.width + 4, npc.height + 4, 14, npc.velocity.X * 0.4f, npc.velocity.Y * 0.4f, 100);
                    Main.dust[dust].noGravity = true;
                    Main.dust[dust].shader = GameShaders.Armor.GetSecondaryShader(56, Main.LocalPlayer);

                    Dust expr_1CCF_cp_0 = Main.dust[dust];
                    expr_1CCF_cp_0.velocity.Y = expr_1CCF_cp_0.velocity.Y - 0.5f;
                    if (Main.rand.Next(4) == 0)
                    {
                        Main.dust[dust].noGravity = false;
                        Main.dust[dust].scale *= 0.5f;
                    }
                }
            }

        }
        public override void UpdateLifeRegen(NPC npc, ref int damage)
        {
            Player player = Main.player[Main.myPlayer];
            OurStuffAddonPlayer modPlayer = player.GetModPlayer<OurStuffAddonPlayer>();
            int dmg;

            if (Obsidiflame)
            {
                if (npc.lifeRegen > 0)
                    npc.lifeRegen = 0;

                npc.lifeRegen -= npc.lifeMax / 10;

                if (damage < npc.lifeMax / 100)
                    damage = npc.lifeMax / 100;
            }
        }*/

    public override void NPCLoot(NPC npc)
        {
            //The if (Main.rand.Next(x) == 0) determines how rare the drop is. To find the percent of a drop, divide 100 by your desired percent, minus the percent sign. Ex: A 2% chance would be 100% / 2%, or 50. This is what you put in place of x.

            if (npc.type == NPCID.Mothron)
            {
                int loots = Main.rand.Next(5);
                switch (loots)
                {
                    case 1:
                        Item.NewItem(npc.getRect(), mod.ItemType("BrokenHeroBow"), Main.rand.Next(1, 1));
                        break;
                    case 2:
                        Item.NewItem(npc.getRect(), mod.ItemType("BrokenHeroBlaster"), Main.rand.Next(1, 1));
                        break;
                    case 3:
                        Item.NewItem(npc.getRect(), mod.ItemType("BrokenHeroDagger"), Main.rand.Next(1, 1));
                        break;
                }
            }
            if (npc.type == NPCID.IceTortoise)
            {
                if (Main.rand.Next(100) == 0) //1% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("FrostStone"));
                }
            }
            if (npc.type == NPCID.DarkCaster)
            {
                if (Main.rand.Next(100) == 0) //1% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AncientBlaster"));
                }
            }
            if (npc.type == NPCID.Vulture)
            {
                if (Main.rand.Next(2) == 0) //50% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SandFeather"));
                }
            }
            if (npc.type == 517)
            {
                if (Main.rand.Next(1) == 0) //100% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CosmicFragment"), Main.rand.Next(15, 20));
                }
            }
            if (npc.type == 493)
            {
                if (Main.rand.Next(1) == 0) //100% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CosmicFragment"), Main.rand.Next(15, 20));
                }
            }
            if (npc.type == 507)
            {
                if (Main.rand.Next(1) == 0) //100% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CosmicFragment"), Main.rand.Next(15, 20));
                }
            }
            if (npc.type == 50)
            {
                if (Main.rand.Next(10) == 0) //100% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CrownJewel"));
                }
            }
            if (npc.type == 4)
            {
                if (Main.rand.Next(10) == 0) //100% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TheEye"));
                }
            }
            if (npc.type == 422)
            {
                if (Main.rand.Next(1) == 0) //100% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CosmicFragment"), Main.rand.Next(15, 20));
                }
            }
            if (npc.type == 517)
            {
                if (Main.rand.Next(1) == 0) //100% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LuminaFragment"), Main.rand.Next(15, 20));
                }
            }
            if (npc.type == 493)
            {
                if (Main.rand.Next(1) == 0) //100% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LuminaFragment"), Main.rand.Next(15, 20));
                }
            }
            if (npc.type == 507)
            {
                if (Main.rand.Next(1) == 0) //100% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LuminaFragment"), Main.rand.Next(15, 20));
                }
            }
            if (npc.type == 422)
            {
                if (Main.rand.Next(1) == 0) //100% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LuminaFragment"), Main.rand.Next(15, 20));
                }
            }
            if (npc.type == 62)
            {
                if (Main.rand.Next(100) == 0) //1% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReaperScythe"));
                }
            }
            if (npc.type == 66)
            {
                if (Main.rand.Next(50) == 0) //2% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReaperScythe"));
                }
            }
            if (npc.type == 113)
            {
                    int loots = Main.rand.Next(3);
                switch (loots)
                {
                    case 1:
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ThrowerEmblem"));
                        break;
                    case 2:
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SpiricistEmblem"));
                        break;
                }
            }
            if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneUnderworldHeight && Main.rand.Next(800) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LavaShard"));
            }
            if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneCrimson && Main.rand.Next(800) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TaintedCore"));
            }
            if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneCorrupt && Main.rand.Next(800) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CursedCore"));
            }
            if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneBeach && Main.rand.Next(800) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PsychicSand"));
            }
            if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneRain && Main.rand.Next(800) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RainEssence"));
            }
            if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneSkyHeight && Main.rand.Next(3) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SkyEssence"));
            }
            if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneJungle && Main.rand.Next(800) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LivingMush"));
            }
            if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneSnow && Main.rand.Next(800) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("IceChip"));
            }
            if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneRockLayerHeight && Main.rand.Next(800) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AncientCore"));
            }
            if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneHoly && Main.rand.Next(800) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CrystalCore"));
            }
            if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneDungeon && Main.rand.Next(800) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Ectoheart"));
            }
            if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneDesert && Main.rand.Next(800) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BottledDune"));
            }
            if (npc.type == 198)
            {
                if (Main.rand.Next(2) == 0) //50% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SolarPebble"), Main.rand.Next(1, 2));
                }
            }
            if (npc.type == 199)
            {
                if (Main.rand.Next(2) == 0) //50% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SolarPebble"), Main.rand.Next(1, 2));
                }
            }
            if (npc.type == 226)
            {
                if (Main.rand.Next(3) == 0) //33% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SolarPebble"), Main.rand.Next(2, 3));
                }
            }
            if (npc.type == 541)
            {
                if (Main.rand.Next(3) == 0) //33% chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SunBlade"));
                }
            }
        }
    }
}
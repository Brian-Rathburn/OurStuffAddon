using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.NPCs.Enemies
{
   	public class LuminescentBat : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Luminescent Bat");
            Main.npcFrameCount[npc.type] = 5;
        }

		public override void SetDefaults()
		{
			npc.width = 44;
			npc.height = 32;
            npc.damage = 30;
            npc.lifeMax = 300;
            npc.life = 300;
			npc.defense = 0;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath4;
			npc.value = 100f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 14;
			aiType = NPCID.CaveBat;
			animationType = NPCID.CaveBat;
            Lighting.AddLight(npc.Center, 0, 5f, 7f);
            npc.noGravity = true;
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.player.GetModPlayer<OurStuffAddonPlayer>().ZoneLuminescentLagoon ? 0.4f : 0f;
        }
        public override void NPCLoot()
        {
            int loots = Main.rand.Next(2);
            switch (loots)
            {
                case 1:
                    Item.NewItem(npc.getRect(), mod.ItemType("SeafoamScale"), Main.rand.Next(1, 2));
                    break;
            }
        }
    }
}
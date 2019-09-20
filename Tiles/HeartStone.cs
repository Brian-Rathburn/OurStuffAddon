
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace OurStuffAddon.Tiles
{
    public class HeartStone : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileLighted[Type] = false;
            Main.tileBlockLight[Type] = true;
            Main.tileSpelunker[Type] = true;
            AddMapEntry(new Color(250, 200, 200));
            mineResist = 1f;
            minPick = 50;
            drop = mod.ItemType("HeartStone");
            soundType = 21;
            dustType = 12;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Heart Stone");
            //soundStyle = 1;
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }
        
        public override bool CanExplode(int i, int j)
        {
            return true;
        }

    }
}
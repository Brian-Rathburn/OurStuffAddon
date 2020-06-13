using Microsoft.Xna.Framework;
using OurStuffAddon.Items.Blocks;
using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Walls.Shadow
{
	public class ShadowBrickWall : ModWall
	{
		public override void SetDefaults()
		{
			Main.wallHouse[Type] = true;

			drop = ModContent.ItemType<ShadowBrickWallItem>();
			AddMapEntry(new Color(1, 1, 1));
		}

		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0.4f;
			g = 0.4f;
			b = 0.4f;
		}
	}
}
using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.DataStructures;

namespace OurStuffAddon.Items.Materials{

    public class SpiritShard : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spirit Shard");
			Tooltip.SetDefault("A fragment of emotion");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(4, 8));
		}
        public override void SetDefaults()
        {
            item.maxStack = 999;                 //this is where you set the max stack of item
            item.consumable = false;           //this make that the item is consumable when used
            item.width = 80;
            item.height = 112;
            item.value = 100;                
            item.rare = 4;
			item.expert = true;
			item.autoReuse = true;
        }
    }
}
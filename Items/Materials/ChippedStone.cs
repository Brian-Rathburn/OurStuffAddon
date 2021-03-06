using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Materials
{
	public class ChippedStone : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chipped Stone");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;                 //this is where you set the max stack of item
			item.consumable = false;           //this make that the item is consumable when used
			item.width = 80;
			item.height = 112;
			item.value = 100;
			item.rare = -1;
			item.value = Item.sellPrice(silver: 50);
			item.expert = false;
			item.autoReuse = true;
		}
	}
}
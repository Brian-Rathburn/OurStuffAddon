using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Materials
{
	public class CursedCore : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cursed Core");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;                 //this is where you set the max stack of item
			item.consumable = false;           //this make that the item is consumable when used
			item.width = 42;
			item.height = 42;
			item.value = 100;
			item.rare = ItemRarityID.Lime;
			item.expert = false;
			item.autoReuse = true;
		}
	}
}
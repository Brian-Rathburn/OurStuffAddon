using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Materials
{
	public class SandSifterMandible : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sand Sifter Mandible");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;                 //this is where you set the max stack of item
			item.consumable = false;           //this make that the item is consumable when used
			item.width = 80;
			item.height = 112;
			item.value = 100;
			item.rare = ItemRarityID.Yellow;
			item.expert = false;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IceBlock, 100);
			recipe.AddIngredient(ItemID.HermesBoots);
			recipe.AddTile(TileID.IceMachine);
			recipe.SetResult(ItemID.IceSkates);
			recipe.AddRecipe();
		}
	}
}
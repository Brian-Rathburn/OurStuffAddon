using OurStuffAddon.Items.Materials;
using OurStuffAddon.Tiles.Seafoam;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Blocks
{
	public class SeafoamBrick : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 16;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.value = 0;
			item.createTile = ModContent.TileType<SeafoamBrickTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.Anvils);
			recipe.AddIngredient(ModContent.ItemType<SeafoamCrystal>(), 1);
			recipe.AddIngredient(ItemID.StoneBlock, 50);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}
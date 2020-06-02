using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Materials
{
	public class LuminaFragment : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lumina Fragment");
			Tooltip.SetDefault("You can feel the emotional power radiating from it." +
								"\n[c/00f2ff:-Spirit Class-]");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;                 //this is where you set the max stack of item
			item.consumable = false;           //this make that the item is consumable when used
			item.width = 32;
			item.height = 32;
			item.value = 100;
			item.rare = 9;
			item.expert = false;
			item.autoReuse = true;
			ItemID.Sets.ItemNoGravity[item.type] = true;
			ItemID.Sets.ItemIconPulse[item.type] = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(3458, 1);
			recipe.AddIngredient(3456, 1);
			recipe.AddIngredient(3457, 1);
			recipe.AddIngredient(3459, 1);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Ranged
{
	public class Duality : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Duality");
		}

		public override void SetDefaults()
		{
			item.damage = 80;
			item.ranged = true;
			item.width = 36;
			item.height = 28;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item41;
			item.autoReuse = true;
			item.shoot = 10;    //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 12f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BlasterGunparts", 1);
			recipe.AddIngredient(mod, "TrueNox", 1);
			recipe.AddRecipeGroup("OurStuffAddon:TrueEvilBlaster");
			recipe.AddIngredient(mod, "BrokenHeroBlaster", 1);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
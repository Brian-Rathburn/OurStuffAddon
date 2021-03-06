using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Ranged
{
	public class DualitySilent : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Duality (silent)");
		}

		public override void SetDefaults()
		{
			item.damage = 80;
			item.ranged = true;
			item.width = 36;
			item.height = 28;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.autoReuse = true;
			item.shoot = ProjectileID.PurificationPowder;    //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 12f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Duality>(), 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
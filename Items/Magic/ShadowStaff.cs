using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Magic
{
	public class ShadowStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shadow Staff");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 26;
			item.magic = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 22;
			item.useAnimation = 22;
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = 100;
			item.rare = 6;
			item.UseSound = SoundID.Item43;
			item.autoReuse = true;
			item.shoot = 126;
			item.shootSpeed = 6f;
			item.mana = 5;
			item.noMelee = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ShadowCrystal", 10);
			recipe.AddIngredient(mod, "TrenagonBar", 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
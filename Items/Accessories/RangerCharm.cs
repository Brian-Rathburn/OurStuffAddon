﻿using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace OurStuffAddon.Items.Accessories
{
	public class RangerCharm : ModItem //replace ItemName with the name of your accessory
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ranger Charm");
			Tooltip.SetDefault("Harness the power of the Sight and push your Ranged Abilities beyond (Increases Ranged Damage By 1/3 But Lowers Crit Chance).");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.rangedDamage += .3f;
			player.rangedCrit -= 10;
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.accessory = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Emerald, 50);
			recipe.AddIngredient(ItemID.NecroHelmet, 1);
			recipe.AddIngredient(ItemID.NecroBreastplate, 1);
			recipe.AddIngredient(ItemID.NecroGreaves, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
﻿using OurStuffAddon.Items.SpiritDamageClass;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Accessories
{
	public class SpiricistCharm : ModItem //replace ItemName with the name of your accessory
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spiricist Charm");
			Tooltip.SetDefault("Harness the power of the Heart and push your Spiritual Abilities beyond (Increases [c/00f2ff:Spirit Damage] By 1/3 But Lowers Defence)." +
				"\n[c/00f2ff:-Spirit Class-]");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			SpiritDamagePlayer modPlayer = SpiritDamagePlayer.ModPlayer(player);
			modPlayer.spiritDamageMult *= 1.3f;
			player.statDefense -= 20;
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
			recipe.AddIngredient(ModContent.ItemType<SeafoamCrystal>(), 50);
			recipe.AddIngredient(ModContent.ItemType<FelmarHelmet>(), 1);
			recipe.AddIngredient(ModContent.ItemType<FelmarBodypiece>(), 1);
			recipe.AddIngredient(ModContent.ItemType<FelmarCuisses>(), 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
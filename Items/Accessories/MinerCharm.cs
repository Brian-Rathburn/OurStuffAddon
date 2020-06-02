﻿using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace OurStuffAddon.Items.Accessories
{
	public class MinerCharm : ModItem //replace ItemName with the name of your accessory
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Miner Charm");
			Tooltip.SetDefault("Harness the power of the Sight and push your Mining Prowess beyond (Increases Pick Speed And Gives Great Sight).");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.pickSpeed -= .3f;
			player.detectCreature = true;
			player.dangerSense = true;
			player.findTreasure = true;
			Lighting.AddLight((int)(player.position.X + player.width / 2) / 16, (int)(player.position.Y + player.height / 2) / 16, 0.8f, 0.95f, 1f);
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
			recipe.AddIngredient(ItemID.Topaz, 50);
			recipe.AddIngredient(ItemID.MiningHelmet, 1);
			recipe.AddIngredient(ItemID.MiningShirt, 1);
			recipe.AddIngredient(ItemID.MiningPants, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
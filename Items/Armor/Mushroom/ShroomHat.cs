using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Mushroom
{
	[AutoloadEquip(EquipType.Head)]
	public class ShroomHat : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Shroom Hat");
			Tooltip.SetDefault("\n+1 Minions");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 10;
			item.value = 100;
			item.rare = ItemRarityID.Green;
			item.defense = 3;
		}

		public override void UpdateEquip(Player player)
		{
			//player.endurance *= 1.05f;
			//player.statManaMax2 += 20;
			player.maxMinions += 1;
			//player.AddBuff(BuffID.Shine, 2);
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<ShroomShirt>() && legs.type == ModContent.ItemType<ShroomShoes>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increased Life Regen, +1 Minion, Gives a dim blue glow.";
			player.lifeRegen += 1;
			player.maxMinions += 1;
			Lighting.AddLight((int)(player.position.X + player.width / 2) / 16, (int)(player.position.Y + player.height / 2) / 16, 0f, 0f, 1f);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GlowingMushroom, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.HMThrown
{
	[AutoloadEquip(EquipType.Head)]
	public class OrichalcumHeadpiece : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Orichalcum Headpiece");
			Tooltip.SetDefault(" 13% Thrown Damage");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 10;
			item.value = 100;
			item.rare = ItemRarityID.Red;
			item.defense = 12;
		}

		public override void UpdateEquip(Player player)
		{
			//player.endurance *= 1.05f;
			player.thrownDamage *= 1.13f;
			//player.AddBuff(BuffID.Shine, 2);
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ItemID.OrichalcumBreastplate && legs.type == ItemID.OrichalcumLeggings;
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "+17% thrown velocity and +5% endurance.";
			player.thrownVelocity *= 1.17f;
			player.endurance *= 1.05f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.OrichalcumBar, 12);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
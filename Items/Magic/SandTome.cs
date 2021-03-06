using OurStuffAddon.Projectiles;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Magic
{
	public class SandTome : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sand Tome");
		}

		public override void SetDefaults()
		{
			item.damage = 25;
			item.magic = true;
			item.width = 30;
			item.height = 32;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 2;
			item.value = 100;
			item.rare = ItemRarityID.LightPurple;
			item.UseSound = SoundID.Item8;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<SifterToothProjectile>();
			item.shootSpeed = 7f;
			item.mana = 10;
			item.noMelee = true;
		}
	}
}
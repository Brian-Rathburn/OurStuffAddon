using OurStuffAddon.Projectiles.Pets;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace OurStuffAddon.Buffs
{
	public class SpiritPetBuff : ModBuff
	{
		public override void SetDefaults()
		{
			// DisplayName and Description are automatically set from the .lang files, but below is how it is done normally.
			DisplayName.SetDefault("Spirit");
			Description.SetDefault("He Wants To Journey With You!");
			Main.buffNoTimeDisplay[Type] = true;
			Main.vanityPet[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.buffTime[buffIndex] = 18000;
			player.GetModPlayer<MyPlayer>().SpiritPet = true;
			bool petProjectileNotSpawned = player.ownedProjectileCounts[ProjectileType<Projectiles.Pets.SpiritPetProjectile>()] <= 0;

			if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
				Projectile.NewProjectile(player.position.X + player.width / 2, player.position.Y + player.height / 2, 0f, 0f, ModContent.ProjectileType<SpiritPetProjectile>(), 0, 0f, player.whoAmI, 0f, 0f);
		}
	}
}
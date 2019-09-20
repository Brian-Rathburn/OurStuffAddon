using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Ranged
{
    public class SporeBlaster : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spore Blaster");
        }
        public override void SetDefaults()
        {
            item.damage = 30;
            item.ranged = true;
            item.width = 36;
            item.height = 28;
            item.useTime = 19;
            item.useAnimation = 19;
            item.useStyle = 5;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 4;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item41;
            item.autoReuse = false;
            item.shoot = 10;    //idk why but all the guns in the vanilla source have this
            item.shootSpeed = 12f;
            item.useAmmo = AmmoID.Bullet;
        }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            target.AddBuff(BuffID.Poisoned, 5 * 60);
        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "BlasterGunparts", 1);
            recipe.AddIngredient(209, 20);
            recipe.AddIngredient(331, 25);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }





    }



}
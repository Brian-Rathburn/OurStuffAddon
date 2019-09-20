using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Blocks
{
    public class PlagueWoodFence : ModItem
    {



        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 0;
            item.createWall = mod.WallType("PlagueWoodFence");
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddTile(TileID.Anvils);
            recipe.AddIngredient(mod, "PlagueWood");
            recipe.SetResult(this, 4);
            recipe.AddRecipe();
        }
    }
}
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZeldaMod.Items
{
    public class Anvil : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Kontayheghian Anvil";
            item.width = 12;
            item.height = 12;
            item.maxStack = 99;
            AddTooltip("Specifically named to be hard to pronounce");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 100000;
            item.createTile = mod.TileType("Anvil");

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.Dirt);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
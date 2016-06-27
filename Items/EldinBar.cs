using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;

namespace ZeldaMod.Items
{
    class EldinBar : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Eldin Metal Bar";
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            AddTooltip("Hard material for forging weapons");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("EldinOre"), 4);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework.Graphics;
using ZeldaMod;

namespace ZeldaMod
{
    class ZeldaMod : Mod
    {
        public ZeldaMod()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }

        public override void Load()
        {
            RegisterHotKey("NormalProjectile", "N");
        }

        public override void HotKeyPressed(string name)
        {
            if (name == "NormalProjectile")
            {
                // Main.player[Main.myPlayer].GetModPlayer<ZMPlayer>(this).specialProjectileType = -1;
                Main.player[Main.myPlayer].GetModPlayer<ZMPlayer>(this).switchArrow = 0;
            }
        }
        public override void AddRecipeGroups()
        {
            RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + " " + "Titanium Bar", new int[]
            {
                ItemID.TitaniumBar,
                ItemID.AdamantiteBar
            });
            RecipeGroup.RegisterGroup("Titanium Bars", group);
        }
        public override void AddRecipes()
        {
            //Removing recipes for hero's clothes
            Main.recipe[1096].requiredItem[0].SetDefaults(0);
            Main.recipe[1096].requiredItem[1].SetDefaults(0);

            Main.recipe[1097].requiredItem[0].SetDefaults(0);
            Main.recipe[1097].requiredItem[1].SetDefaults(0);

            Main.recipe[1098].requiredItem[0].SetDefaults(0);
            Main.recipe[1098].requiredItem[1].SetDefaults(0);

            //Green Tunic Recipes
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemType("EldinBar"), 20);
            recipe.AddIngredient(ItemID.GreenThread, 1);
            recipe.AddIngredient(ItemID.Silk, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemType("GreenTunicBoots"));
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemType("EldinBar"), 25);
            recipe.AddIngredient(ItemID.GreenThread, 1);
            recipe.AddIngredient(ItemID.Silk, 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemType("GreenTunicMail"));
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemType("EldinBar"), 20);
            recipe.AddIngredient(ItemID.GreenThread, 1);
            recipe.AddIngredient(ItemID.Silk, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemType("GreenTunicHead"));
            recipe.AddRecipe();


            //Red Tunic Recipes
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.HellstoneBar, 20);
            recipe.AddIngredient(ItemID.Silk, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemType("RedTunicBoots"));
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.HellstoneBar, 25);
            recipe.AddIngredient(ItemID.Silk, 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemType("RedTunicMail"));
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.HellstoneBar, 20);
            recipe.AddIngredient(ItemID.Silk, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemType("RedTunicHead"));
            recipe.AddRecipe();

            //Blue Tunic Recipes
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Titanium Bars", 5);
            recipe.AddIngredient(ItemID.FrostCore, 1);
            recipe.AddIngredient(ItemID.Silk, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemType("BlueTunicBoots"));
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.FrostCore, 1);
            recipe.AddRecipeGroup("Titanium Bars", 5);
            recipe.AddIngredient(ItemID.Silk, 15);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemType("BlueTunicMail"));
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.FrostCore, 1);
            recipe.AddRecipeGroup("Titanium Bars", 5);
            recipe.AddIngredient(ItemID.Silk, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemType("BlueTunicHead"));
            recipe.AddRecipe();
        }


    }
}

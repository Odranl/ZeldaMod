using System;
using System.Collections.Generic;
using Terraria.ModLoader;
using Terraria.ID;

namespace ZeldaMod.Items.Armour.GoldTunic
{
    class GoldTunicBoots : ModItem
    {
        

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Gold Tunic Boots";
            item.width = 18;
            item.height = 18;
            item.toolTip = "Zelda.";
            item.value = 10000;
            item.rare = 2;
            item.defense = 35;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 6);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

       // public static Mod getMod()
      //  {
       // }
    }
}

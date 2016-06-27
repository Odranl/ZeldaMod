using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZeldaMod.Items.Armour.GoldTunic
{
    class GoldTunicHead : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Head);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Gold Tunic Hat";
            item.width = 28;
            item.height = 18;
            item.toolTip = "Zelda!";
            item.value = 10000;
            item.rare = 2;
            item.defense = 30;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("GoldTunicMail") && legs.type == mod.ItemType("GoldTunicBoots");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Increased hero's bow and kokiri sword dmg, increased movement speed and awesomeness!";
            player.rangedDamage += .1f;
            player.moveSpeed += .1f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 2);
            recipe.AddTile(TileID.Dirt);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

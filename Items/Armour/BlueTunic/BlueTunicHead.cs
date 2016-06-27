using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZeldaMod.Items.Armour.BlueTunic
{
    class BlueTunicHead : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Head);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Blue Tunic Hat";
            item.width = 28;
            item.height = 18;
            item.toolTip = "Zelda!";
            item.value = 10000;
            item.rare = 2;
            item.defense = 30;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("BlueTunicMail") && legs.type == mod.ItemType("BlueTunicBoots");
        }

        public override void UpdateArmorSet(Player player)
        {
            Main.player[Main.myPlayer].GetModPlayer<ZMPlayer>(mod).tunicEquiped = 3;

            player.setBonus = "Increased Zelda weapons dmg, give ability to swim and infinite breathing!";
            player.rangedDamage += .1f;
            player.moveSpeed += .1f;
            player.accFlipper = true;
            player.forceMerman = true;
            player.hideMerman = true;
        }
    }
}

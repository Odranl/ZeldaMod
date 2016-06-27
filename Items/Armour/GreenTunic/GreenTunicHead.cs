using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZeldaMod.Items.Armour.GreenTunic
{
    class GreenTunicHead : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Head);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Green Tunic Hat";
            item.width = 28;
            item.height = 18;
            item.toolTip = "Zelda!";
            item.value = 10000;
            item.rare = 2;
            item.defense = 6;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("GreenTunicMail") && legs.type == mod.ItemType("GreenTunicBoots");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Increased Zelda weapons dmg, increased awesomeness!";
            player.GetModPlayer<ZMPlayer>(mod).hasGreenTunicEquiped = true;
        }
    }
}

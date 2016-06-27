using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZeldaMod.Items.Armour.RedTunic
{
    class RedTunicHead : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Head);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Red Tunic Hat";
            item.width = 28;
            item.height = 18;
            item.toolTip = "Goron!";
            item.value = 10000;
            item.rare = 2;
            item.defense = 9;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("RedTunicMail") && legs.type == mod.ItemType("RedTunicBoots");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Increased Zelda weapons dmg, reduced lava dmg. Ice biome enemies are less effective";
            Main.player[Main.myPlayer].GetModPlayer<ZMPlayer>(mod).tunicEquiped = 2;
            player.lavaRose = true;
            player.AddBuff(BuffID.Warmth, 2);
        }
    }
}

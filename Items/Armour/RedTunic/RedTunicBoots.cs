using System;
using System.Collections.Generic;
using Terraria.ModLoader;
using Terraria.ID;

namespace ZeldaMod.Items.Armour.RedTunic
{
    class RedTunicBoots : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Red Tunic Boots";
            item.width = 18;
            item.height = 18;
            item.toolTip = "Goron version.";
            item.value = 10000;
            item.rare = 2;
            item.defense = 9;
        }
    }
}

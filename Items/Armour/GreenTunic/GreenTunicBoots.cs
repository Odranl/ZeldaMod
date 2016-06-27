using System;
using System.Collections.Generic;
using Terraria.ModLoader;
using Terraria.ID;

namespace ZeldaMod.Items.Armour.GreenTunic
{
    class GreenTunicBoots : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Green Tunic Boots";
            item.width = 18;
            item.height = 18;
            item.toolTip = "Zelda.";
            item.value = 10000;
            item.rare = 2;
            item.defense = 7;
        }

        
    }
}

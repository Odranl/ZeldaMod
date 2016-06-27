using System;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZeldaMod.Items.Armour.BlueTunic
{
    class BlueTunicMail : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Green Tunic Mail";
            item.width = 28;
            item.height = 18;
            item.toolTip = "Zelda!";
            item.value = 10000;
            item.rare = 2;
            item.defense = 40;

        }
    }
}

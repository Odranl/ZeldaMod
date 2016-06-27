using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZeldaMod
{
    class ModGlobalItem : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.Star)
                if (Main.rand.Next(3) == 0)
                    item.healMana = (int)Main.player[Main.myPlayer].statManaMax / 2;
                else
                    item.healMana = (int)Main.player[Main.myPlayer].statManaMax / 4;
        }
    }
}

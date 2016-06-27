using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZeldaMod.Items.Placeable
{
    public class EldinOre : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Eldin Ore";
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            AddTooltip("Hard material for forging weapons");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("EldinOre");
            //ItemID.Sets.ExtractinatorMode[item.type] = item.type;
        }
    }
}
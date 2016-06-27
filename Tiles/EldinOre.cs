using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace ZeldaMod.Tiles
{
    public class EldinOre : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            drop = mod.ItemType("EldinOre");
            AddMapEntry(new Color(200, 200, 200));
            Main.tileSpelunker[Type] = true;
        }
    }
}
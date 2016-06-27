using System.IO;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation;
using System;

namespace ZeldaMod
{
    public class ZMWorld : ModWorld
    {
        private const int saveVersion = 0;

        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (ShiniesIndex == -1)
            {
                // Shinies pass removed by some other mod.
                return;
            }
            tasks.Insert(ShiniesIndex + 1, new PassLegacy("Eldin Ores", delegate (GenerationProgress progress)
            {
                progress.Message = "Eldin Ores";

                for (int num2 = 0; num2 < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 0.0002); num2++)
                {
                    WorldGen.TileRunner(WorldGen.genRand.Next(0, Main.maxTilesX), WorldGen.genRand.Next((int)WorldGen.rockLayer, Main.maxTilesY), (double)WorldGen.genRand.Next(4, 9), WorldGen.genRand.Next(4, 8), mod.TileType("EldinOre"), false, 0f, 0f, false, true);
                }
            })); 
        }

    }
}
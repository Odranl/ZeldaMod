using System;
using System.IO;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ID;
using ZeldaMod.Items.Armour.GoldTunic;
using ZeldaMod;

namespace ZeldaMod
{
    class ZMPlayer : ModPlayer
    {
        public int switchArrow; //Change the type of arrow shooted from Hero's Bow
        public int specialProjectileType = -1; //Used by Hero's Bow to choose wich arrow 

        public int tunicEquiped;

        public bool hasRightClicked = false;

        public override void ResetEffects()
        {
            this.tunicEquiped = -1;
        }

        // Give bonuses to Zelda weapons when Tunics are worn
        public override void ModifyHitNPC(Item item, NPC target, ref int damage, ref float knockback, ref bool crit)
        {
            int selectedItem = player.inventory[player.selectedItem].type;
            int[] zeldaItems = { mod.ItemType("KokiriSword"), mod.ItemType("MasterSword"), mod.ItemType("TempredMasterSword"), mod.ItemType("GoldenMasterSword") };

            for (int idZeldaWeapons =0; idZeldaWeapons<zeldaItems.Length;idZeldaWeapons++)
            switch (tunicEquiped)
            {
                case 1:
                    if (selectedItem == zeldaItems[idZeldaWeapons])
                        damage += 5;
                    break;
                case 2:
                    if (selectedItem == zeldaItems[idZeldaWeapons])
                        damage += 15;
                    break;
                case 3:
                    if (selectedItem == zeldaItems[idZeldaWeapons])
                        damage += 30;
                    break;
                case 4:
                    if (selectedItem == zeldaItems[idZeldaWeapons])
                        damage += 50;
                    break;


                //default:
                  //  break;

            }
        }
        public override void ModifyHitNPCWithProj(Projectile proj, NPC target, ref int damage, ref float knockback, ref bool crit)
        {

        }

    }
}


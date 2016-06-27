using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZeldaMod.Items.Weapons
{
    public class HerosBow : ModItem
    {

        public override void SetDefaults()
        {
            item.name = "Hero's Bow";
            item.damage = 20;
            item.ranged = true;
            item.noMelee = true;
            item.width = 14;
            item.height = 42;
            item.toolTip = "The tresaure of Gorons.";
            item.useTime = 27;
            item.useAnimation = 27;
            item.useStyle = 5;
            item.knockBack = 2;
            item.value = 10000;
            item.rare = 2;
            item.shoot = mod.ProjectileType("LightArrow");
            item.useAmmo = 1;
            item.useSound = 1;
            item.shootSpeed = 9;
            item.autoReuse = true;
        }

        public override bool AltFunctionUse(Player player) //Enable right click
        {
            //Main.NewText("AltFunctionUse works!");
            return true;
        }
        public override bool UseItem(Player player)
        {
            return base.UseItem(player);
        }

        public override bool CanUseItem(Player player)
        {
            return true;
        }

        public override bool ConsumeAmmo(Player player) //So that when right clicking it change the projectile but doesn't shoot anything
        {
            if (player.altFunctionUse == 2)
                return false;
            else
                return true;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            ZMPlayer mp = player.GetModPlayer<ZMPlayer>(mod);
            if (player.altFunctionUse == 2) // if right click switch projectile that will be shooted
            {
                if (mp.switchArrow == 3) //Variable in ZMPlayer (ModPlayer)
                    mp.switchArrow = 0;
                else
                    mp.switchArrow++;
                CreateDust(mp.switchArrow);
                // Main.NewText("You right clicked the bow");
                return false;
            }

            // If there is, however, we want to set the projectile type we want to shoot to the specialProjetileType of the player.

            switch (mp.switchArrow)
            {

                case 1:
                    if (player.statMana >= 25)
                    {
                        player.statMana -= 25;
                        type = ProjectileID.FireArrow;
                        damage = 50;
                    }
                    else
                    {
                        type = ProjectileID.WoodenArrowFriendly;
                        damage = 20;
                    }
                    break;
                case 2:
                    if (player.statMana >= 25)
                    {
                        player.statMana -= 25;
                        type = ProjectileID.FrostburnArrow;
                        damage = 40;
                    }
                    else
                    {
                        type = ProjectileID.WoodenArrowFriendly;
                    }
                    break;
                case 3:
                    if (player.statMana >= 50)
                    {
                        player.statMana -= 50;
                        type = mod.ProjectileType("LightArrow");
                        damage = 150;
                    }
                    else
                    {
                        type = ProjectileID.WoodenArrowFriendly;
                        damage = 20;
                    }
                    break;
                default:
                    break;

            }
            //Main.NewText("You left clicked the bow");
            return true;
        }
        public virtual void CreateDust(int projType)
        {
            Player player = Main.player[Main.myPlayer];
            // if (projType==1)
            int dust;
            switch (projType)
            {
                
                case 1:
                    for (int i=0; i<23; i++)
                        dust = Dust.NewDust(player.position, item.width, item.height, 130, 0f, 0f, 0, Color.Red, 1.2f);
                    break;
                case 2:
                    for (int i = 0; i < 23; i++)
                        dust = Dust.NewDust(player.position, item.width, item.height, 132, 0f, 0f, 0, Color.Blue, 1.2f);
                    break;
                case 3:
                    for (int i = 0; i < 23; i++)
                        dust = Dust.NewDust(player.position, item.width, item.height, 133, 0f, 0f, 0, Color.Yellow, 1.2f);
                    break;
                default:
                    break;
            }
        }

    }
}

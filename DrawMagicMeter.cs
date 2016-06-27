using System;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace ZeldaMod
{
    class DrawMagicMeter
    {
        /*const int barHeight = 15;
        public static void DrawExperienceBar(ModItem modItem)
        {
            if (Main.playerInventory)
                return;

            Player player = Main.player[modItem.item.owner];
            ZMPlayer modPlayer = (ZMPlayer)player.GetModPlayer(modItem.mod, "ZMPlayer");
            if (player.inventory[player.selectedItem].type == modItem.item.type)
            {
                if (!Main.ingameOptionsWindow && !Main.playerInventory/* && !Main.achievementsWindow)
                {
                    int xPos = 50;
                    int yPos = 140;

                    Color color = Color.White;
                    //string text = "Ooops";
                    float percentage = 0;
                    percentage = modPlayer.getCurrentMagic();

                    Texture2D white = modItem.mod.GetTexture("UI/white");
                    Texture2D green = modItem.mod.GetTexture("UI/green");
                    Texture2D black = modItem.mod.GetTexture("UI/black");

                    // Black Shadow
                    Main.spriteBatch.Draw(black, new Vector2(xPos + 1, yPos), null, color, 0f, Vector2.Zero, new Vector2(100, barHeight + 4), SpriteEffects.None, 0f);
                    // Back
                    //Main.spriteBatch.Draw(darkyellow, new Vector2(xPos, yPos), null, color, 0f, Vector2.Zero, new Vector2(100, barHeight), SpriteEffects.None, 0f);
                    // Bar
                    Main.spriteBatch.Draw(green, new Vector2(xPos, yPos + 3), null, color, 0f, Vector2.Zero, new Vector2(100 * percentage, barHeight - 3), SpriteEffects.None, 0f);
                    // WhiteBars
                    Main.spriteBatch.Draw(white, new Vector2(xPos, yPos), null, color, 0f, Vector2.Zero, new Vector2(100, 2), SpriteEffects.None, 0f);
                    Main.spriteBatch.Draw(white, new Vector2(xPos, yPos + barHeight), null, color, 0f, Vector2.Zero, new Vector2(100, 2), SpriteEffects.None, 0f);

                    //Lv 3[||||||   ]
                    //Main.spriteBatch.DrawString(Main.fontMouseText, text, new Vector2(xPos - 33, yPos), color, 0.0f, new Vector2(), 0.8f, SpriteEffects.None, 0.0f);

                    if (percentage >= 1f)
                    {
                        Main.spriteBatch.DrawString(Main.fontMouseText, "MAX", new Vector2(xPos - 20 + 50, yPos), Color.DarkOrange, 0.0f, new Vector2(), 1f, SpriteEffects.None, 0.0f);
                    }
                }*/
            }
        }


using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace ZeldaMod.Items.Weapons.MasterSwords
{
	public class GoldenMasterSword : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Golden Master Sword";
			item.damage = 100;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.scale = 1.3f;
            item.toolTip = "Imbued with the ultimate power.";
			item.useTime = 20;
            item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.useSound = 1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("GoldMedallion"), 1);
            recipe.AddIngredient(mod.ItemType("GreenMedallion"), 1);
            recipe.AddIngredient(mod.ItemType("RedMedallion"), 1);
            recipe.AddIngredient(mod.ItemType("BlueMedallion"), 1);
            recipe.AddIngredient(mod.ItemType("VioletMedallion"), 1);
            recipe.AddIngredient(mod.ItemType("OrangeMedallion"), 1);
            recipe.AddIngredient(mod.ItemType("TempredMasterSword"), 1);
            recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 78);
		}
	}
}

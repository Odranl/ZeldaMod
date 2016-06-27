using Terraria.ID;
using Terraria.ModLoader;

namespace ZeldaMod.Items.Weapons.MasterSwords
{
	public class TempredMasterSword : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Tempred Master Sword";
			item.damage = 60;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.toolTip = "Hardened to be even stronger.";
			item.useTime = 18;
            item.useAnimation = 18;
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
			recipe.AddIngredient(mod.ItemType("MasterSword"), 1);
			recipe.AddTile(TileID.AdamantiteForge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

using Terraria.ID;
using Terraria.ModLoader;

namespace ZeldaMod.Items.Weapons
{
	public class KokiriSword : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Kokiri Sword";
			item.damage = 20;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.toolTip = "The tresaure of kokiri.";
			item.useTime = 15;
            item.useAnimation = 15;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.useSound = 1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("EldinBar"), 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

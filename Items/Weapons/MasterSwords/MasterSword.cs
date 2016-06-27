using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZeldaMod;

namespace ZeldaMod.Items.Weapons.MasterSwords
{
	public class MasterSword : ModItem
	{
        ModItem modItem = new ModItem();
		public override void SetDefaults()
		{
			item.name = "Master Sword";
			item.damage = 42;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.toolTip = "Imbued with the power of the elements.";
			item.useTime = 18;
            item.useAnimation = 18;
			item.useStyle = 1;
			item.knockBack = 4.5f;
			item.value = 10000;
			item.rare = 2;
			item.useSound = 1;
			item.autoReuse = true;
		}

        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("EldinBar"), 12);
            recipe.AddIngredient(mod.ItemType("PendantOfCourage"), 1);
            recipe.AddIngredient(mod.ItemType("PendantOfPower"), 1);
            recipe.AddIngredient(mod.ItemType("PendantOfWisdom"), 1);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

        }

    }
}

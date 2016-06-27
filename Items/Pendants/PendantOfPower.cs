using Terraria.ID;
using Terraria.ModLoader;

namespace ZeldaMod.Items.Pendants
{
	public class PendantOfPower : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Pendant Of Power";
			item.width = 40;
			item.height = 40;
			item.toolTip = "Do you feel it?";
			item.value = 10000;
			item.rare = 2;
		}
	}
}

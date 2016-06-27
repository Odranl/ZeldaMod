using Terraria.ID;
using Terraria.ModLoader;

namespace ZeldaMod.Items.Pendants
{
	public class PendantOfCourage : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Pendant Of Courage";
			item.width = 26;
			item.height = 26;
			item.toolTip = "Distilled Courage.";
			item.value = 10000;
			item.rare = 2;
		}
	}
}

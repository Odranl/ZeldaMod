using Terraria.ID;
using Terraria.ModLoader;

namespace ZeldaMod.Items.Pendants
{
	public class PendantOfWisdom : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Pendant Of Wisdom";
			item.width = 40;
			item.height = 40;
			item.toolTip = "The essence of the sages.";
			item.value = 10000;
			item.rare = 2;
		}
	}
}

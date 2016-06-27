using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZeldaMod.NPCs
{
	public class ModGlobalNPC : GlobalNPC
	{

		public override void NPCLoot(NPC npc)
		{
			if (npc.type == NPCID.SkeletronHead)
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PendantOfCourage"));

            if (npc.type == NPCID.BrainofCthulhu || ((npc.type == NPCID.EaterofWorldsBody || npc.type ==  NPCID.EaterofWorldsHead || npc.type == NPCID.EaterofWorldsTail) && npc.boss))
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PendantOfPower"));

            if (npc.type == NPCID.QueenBee)
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PendantOfWisdom"));

            if (npc.type == NPCID.SkeletronPrime)
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GreenMedallion"));

            if (npc.type == NPCID.TheDestroyer)
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RedMedallion"));

            if ((npc.type == NPCID.Retinazer || npc.type == NPCID.Spazmatism) && npc.boss)
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GoldMedallion"));

            if (npc.type == NPCID.Plantera)
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BlueMedallion"));

            if (npc.type == NPCID.GolemHeadFree)
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("VioletMedallion"));

            if (npc.type == NPCID.DukeFishron)
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("OrangeMedallion"));
        }
    }
}
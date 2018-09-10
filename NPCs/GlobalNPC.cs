using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ProjectIX.NPCs
{
    public class ModGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (Main.rand.Next(3) == 1)
            {
                if (npc.type == NPCID.Crab || npc.type == NPCID.Shark)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Coralite"), 6 + Main.rand.Next(9));
                }
				
            }

            if (Main.rand.Next(2) == 1)
            {
                if (npc.type == NPCID.WyvernHead)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AstraliteCrystal"), 1);
                }

            }
        }
    }
}
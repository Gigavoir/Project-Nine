using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ProjectIX.Items
{
	public class ItemChanges : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if(item.type == 1506)
			{
				item.pick = 205;
			}

			if(item.type == 2176)
			{
				item.pick = 205;
			}
		}
	}
}
using Terraria.ID;
using Terraria.ModLoader;

namespace ProjectIX.Items.Apoclite
{
	public class ApocliteAnvil : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Used to craft items from Apoclite Crystals, Galaxium Bars, and Glacial Bars");
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 18;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = mod.TileType("ApocliteAnvilTile");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WorkBench);
			recipe.AddIngredient(null, "ApocliteCrystal", 10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
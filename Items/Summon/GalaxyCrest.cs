using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.Utilities;


namespace ProjectIX.Items.Summon
{
    public class GalaxyCrest : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Galaxy Crest");
            Tooltip.SetDefault("Summons a Rift Wurm");

        }

        public override void SetDefaults()
        {
            item.width = 38;
            item.height = 38;
            item.maxStack = 20;
            item.value = 100;
            item.rare = 1;
            item.useAnimation = 40;
            item.useTime = 45;
            item.consumable = true;

            item.useStyle = 4; // Holds up like a summon item.
        }

        public override bool CanUseItem(Player player)
        {
            // Main Bosses


            bool isHardmode = Main.hardMode; // Downed WoF


            // Does NPC Exist
            bool alreadySpawned = NPC.AnyNPCs(mod.NPCType("RiftWurmHead"));

            //return NPC.downedQueenBee && Main.hardMode && !NPC.AnyNPCs(mod.NPCType("AkashaBoss")); // NPC will spawn if No existing Tutorial Boss, Queen Bee is downed and it is hardmode 
            return !alreadySpawned;
        }


        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("RiftWurmHead")); // Spawn the boss within a range of the player. 
            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SpectreBar, 25);
            recipe.AddIngredient(null, "ApocliteCrystal", 10);
            recipe.AddIngredient(ItemID.SoulofNight, 15);
            recipe.AddIngredient(ItemID.SoulofLight, 15);
            recipe.SetResult(this);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddRecipe();
        }
    }
}
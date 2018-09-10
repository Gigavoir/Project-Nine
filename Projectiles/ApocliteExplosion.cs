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

namespace ProjectIX.Projectiles
{
	public class ApocliteExplosion : ModProjectile
	{
		public override void SetDefaults()
		{

			projectile.width = 100;
			projectile.height = 100;
			projectile.friendly = true;
			projectile.aiStyle = 0;
			projectile.timeLeft = 15;
			projectile.penetrate = 100;
			projectile.tileCollide = false; 
			projectile.ignoreWater = true; 
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[projectile.type] = 2;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Apocalypse Burst");
		}
		
		public override void AI()
		{
			Dust dust;
			// You need to set position depending on what you are doing. You may need to subtract width/2 and height/2 as well to center the spawn rectangle.
			Vector2 position = Main.LocalPlayer.Center;
			dust = Main.dust[Terraria.Dust.NewDust(projectile.position, 100, 100, 182, 0f, 0f, 0, new Color(255,255,255), 3.25f)];
			dust.noGravity = true;
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
		}
		
		public override void Kill(int timeLeft)
		{
			Main.PlaySound(39, (int)projectile.position.X, (int)projectile.position.Y, 0);
		}

	}
}
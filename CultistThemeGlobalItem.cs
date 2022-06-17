using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.Utilities;

namespace CultistTheme
{
	public class CultistThemeGlobalItem : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.MusicBoxBoss4)
			{
				item.SetNameOverride("Music Box (Golem)");
			}
		}
	}
}

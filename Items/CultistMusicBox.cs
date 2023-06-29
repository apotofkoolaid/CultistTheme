using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Utilities;
using Terraria.Localization;

namespace CultistTheme.Items
{
	public class CultistMusicBox : ModItem
	{
		public override LocalizedText DisplayName => Language.GetOrRegister("Music Box (Lunatic Cultist)");

		public override LocalizedText Tooltip => Language.GetOrRegister("");

		public override void SetStaticDefaults()
		{
			MusicLoader.AddMusicBox(Mod, MusicLoader.GetMusicSlot(Mod, "Music/LunaticCultist"), ModContent.ItemType<CultistMusicBox>(), ModContent.TileType<Tiles.CultistMusicBox>());
		}

		public override void SetDefaults()
		{
			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTurn = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.autoReuse = true;
			Item.consumable = true;
			Item.createTile = ModContent.TileType<Tiles.CultistMusicBox>();
			Item.width = 24;
			Item.height = 24;
			Item.rare = ItemRarityID.LightRed;
			Item.value = 100000;
			Item.accessory = true;
		}

		public override bool? PrefixChance(int pre, UnifiedRandom rand)
		{
			if (this != null)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
	}
}

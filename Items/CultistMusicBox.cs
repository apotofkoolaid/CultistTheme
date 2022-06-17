using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Utilities;
using Terraria.GameContent.Creative;

namespace CultistTheme.Items
{
	public class CultistMusicBox : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Music Box (Lunatic Cultist)");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;

			MusicLoader.AddMusicBox(Mod, MusicLoader.GetMusicSlot(Mod, "Music/LunaticCultist"), ModContent.ItemType<Items.CultistMusicBox>(), ModContent.TileType<Tiles.CultistMusicBox>());
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
			Item.canBePlacedInVanityRegardlessOfConditions = true;
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

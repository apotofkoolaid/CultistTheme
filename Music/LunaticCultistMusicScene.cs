using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CultistTheme.Music
{
	public class LunaticCultistMusicScene : ModSceneEffect
	{
		//Enter the path to your music file here.
		//Avoid using .wav files since they're generally discouraged for use in Terraria modding.
		public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/LunaticCultist");

		//Enter the music priority here. Values are: BiomeLow, BiomeMedium, BiomeHigh, Environment, Event, BossLow, BossMedium, and BossHigh.
		public override SceneEffectPriority Priority => SceneEffectPriority.BossMedium;

		public override bool IsSceneEffectActive(Player player)
		{
			//Enter whatever conditions you're wanting for your song down below.
			return NPC.AnyNPCs(NPCID.CultistBoss) && Main.npc[NPC.FindFirstNPC(NPCID.CultistBoss)].Distance(player.Center) <= 8500f;
		}
	}
}

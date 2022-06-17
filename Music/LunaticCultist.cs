using Terraria;
using Terraria.ModLoader;

namespace CultistTheme.Music
{
	public class LunaticCultist : ModSceneEffect
	{
		//Enter the path to your music file here. Unlike in 1.3, the path doesn't have to begin with 'Sounds/Music' anymore.
		//Avoid using .wav files since tML doesn't loop them properly.
		public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/LunaticCultist");

		//Enter the music priority here. Values are identical to what they were in 1.3: BiomeLow, BiomeMedium, BiomeHigh, Environment, Event, BossLow, BossMedium, and BossHigh.
		public override SceneEffectPriority Priority => SceneEffectPriority.BossMedium;

		public override bool IsSceneEffectActive(Player player)
		{
			//Enter whatever conditions at which the song should play here.
			return NPC.AnyNPCs(439) && Main.npc[NPC.FindFirstNPC(439)].Distance(player.Center) <= 8500f;
		}
	}
}

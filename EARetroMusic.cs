using Terraria;
using Terraria.ModLoader;
using ElementsAwoken;

namespace EARetroMusic
{
	public class EARetroMusic : Mod
	{
        public static bool EALoaded = false;
        public EARetroMusic()
		{
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }
        public override void Load()
        {           
            EALoaded = ModLoader.GetMod("ElementsAwoken") != null;
        }
        public override void UpdateMusic(ref int music, ref MusicPriority priority)
        {
            if (EALoaded)
            {
                if (Main.myPlayer != -1 && !Main.gameMenu)
                {
                    if (Main.LocalPlayer.active && Main.invasionX == Main.spawnTileX && MyWorld.voidInvasionUp && ModContent.GetInstance<Config>().voidEventOldTheme)
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/VoidEventOLD");
                    }
                }
            }
        }
    }
}

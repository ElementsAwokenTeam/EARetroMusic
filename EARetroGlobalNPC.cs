using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EARetroMusic
{
    public class EARetroGlobalNPC : GlobalNPC
    {           
        public override void SetDefaults(NPC npc)
        {
            if (EARetroMusic.EALoaded)
            {
                Config conf = ModContent.GetInstance<Config>();
                Mod EAMod = ModLoader.GetMod("ElementsAwoken");
                if (conf.wastelandOldTheme)
                {
                    if (npc.type == EAMod.NPCType("Wasteland"))
                    {
                        npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/WastelandOLD");
                    }
                }
                if (conf.infernaceOldTheme)
                {
                    if (npc.type == EAMod.NPCType("Infernace"))
                    {
                        npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/InfernaceOLD");
                    }
                }
                if (conf.scourgeFighterOldTheme)
                {
                    if (npc.type == EAMod.NPCType("ScourgeFighter"))
                    {
                        npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/ScourgeFighterOLD");
                    }
                }
                if (conf.regarothOldTheme)
                {
                    if (npc.type == EAMod.NPCType("RegarothHead"))
                    {
                        npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/RegarothOLD");
                    }
                }
                if (conf.obsidiousOldTheme)
                {
                    if (npc.type == EAMod.NPCType("Obsidious"))
                    {
                        npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/ObsidiousOLD");
                    }
                }
                if (conf.permafrostOldTheme)
                {
                    if (npc.type == EAMod.NPCType("Permafrost"))
                    {
                        npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/PermafrostOLD");
                    }
                }
                if (conf.aqueousOldTheme)
                {
                    if (npc.type == EAMod.NPCType("Aqueous"))
                    {
                        npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/AqueousOLD");
                    }
                }
                if (conf.voidEventOldTheme)
                {
                    if (npc.type == EAMod.NPCType("ShadeWyrmHead"))
                    {
                        npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/VoidEventMinibossOLD");
                    }
                }
                if (conf.vleviOldTheme)
                {
                    if (npc.type == EAMod.NPCType("VoidLeviathanHead"))
                    {
                        npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/VoidLeviathanOLD");
                    }
                }
            }
        }
    }
}
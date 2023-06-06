using System;
using System.ComponentModel;
using System.IO;
using Terraria;
using Terraria.IO;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace EARetroMusic
{
    public class Config : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;
       
        [DefaultValue(true)]
        [Label("Old Wasteland Music")]
        [Tooltip("Replaces the current EA music with the old version")]
        public bool wastelandOldTheme { get; set; }

        [DefaultValue(true)]
        [Label("Old Infernace Music")]
        [Tooltip("Replaces the current EA music with the old version")]
        public bool infernaceOldTheme { get; set; }

        [DefaultValue(true)]
        [Label("Old Scourge Fighter Music")]
        [Tooltip("Replaces the current EA music with the old version")]
        public bool scourgeFighterOldTheme { get; set; }

        [DefaultValue(true)]
        [Label("Old Regaroth Music")]
        [Tooltip("Replaces the current EA music with the old version")]
        public bool regarothOldTheme { get; set; }

        [DefaultValue(true)]
        [Label("Old Obsidious Music")]
        [Tooltip("Replaces the current EA music with the old version")]
        public bool obsidiousOldTheme { get; set; }

        [DefaultValue(true)]
        [Label("Old Permafrost Music")]
        [Tooltip("Replaces the current EA music with the old version")]
        public bool permafrostOldTheme { get; set; }

        [DefaultValue(true)]
        [Label("Old Aqueous Music")]
        [Tooltip("Replaces the current EA music with the old version")]
        public bool aqueousOldTheme { get; set; }

        [DefaultValue(true)]
        [Label("Old Dawn of the Void Music")]
        [Tooltip("Replaces the current EA music with the old version")]
        public bool voidEventOldTheme { get; set; }

        [DefaultValue(true)]
        [Label("Old Void Leviathan Music")]
        [Tooltip("Replaces the current EA music with the old version")]
        public bool vleviOldTheme { get; set; }
    }
    /*
    public static class Config
    {
        public static bool wastelandOldTheme = true;
        public static bool infernaceOldTheme = true;
        public static bool scourgeFighterOldTheme = true;
        public static bool regarothOldTheme = true;
        public static bool obsidiousOldTheme = true;
        public static bool permafrostOldTheme = true;
        public static bool aqueousOldTheme = true;
        public static bool celestialOldTheme = true;
        public static bool voidEventOldTheme = true;
        public static bool voidEventMinibossOldTheme = true;

        static string ConfigPath = Path.Combine(Main.SavePath, "Mod Configs", "EA Retro Music Config.json");

        static Preferences Configuration = new Preferences(ConfigPath);

        public static void Load()
        {
            //Reading the config file
            bool success = ReadConfig();

            if (!success)
            {
                ErrorLogger.Log("Failed to read EA Retro Music's config file! Recreating config...");
                CreateConfig();
            }
        }

        static bool ReadConfig()
        {
            if (Configuration.Load())
            {
                Configuration.Get("Wasteland", ref wastelandOldTheme);
                Configuration.Get("Infernace", ref infernaceOldTheme);
                Configuration.Get("Scourge Fighter", ref scourgeFighterOldTheme);
                Configuration.Get("Regaroth", ref regarothOldTheme);
                Configuration.Get("Obsidious", ref obsidiousOldTheme);
                Configuration.Get("Permafrost", ref permafrostOldTheme);
                Configuration.Get("Aqueous", ref aqueousOldTheme);
                Configuration.Get("Celestial", ref celestialOldTheme);
                Configuration.Get("DotV", ref voidEventOldTheme);
                Configuration.Get("DotVMinibosses", ref voidEventMinibossOldTheme);
                return true;
            }
            return false;
        }

        static void CreateConfig()
        {
            Configuration.Clear();
            Configuration.Put("Wasteland", wastelandOldTheme);
            Configuration.Put("Infernace", infernaceOldTheme);
            Configuration.Put("Scourge Fighter", scourgeFighterOldTheme);
            Configuration.Put("Regaroth", regarothOldTheme);
            Configuration.Put("Obsidious", obsidiousOldTheme);
            Configuration.Put("Permafrost", permafrostOldTheme);
            Configuration.Put("Aqueous", aqueousOldTheme);
            Configuration.Put("Celestial", celestialOldTheme);
            Configuration.Put("DotV", voidEventOldTheme);
            Configuration.Put("DotVMinibosses", voidEventMinibossOldTheme);
            Configuration.Save();
        }
    }*/
}
using Verse;
using UnityEngine;
using HarmonyLib;

namespace Rooby_Roo_Flavour_Pack;

public class Rooby_Roo_Flavour_PackMod : Mod
{
    public static Settings settings;

    public Rooby_Roo_Flavour_PackMod(ModContentPack content) : base(content)
    {

        // initialize settings
        settings = GetSettings<Settings>();
#if DEBUG
        Harmony.DEBUG = true;
#endif
        Harmony harmony = new Harmony("Taggerung.rimworld.Rooby_Roo_Flavour_Pack.main");	
        harmony.PatchAll();
    }

    public override void DoSettingsWindowContents(Rect inRect)
    {
        base.DoSettingsWindowContents(inRect);
        settings.DoWindowContents(inRect);
    }

    public override string SettingsCategory()
    {
        return "Rooby Roo Flavour Pack_SettingsCategory".Translate();
    }
}

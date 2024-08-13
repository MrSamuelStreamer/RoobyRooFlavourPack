using RimWorld;
using Verse;

namespace Rooby_Roo_Flavour_Pack;

[DefOf]
public static class Rooby_Roo_Flavour_PackDefOf
{
    // Remember to annotate any Defs that require a DLC as needed e.g.
    // [MayRequireBiotech]
    // public static GeneDef YourPrefix_YourGeneDefName;
    
    static Rooby_Roo_Flavour_PackDefOf() => DefOfHelper.EnsureInitializedInCtor(typeof(Rooby_Roo_Flavour_PackDefOf));
}

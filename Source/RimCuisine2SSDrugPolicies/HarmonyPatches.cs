using HarmonyLib;
using RimWorld;
using Verse;

namespace RimCuisineSSDrugPolicies;

[StaticConstructorOnStartup]
public static class HarmonyPatches
{
    static HarmonyPatches()
    {
        var harmonyInstance = new Harmony("mehni.rimworld.rimCuisine.main");
        harmonyInstance.Patch(AccessTools.Method(typeof(Scenario), "PostGameStart"), null,
            new HarmonyMethod(typeof(HarmonyPatches), "GenerateStartingDrugPolicies_PostFix"));
    }

    private static void GenerateStartingDrugPolicies_PostFix()
    {
        foreach (var drugPolicy in Current.Game.drugPolicyDatabase.AllPolicies)
        {
            if (drugPolicy.label != "SocialDrugs".Translate())
            {
                continue;
            }

            drugPolicy[RCSSDefOf.RC2_Zope].allowedForJoy = true;
            drugPolicy[RCSSDefOf.RC2_Cigar].allowedForJoy = true;
            drugPolicy[RCSSDefOf.RC2_Cigarette].allowedForJoy = true;
        }
    }
}
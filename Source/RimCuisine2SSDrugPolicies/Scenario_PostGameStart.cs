using HarmonyLib;
using RimWorld;
using Verse;

namespace RimCuisineSSDrugPolicies;

[HarmonyPatch(typeof(Scenario), nameof(Scenario.PostGameStart))]
public static class Scenario_PostGameStart
{
    public static void Postfix()
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
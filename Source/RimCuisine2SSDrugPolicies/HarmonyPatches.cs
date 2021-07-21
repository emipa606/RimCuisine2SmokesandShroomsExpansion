using HarmonyLib;
using RimWorld;
using Verse;

namespace RimCuisineSSDrugPolicies
{
    // Token: 0x02000002 RID: 2
    [StaticConstructorOnStartup]
    public static class HarmonyPatches
    {
        // Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
        static HarmonyPatches()
        {
            var harmonyInstance = new Harmony("mehni.rimworld.rimCuisine.main");
            harmonyInstance.Patch(AccessTools.Method(typeof(Scenario), "PostGameStart"), null,
                new HarmonyMethod(typeof(HarmonyPatches), "GenerateStartingDrugPolicies_PostFix"));
        }

        // Token: 0x06000002 RID: 2 RVA: 0x000020A0 File Offset: 0x000002A0
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
}
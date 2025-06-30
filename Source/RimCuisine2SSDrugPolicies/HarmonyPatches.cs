using System.Reflection;
using HarmonyLib;
using Verse;

namespace RimCuisineSSDrugPolicies;

[StaticConstructorOnStartup]
public static class HarmonyPatches
{
    static HarmonyPatches()
    {
        new Harmony("mehni.rimworld.rimCuisine.main").PatchAll(Assembly.GetExecutingAssembly());
    }
}
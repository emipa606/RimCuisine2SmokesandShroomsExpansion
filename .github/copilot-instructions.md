# GitHub Copilot Instructions for RimCuisine 2: Smokes and Shrooms Expansion

## Mod Overview and Purpose

RimCuisine 2: Smokes and Shrooms Expansion is an expansion mod for RimWorld that adds a variety of new drugs for your pawns to binge on. The mod includes a range of new drugs such as Zopioids, tobacco, and other hallucinogens, which can be grown, refined, and consumed by your colonists.

## Key Features and Systems

### Drugs

- **Zopioids**: A variety of drugs derived from Dreamflower pods, including Zope, Skag, Viko, and Dreamsticks. These drugs provide pain relief but can lead to addiction, lack of energy, and tolerance.
- **Tobacco**: Tobacco can be grown in temperate biomes and refined into cigarettes or cigars. Pawns can become addicted to tobacco, requiring more frequent use over time.
- **Other Drugs**: Includes hallucinogens like Sunshine, Wake-Up, soldier pills, and Floxacine, each with unique effects.

### Crops

- **Dreamflower**: Used to make Zopioids.
- **Tobacco**: Grown in temperate biomes and used to make cigarettes and cigars.

### Techs

- Various new techs required to grow and refine new crops and produce new drugs.

## Coding Patterns and Conventions

### C# Files

- **RCSSDefOf.cs**: Defines constants for various game objects.
- **Scenario_PostGameStart.cs**: Contains postfix harmony patches for scenario-related code.
- **HarmonyPatches.cs**: Contains Harmony patches for various game functionalities.

### XML Integration

- **Defs**: XML files located in the `Defs` directory define various game objects such as drugs, crops, and techs.
- **Example XML File**: `RC2SS_Drugs_Tobacco.xml` defines tobacco-related items, including `ChemicalDef`, `hediffDef`, `NeedDef`, `ThingDef`, and `ThoughtDef`.

### Harmony Patching

- **HarmonyPatches.cs**: Contains methods that modify the behavior of existing game code using Harmony patches.

### Suggestions for Copilot

- Use Copilot to generate Harmony patches for existing game functionalities.
- Use Copilot to generate XML definitions for new game objects such as drugs, crops, and techs.
- Use Copilot to generate code for new features such as new drug policies or scenarios.

## Example Usage

### Generating Harmony Patches

csharp
// Example of a Harmony patch to modify the behavior of a game method
public static class HarmonyPatches
{
    [HarmonyPatch(typeof(ExistingGameClass), "MethodToPatch")]
    public static class Patch_MethodToPatch
    {
        public static void Postfix(ref int __result)
        {
            // Modify the result of the method
            __result += 10;
        }
    }
}


### Generating XML Definitions

xml
<!-- Example of an XML definition for a new drug -->
<ThingDef Name="RC2SS_Drug_Zope">
    <defName>RC2SS_Drug_Zope</defName>
    <label>Zope</label>
    <description>A base chemical derived from Dreamflower pods.</description>
    <category>Drugs</category>
    <thingCategories>
        <li>Drug</li>
    </thingCategories>
    <statBases>
        <li><stat>DrugEffect</stat><value>20</value></li>
        <li><stat>DrugAddictionRate</stat><value>0.05</value></li>
    </statBases>
</ThingDef>


## Conclusion

RimCuisine 2: Smokes and Shrooms Expansion is an exciting mod that adds a wide range of new drugs and crops to RimWorld. By following the coding patterns and conventions outlined in this document, you can effectively use GitHub Copilot to generate Harmony patches and XML definitions for your mod.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.


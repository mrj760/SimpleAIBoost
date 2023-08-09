using HarmonyLib;
using TaleWorlds.Library;
using TaleWorlds.MountAndBlade;

namespace aiboost.Patches
{
    [HarmonyPatch]
    public class ReduceAIMaxLevel
    {
        /* Set the Maximum Skill-Level for calculation to 260 instead of 350. This should make all AI stronger. */
        [HarmonyPrefix]
        [HarmonyPatch(typeof(AgentStatCalculateModel), "CalculateAILevel")]
        public static bool OverrideAILevelCalculation(ref AgentStatCalculateModel __instance,
            ref float __result, Agent agent, int relevantSkillLevel)
        {
            var diffmod = __instance.GetDifficultyModifier();
            __result = MBMath.ClampFloat((float)relevantSkillLevel / 260f * diffmod, 0.01f, diffmod);
            return false;
        }
    }
}



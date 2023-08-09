using HarmonyLib;
using TaleWorlds.MountAndBlade;

namespace aiboost
{
    public class Fix : MBSubModuleBase
    {
        protected override void OnSubModuleLoad()
        {
            // apply harmony patches
            var harmony = new Harmony("aiboost");
            harmony.PatchAll();
        }

    }
}

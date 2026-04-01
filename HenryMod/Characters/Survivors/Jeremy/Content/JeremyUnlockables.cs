using JeremyMod.Survivors.Jeremy.Achievements;
using RoR2;
using UnityEngine;

namespace JeremyMod.Survivors.Jeremy
{
    public static class JeremyUnlockables
    {
        public static UnlockableDef characterUnlockableDef = null;
        public static UnlockableDef masterySkinUnlockableDef = null;

        public static void Init()
        {
            // TODO: Unity throwing null reference exception somewhere in here
            masterySkinUnlockableDef = Modules.Content.CreateAndAddUnlockbleDef(
                JeremyMasteryAchievement.unlockableIdentifier,
                Modules.Tokens.GetAchievementNameToken(JeremyMasteryAchievement.identifier),
                JeremySurvivor.instance.assetBundle.LoadAsset<Sprite>("texMasteryAchievement"));
        }
    }
}

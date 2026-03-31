using JeremyMod.Survivors.Henry.Achievements;
using RoR2;
using UnityEngine;

namespace JeremyMod.Survivors.Henry
{
    public static class JeremyUnlockables
    {
        public static UnlockableDef characterUnlockableDef = null;
        public static UnlockableDef masterySkinUnlockableDef = null;

        public static void Init()
        {
            masterySkinUnlockableDef = Modules.Content.CreateAndAddUnlockbleDef(
                JeremyMasteryAchievement.unlockableIdentifier,
                Modules.Tokens.GetAchievementNameToken(JeremyMasteryAchievement.identifier),
                JeremySurvivor.instance.assetBundle.LoadAsset<Sprite>("texMasteryAchievement"));
        }
    }
}

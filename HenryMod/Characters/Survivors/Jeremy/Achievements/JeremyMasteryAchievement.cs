using RoR2;
using JeremyMod.Modules.Achievements;

namespace JeremyMod.Survivors.Henry.Achievements
{
    //automatically creates language tokens "ACHIEVMENT_{identifier.ToUpper()}_NAME" and "ACHIEVMENT_{identifier.ToUpper()}_DESCRIPTION" 
    [RegisterAchievement(identifier, unlockableIdentifier, null, 10, null)]
    public class JeremyMasteryAchievement : BaseMasteryAchievement
    {
        public const string identifier = JeremySurvivor.HENRY_PREFIX + "masteryAchievement";
        public const string unlockableIdentifier = JeremySurvivor.HENRY_PREFIX + "masteryUnlockable";

        public override string RequiredCharacterBody => JeremySurvivor.instance.bodyName;

        //difficulty coeff 3 is monsoon. 3.5 is typhoon for grandmastery skins
        public override float RequiredDifficultyCoefficient => 3;
    }
}
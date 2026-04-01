using RoR2;
using JeremyMod.Modules.Achievements;

namespace JeremyMod.Survivors.Jeremy.Achievements
{
    //automatically creates language tokens "ACHIEVMENT_{identifier.ToUpper()}_NAME" and "ACHIEVMENT_{identifier.ToUpper()}_DESCRIPTION" 
    [RegisterAchievement(identifier, unlockableIdentifier, null, 10, null)]
    public class JeremyMasteryAchievement : BaseMasteryAchievement
    {
        public const string identifier = JeremySurvivor.JEREMY_PREFIX + "masteryAchievement";
        public const string unlockableIdentifier = JeremySurvivor.JEREMY_PREFIX + "masteryUnlockable";

        public override string RequiredCharacterBody => JeremySurvivor.instance.bodyName;

        //difficulty coeff 3 is monsoon. 3.5 is typhoon for grandmastery skins
        public override float RequiredDifficultyCoefficient => 3;
    }
}
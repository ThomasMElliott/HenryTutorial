using System;
using JeremyMod.Modules;
using JeremyMod.Survivors.Jeremy.Achievements;

namespace JeremyMod.Survivors.Jeremy
{
    public static class JeremyTokens
    {
        public static void Init()
        {
            AddJeremyTokens();

            ////uncomment this to spit out a lanuage file with all the above tokens that people can translate
            ////make sure you set Language.usingLanguageFolder and printingEnabled to true
            //Language.PrintOutput("Henry.txt");
            ////refer to guide on how to build and distribute your mod with the proper folders
        }

        public static void AddJeremyTokens()
        {
            string prefix = JeremySurvivor.JEREMY_PREFIX;

            string desc = "Jeremy is a skilled fighter who makes use of a wide arsenal of weaponry to take down his foes.<color=#CCD3E0>" + Environment.NewLine + Environment.NewLine
             + "< ! > Sword is a good all-rounder while Boxing Gloves are better for laying a beatdown on more powerful foes." + Environment.NewLine + Environment.NewLine
             + "< ! > Pistol is a powerful anti air, with its low cooldown and high damage." + Environment.NewLine + Environment.NewLine
             + "< ! > Roll has a lingering armor buff that helps to use it aggressively." + Environment.NewLine + Environment.NewLine
             + "< ! > Bomb can be used to wipe crowds with ease." + Environment.NewLine + Environment.NewLine;

            string outro = "..and so he left, setting off on a search for himself once again.";
            string outroFailure = "..and so he vanished, forever a blank slate.";

            Language.Add(prefix + "NAME", "Jeremy");
            Language.Add(prefix + "DESCRIPTION", desc);
            Language.Add(prefix + "SUBTITLE", "The Chosen One");
            Language.Add(prefix + "LORE", "Jeremy the frickin' GOAT fr but not really");
            Language.Add(prefix + "OUTRO_FLAVOR", outro);
            Language.Add(prefix + "OUTRO_FAILURE", outroFailure);

            #region Skins
            Language.Add(prefix + "MASTERY_SKIN_NAME", "Master");
            #endregion

            #region Passive
            Language.Add(prefix + "PASSIVE_NAME", "Jeremy passive");
            Language.Add(prefix + "PASSIVE_DESCRIPTION", "Is Jeremy");
            #endregion

            #region Primary
            Language.Add(prefix + "PRIMARY_SLASH_NAME", "Sword");
            Language.Add(prefix + "PRIMARY_SLASH_DESCRIPTION", Tokens.agilePrefix + $"Swing forward for <style=cIsDamage>{100f * JeremyStaticValues.swordDamageCoefficient}% damage</style>.");
            #endregion

            #region Secondary
            Language.Add(prefix + "SECONDARY_GUN_NAME", "Handgun");
            Language.Add(prefix + "SECONDARY_GUN_DESCRIPTION", Tokens.agilePrefix + $" Fire a handgun for <style=cIsDamage>{100f * JeremyStaticValues.gunDamageCoefficient}% damage</style>.");

            Language.Add(prefix + "SECONDARY_UZI_NAME", "Uzi");
            Language.Add(prefix + "SECONDARY_UZI_DESCRIPTION", Tokens.agilePrefix + $" Fire an Uzi for <style=cIsDamage>{100f * JeremyStaticValues.gunDamageCoefficient}% damage</style> multiple times.");
            #endregion

            #region Utility
            Language.Add(prefix + "UTILITY_ROLL_NAME", "Roll");
            Language.Add(prefix + "UTILITY_ROLL_DESCRIPTION", "Roll a short distance, gaining <style=cIsUtility>300 armor</style>. <style=cIsUtility>You cannot be hit during the roll.</style>");
            #endregion

            #region Special
            Language.Add(prefix + "SPECIAL_BOMB_NAME", "Bomb");
            Language.Add(prefix + "SPECIAL_BOMB_DESCRIPTION", $"Throw a bomb for <style=cIsDamage>{100f * JeremyStaticValues.bombDamageCoefficient}% damage</style>.");
            #endregion

            #region Achievements
            Language.Add(Tokens.GetAchievementNameToken(JeremyMasteryAchievement.identifier), "Jeremy: Mastery");
            Language.Add(Tokens.GetAchievementDescriptionToken(JeremyMasteryAchievement.identifier), "As Jeremy, beat the game or obliterate on Monsoon.");
            #endregion
        }
    }
}

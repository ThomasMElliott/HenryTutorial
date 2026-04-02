using JeremyMod.Survivors.Jeremy.SkillStates;

namespace JeremyMod.Survivors.Jeremy
{
    public static class JeremyStates
    {
        public static void Init()
        {
            Modules.Content.AddEntityState(typeof(SlashCombo));

            Modules.Content.AddEntityState(typeof(Shoot));

            Modules.Content.AddEntityState(typeof(Roll));

            Modules.Content.AddEntityState(typeof(ThrowBomb));

            // My new one
            Modules.Content.AddEntityState(typeof(Spray));
        }
    }
}

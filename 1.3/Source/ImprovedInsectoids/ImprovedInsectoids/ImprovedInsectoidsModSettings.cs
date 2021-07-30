using Verse;

namespace ImprovedInsectoids
{
    public class ImprovedInsectoidsModSettings : ModSettings
    {
        public bool fearAffectsPlayerFaction = true;

        /// <summary>
        /// Saves and loads settings.
        /// </summary>
        public override void ExposeData()
        {
            base.ExposeData();

            Scribe_Values.Look(ref fearAffectsPlayerFaction, "fearAffectsPlayerFaction", true, false);
        }
    }
}

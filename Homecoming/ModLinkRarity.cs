using HarmonyLib;
using PhantomBrigade.Data;
using PhantomBrigade.Mods;
using System.Collections.Generic;

namespace Homecoming.Module.Rarity
{
    public class ModLinkRarity : ModLink
    {
        public override void OnLoad(Harmony harmonyInstance)
        {
            base.OnLoad(harmonyInstance);
            ReflectionRarityUIHelper.AccessPrivateMember();
        }
    }


    public static class ReflectionRarityUIHelper
    {
        public static void AccessPrivateMember()
        {
            var t = Traverse.Create(typeof(DataHelperEquipment));
            var suffixes = t.Field<Dictionary<int, string>>("suffixesDeveloperRarity").Value;

            suffixes.Add(4, " [A666B3][99]+++[ff]");
            suffixes.Add(5, " [E6331A][99]E[ff]");
            suffixes.Add(6, " [E6B31A][99]*[ff]");
        }
    }    
}

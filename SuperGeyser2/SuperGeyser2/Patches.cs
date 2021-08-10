using HarmonyLib;

namespace SuperGeyser2
{
    public class Patches
    {
        [HarmonyPatch(typeof(Db))]
        [HarmonyPatch("Initialize")]
        public class Db_Initialize_Patch
        {
            public static void Prefix()
            {
                Debug.Log("I execute before Db.Initialize! superGeyser");
            }

            public static void Postfix()
            {
                Debug.Log("I execute after Db.Initialize! superGeyser");
            }
        }
    }
}

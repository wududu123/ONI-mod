using HarmonyLib;

namespace ONI_Mod1
{
    public class Patches
    {
        [HarmonyPatch(typeof(Db))]
        [HarmonyPatch("Initialize")]
        public class Db_Initialize_Patch
        {
            public static void Prefix()
            {
                Debug.Log("I execute before Db.Initialize xwl!1");
            }

            public static void Postfix()
            {
                Debug.Log("I execute after Db.Initialize xwl!");
            }
        }
    }
}

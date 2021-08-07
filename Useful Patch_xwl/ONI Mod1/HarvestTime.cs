// Decompiled with JetBrains decompiler
// Type: Useful_Patch.HarvestTime
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;

namespace Useful_Patch
{
  internal class HarvestTime
  {
    [HarmonyPatch(typeof (Harvestable), "OnSpawn")]
    public class harvest_time_short
    {
      public static void Postfix(Workable __instance) => __instance.SetWorkTime(1f);
    }
  }
}

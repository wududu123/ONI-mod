// Decompiled with JetBrains decompiler
// Type: Useful_Patch._3Batteries
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using UnityEngine;

namespace Useful_Patch
{
  internal class _3Batteries
  {
    [HarmonyPatch(typeof (BatteryConfig), "DoPostConfigureComplete")]
    public class BatteryUp
    {
      public static void Postfix(GameObject go) => go.AddOrGet<Battery>().capacity = 200000f;
    }

    [HarmonyPatch(typeof (BatteryMediumConfig), "DoPostConfigureComplete")]
    public class BatteryMediumUp
    {
      public static void Postfix(GameObject go) => go.AddOrGet<Battery>().capacity = 400000f;
    }

    [HarmonyPatch(typeof (BatterySmartConfig), "DoPostConfigureComplete")]
    public class BatterySmartUp
    {
      public static void Postfix(GameObject go) => go.AddOrGet<Battery>().capacity = 800000f;
    }
  }
}

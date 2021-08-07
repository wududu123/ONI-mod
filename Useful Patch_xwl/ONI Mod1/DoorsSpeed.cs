// Decompiled with JetBrains decompiler
// Type: Useful_Patch.DoorsSpeed
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using UnityEngine;

namespace Useful_Patch
{
  internal class DoorsSpeed
  {
    [HarmonyPatch(typeof (BunkerDoorConfig), "DoPostConfigureComplete")]
    public class BunkerDoorConfigUp
    {
      public static void Postfix(GameObject go)
      {
        go.AddOrGet<Door>().unpoweredAnimSpeed = 0.1f;
        go.AddOrGet<Door>().poweredAnimSpeed = 1f;
        go.AddOrGet<Workable>().workTime = 1f;
      }
    }

    [HarmonyPatch(typeof (ManualPressureDoorConfig), "DoPostConfigureComplete")]
    public class ManualPressureDoorConfigUp
    {
      public static void Postfix(GameObject go) => go.AddOrGet<Workable>().workTime = 3f;
    }

    [HarmonyPatch(typeof (POIFacilityDoorConfig), "DoPostConfigureComplete")]
    public class POIFacilityDoorConfigUp
    {
      public static void Postfix(GameObject go) => go.AddOrGet<Workable>().workTime = 3f;
    }

    [HarmonyPatch(typeof (PressureDoorConfig), "DoPostConfigureComplete")]
    public class PressureDoorConfigUp
    {
      public static void Postfix(GameObject go)
      {
        go.AddOrGet<Door>().unpoweredAnimSpeed = 1f;
        go.AddOrGet<Workable>().workTime = 2f;
      }
    }
  }
}

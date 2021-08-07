// Decompiled with JetBrains decompiler
// Type: Useful_Patch.Cargo
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using UnityEngine;

namespace Useful_Patch
{
  internal class Cargo
  {
    //[HarmonyPatch(typeof (CargoBayConfig), "DoPostConfigureComplete")]
    //public class CargoBaycapacityKgUp
    //{
    //  public static void Postfix(GameObject go) => go.AddOrGet<CargoBay>().storage.capacityKg = 10000f;
    //}

    [HarmonyPatch(typeof (GasCargoBayConfig), "DoPostConfigureComplete")]
    public class GasCargoBaycapacityKgUp
    {
      public static void Postfix(GameObject go) => go.AddOrGet<CargoBay>().storage.capacityKg = 10000f;
    }

    [HarmonyPatch(typeof (LiquidCargoBayConfig), "DoPostConfigureComplete")]
    public class LiquidCargoBaycapacityKgUp
    {
      public static void Postfix(GameObject go) => go.AddOrGet<CargoBay>().storage.capacityKg = 10000f;
    }
  }
}

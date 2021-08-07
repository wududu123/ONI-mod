// Decompiled with JetBrains decompiler
// Type: Useful_Patch.Spaceheater
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using UnityEngine;

namespace Useful_Patch
{
  internal class Spaceheater
  {
    [HarmonyPatch(typeof (SpaceHeaterConfig), "CreateBuildingDef")]
    public class SpaceheaterbuildingDefUp
    {
      public static void Postfix(BuildingDef __result)
      {
        __result.ExhaustKilowattsWhenActive = 2000f;
        __result.OverheatTemperature = 478.15f;
        __result.ThermalConductivity *= 10f;
      }
    }

    [HarmonyPatch(typeof (SpaceHeaterConfig), "ConfigureBuildingTemplate")]
    public class SpaceheaterUp
    {
      public static void Postfix(GameObject go) => go.AddOrGet<SpaceHeater>().targetTemperature = 473.15f;
    }

    [HarmonyPatch(typeof (SpaceHeater), "MonitorHeating")]
    public class Range
    {
      public int radius = 6;
    }
  }
}

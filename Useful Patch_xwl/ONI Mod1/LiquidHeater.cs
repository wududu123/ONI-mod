// Decompiled with JetBrains decompiler
// Type: Useful_Patch.LiquidHeater
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using UnityEngine;

namespace Useful_Patch
{
  internal class LiquidHeater
  {
    [HarmonyPatch(typeof (LiquidHeaterConfig), "CreateBuildingDef")]
    public class LiquidHeaterConfig1Up
    {
      public static void Postfix(BuildingDef __result)
      {
        __result.EnergyConsumptionWhenActive = 96f;
        __result.ThermalConductivity *= 10f;
      }
    }

    [HarmonyPatch(typeof (LiquidHeaterConfig), "ConfigureBuildingTemplate")]
    public class LiquidHeaterConfig2Up
    {
      public static void Postfix(GameObject go) => go.AddOrGet<SpaceHeater>().minimumCellMass = 0.0f;
    }
  }
}

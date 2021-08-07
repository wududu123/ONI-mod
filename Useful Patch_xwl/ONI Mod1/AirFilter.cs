// Decompiled with JetBrains decompiler
// Type: Useful_Patch.AirFilter
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using UnityEngine;

namespace Useful_Patch
{
  internal class AirFilter
  {
    [HarmonyPatch(typeof (AirFilterConfig), "CreateBuildingDef")]
    public class AirFilterbuildingDefUp
    {
      public static void Postfix(BuildingDef __result) => __result.PermittedRotations = PermittedRotations.R360;
    }

    [HarmonyPatch(typeof (AirFilterConfig), "ConfigureBuildingTemplate")]
    public class AirFilterRangeUp
    {
      public static void Postfix(GameObject go) => go.AddOrGet<ElementConsumer>().consumptionRadius = (byte) 10;
    }
  }
}

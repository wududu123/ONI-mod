// Decompiled with JetBrains decompiler
// Type: Useful_Patch.FourValve
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using UnityEngine;

namespace Useful_Patch
{
  internal class FourValve
  {
    [HarmonyPatch(typeof (LiquidValveConfig), "ConfigureBuildingTemplate")]
    public class LiquidValveConfigUp
    {
      public static void Postfix(GameObject go) => go.AddOrGet<ValveBase>().maxFlow = 100f;
    }

    [HarmonyPatch(typeof (GasValveConfig), "ConfigureBuildingTemplate")]
    public class GasValveConfigUp
    {
      public static void Postfix(GameObject go) => go.AddOrGet<ValveBase>().maxFlow = 5f;
    }

    [HarmonyPatch(typeof (LiquidLogicValveConfig), "ConfigureBuildingTemplate")]
    public class LiquidLogicValveConfigUp
    {
      public static void Postfix(GameObject go) => go.AddOrGet<OperationalValve>().maxFlow = 100f;
    }

    [HarmonyPatch(typeof (GasLogicValveConfig), "ConfigureBuildingTemplate")]
    public class GasLogicValveConfigUp
    {
      public static void Postfix(GameObject go) => go.AddOrGet<OperationalValve>().maxFlow = 5f;
    }
  }
}

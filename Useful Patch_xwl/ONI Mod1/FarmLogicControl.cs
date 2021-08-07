// Decompiled with JetBrains decompiler
// Type: Useful_Patch.FarmLogicControl
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using UnityEngine;

namespace Useful_Patch
{
  internal class FarmLogicControl
  {
    [HarmonyPatch(typeof (PlanterBoxConfig), "CreateBuildingDef")]
    public class PlanterBoxConfigUp
    {
      public static void Postfix(BuildingDef __result) => __result.LogicInputPorts = LogicOperationalController.CreateSingleInputPortList(new CellOffset(0, 0));
    }

    [HarmonyPatch(typeof (PlanterBoxConfig), "DoPostConfigureComplete")]
    public class PlanterBoxConfigUp_Logic
    {
      public static void Postfix(GameObject go) => go.AddOrGet<LogicOperationalController>();
    }

    [HarmonyPatch(typeof (FarmTileConfig), "CreateBuildingDef")]
    public class FarmTileConfigUp
    {
      public static void Postfix(BuildingDef __result) => __result.LogicInputPorts = LogicOperationalController.CreateSingleInputPortList(new CellOffset(0, 0));
    }

    [HarmonyPatch(typeof (FarmTileConfig), "DoPostConfigureComplete")]
    public class FarmTileConfigUp_Logic
    {
      public static void Postfix(GameObject go) => go.AddOrGet<LogicOperationalController>();
    }

    [HarmonyPatch(typeof (HydroponicFarmConfig), "CreateBuildingDef")]
    public class HydroponicFarmConfigUp
    {
      public static void Postfix(BuildingDef __result) => __result.LogicInputPorts = LogicOperationalController.CreateSingleInputPortList(new CellOffset(0, 0));
    }

    [HarmonyPatch(typeof (HydroponicFarmConfig), "DoPostConfigureComplete")]
    public class HydroponicFarmConfigUp_Logic
    {
      public static void Postfix(GameObject go) => go.AddOrGet<LogicOperationalController>();
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Useful_Patch.ThermalConductivity
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;

namespace Useful_Patch
{
  internal class ThermalConductivity
  {
    [HarmonyPatch(typeof (GasConduitRadiantConfig), "CreateBuildingDef")]
    private class Useful_Patch_GasConduitRadiantConfig
    {
      private static void Postfix(BuildingDef __result) => __result.ThermalConductivity *= 10f;
    }

    [HarmonyPatch(typeof (LiquidConduitRadiantConfig), "CreateBuildingDef")]
    private class Useful_Patch_LiquidConduitRadiantConfig
    {
      private static void Postfix(BuildingDef __result) => __result.ThermalConductivity *= 10f;
    }

    [HarmonyPatch(typeof (ThermalBlockConfig), "CreateBuildingDef")]
    private class Useful_Patch_ThermalBlockConfig
    {
      private static void Postfix(BuildingDef __result) => __result.ThermalConductivity *= 10f;
    }

    [HarmonyPatch(typeof (MetalTileConfig), "CreateBuildingDef")]
    private class Useful_Patch_MetalTileConfig
    {
      private static void Postfix(BuildingDef __result) => __result.ThermalConductivity *= 10f;
    }

    [HarmonyPatch(typeof (InsulatedGasConduitConfig), "CreateBuildingDef")]
    private class Useful_Patch_InsulatedGasConduitConfig
    {
      private static void Postfix(BuildingDef __result) => __result.ThermalConductivity *= 0.1f;
    }

    [HarmonyPatch(typeof (InsulatedLiquidConduitConfig), "CreateBuildingDef")]
    private class Useful_Patch_InsulatedLiquidConduitConfig
    {
      private static void Postfix(BuildingDef __result) => __result.ThermalConductivity *= 0.1f;
    }

    [HarmonyPatch(typeof (InsulationTileConfig), "CreateBuildingDef")]
    private class Useful_Patch_InsulationTileConfig
    {
      private static void Postfix(BuildingDef __result) => __result.ThermalConductivity *= 0.1f;
    }
  }
}

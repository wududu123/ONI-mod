// Decompiled with JetBrains decompiler
// Type: Useful_Patch._3ThingsNoSelfHeat
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;

namespace Useful_Patch
{
  internal class _3ThingsNoSelfHeat
  {
    [HarmonyPatch(typeof (SolidTransferArmConfig), "CreateBuildingDef")]
    public class SolidTransferArmbuildingDefUp
    {
      public static void Postfix(BuildingDef __result) => __result.SelfHeatKilowattsWhenActive = 0.0f;
    }

    [HarmonyPatch(typeof (AutoMinerConfig), "CreateBuildingDef")]
    public class AutoMinerbuildingDefUp
    {
      public static void Postfix(BuildingDef __result) => __result.SelfHeatKilowattsWhenActive = 0.0f;
    }

    [HarmonyPatch(typeof (SolidConduitInboxConfig), "CreateBuildingDef")]
    public class SolidConduitInboxbuildingDefUp
    {
      public static void Postfix(BuildingDef __result) => __result.SelfHeatKilowattsWhenActive = 0.0f;
    }
  }
}

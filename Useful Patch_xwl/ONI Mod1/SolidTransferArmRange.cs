// Decompiled with JetBrains decompiler
// Type: Useful_Patch.SolidTransferArmRange
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using UnityEngine;

namespace Useful_Patch
{
  internal class SolidTransferArmRange
  {
    [HarmonyPatch(typeof (SolidTransferArmConfig), "AddVisualizer")]
    public class SolidTransferArmConfigUp_ShowRange
    {
      public static void Postfix(GameObject prefab, bool movable)
      {
        StationaryChoreRangeVisualizer choreRangeVisualizer = prefab.AddOrGet<StationaryChoreRangeVisualizer>();
        choreRangeVisualizer.x = -Configurations.GetConfig().solidtransferarmpickupRange.Value;
        choreRangeVisualizer.y = -Configurations.GetConfig().solidtransferarmpickupRange.Value;
        choreRangeVisualizer.width = Configurations.GetConfig().solidtransferarmpickupRange.Value * 2 + 1;
        choreRangeVisualizer.height = Configurations.GetConfig().solidtransferarmpickupRange.Value * 2 + 1;
        choreRangeVisualizer.movable = movable;
      }
    }

    [HarmonyPatch(typeof (SolidTransferArmConfig), "DoPostConfigureComplete")]
    public class SolidTransferArmConfigUp_Range
    {
      public static void Postfix(GameObject go) => go.AddOrGet<SolidTransferArm>().pickupRange = Configurations.GetConfig().solidtransferarmpickupRange.Value;
    }

    [HarmonyPatch(typeof (Grid), "IsPhysicallyAccessible")]
    internal class SolidTransferArm_Grid_IsPhysicallyAccessible
    {
      private static bool Prefix(ref bool __result)
      {
        if (Configurations.GetConfig().IsPhysicallyAccessible.Value != 1)
          return true;
        __result = true;
        return false;
      }
    }
  }
}

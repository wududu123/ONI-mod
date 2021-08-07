// Decompiled with JetBrains decompiler
// Type: Useful_Patch.AutoMiner_Range_Strength
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using UnityEngine;

namespace Useful_Patch
{
  internal class AutoMiner_Range_Strength
  {
    [HarmonyPatch(typeof (AutoMinerConfig), "DoPostConfigureComplete")]
    public class AutoMinerConfig1Up
    {
      public static void Postfix(GameObject go)
      {
        AutoMiner autoMiner = go.AddOrGet<AutoMiner>();
        autoMiner.x = -15;
        autoMiner.y = 0;
        autoMiner.width = 32;
        autoMiner.height = 18;
      }
    }

    [HarmonyPatch(typeof (AutoMinerConfig), "AddVisualizer")]
    public class AutoMinerConfig2Up
    {
      public static void Postfix(GameObject prefab)
      {
        StationaryChoreRangeVisualizer choreRangeVisualizer = prefab.AddOrGet<StationaryChoreRangeVisualizer>();
        choreRangeVisualizer.x = -15;
        choreRangeVisualizer.y = 0;
        choreRangeVisualizer.width = 32;
        choreRangeVisualizer.height = 18;
      }
    }
  }
}

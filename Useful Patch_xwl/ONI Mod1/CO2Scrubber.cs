// Decompiled with JetBrains decompiler
// Type: Useful_Patch.CO2Scrubber
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using UnityEngine;

namespace Useful_Patch
{
  internal class CO2Scrubber
  {
    [HarmonyPatch(typeof (CO2ScrubberConfig), "ConfigureBuildingTemplate")]
    public class AirFilterRangeUp
    {
      public static void Postfix(GameObject go) => go.AddOrGet<ElementConsumer>().consumptionRadius = (byte) 10;
    }
  }
}

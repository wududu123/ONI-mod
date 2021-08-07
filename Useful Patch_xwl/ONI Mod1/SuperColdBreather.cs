// Decompiled with JetBrains decompiler
// Type: Useful_Patch.SuperColdBreather
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using UnityEngine;

namespace Useful_Patch
{
  internal class SuperColdBreather
  {
    [HarmonyPatch(typeof (ColdBreatherConfig), "CreatePrefab")]
    public class Useful_Patch_ColdBreatherConfig
    {
      public static void Postfix(GameObject __result)
      {
        __result.AddOrGet<ColdBreather>().deltaEmitTemperature = -20f;
        __result.AddOrGet<TemperatureVulnerable>().Configure(3.15f, 183.15f, 368.15f, 2463.15f);
        ElementConsumer elementConsumer = __result.AddOrGet<ElementConsumer>();
        elementConsumer.capacityKG = 20f;
        elementConsumer.consumptionRate = 10f;
        elementConsumer.consumptionRadius = (byte) 5;
      }
    }
  }
}

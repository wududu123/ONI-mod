// Decompiled with JetBrains decompiler
// Type: Useful_Patch.PumpsConfig
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using UnityEngine;

namespace Useful_Patch
{
  internal class PumpsConfig
  {
    [HarmonyPatch(typeof (GasPumpConfig), "DoPostConfigureComplete")]
    public class GasPumpConfigUp
    {
      public static void Postfix(GameObject go)
      {
        go.AddOrGet<Storage>().capacityKg = 50f;
        go.AddOrGet<ElementConsumer>().consumptionRate = 2.5f;
        go.AddOrGet<ElementConsumer>().consumptionRadius = (byte) 5;
      }
    }

    [HarmonyPatch(typeof (GasMiniPumpConfig), "DoPostConfigureComplete")]
    public class GasMiniPumpConfigUp
    {
      public static void Postfix(GameObject go)
      {
        go.AddOrGet<Storage>().capacityKg = 10f;
        go.AddOrGet<ElementConsumer>().consumptionRate = 0.5f;
        go.AddOrGet<ElementConsumer>().consumptionRadius = (byte) 5;
      }
    }

    [HarmonyPatch(typeof (LiquidPumpConfig), "DoPostConfigureComplete")]
    public class LiquidPumpConfigUp
    {
      public static void Postfix(GameObject go)
      {
        go.AddOrGet<Storage>().capacityKg = 100f;
        go.AddOrGet<ElementConsumer>().consumptionRate = 50f;
        go.AddOrGet<ElementConsumer>().consumptionRadius = (byte) 5;
      }
    }

    [HarmonyPatch(typeof (LiquidMiniPumpConfig), "DoPostConfigureComplete")]
    public class LiquidMiniPumpConfigUp
    {
      public static void Postfix(GameObject go)
      {
        go.AddOrGet<Storage>().capacityKg = 20f;
        go.AddOrGet<ElementConsumer>().consumptionRate = 10f;
        go.AddOrGet<ElementConsumer>().consumptionRadius = (byte) 5;
      }
    }
  }
}

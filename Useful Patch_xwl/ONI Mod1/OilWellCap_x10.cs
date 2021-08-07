// Decompiled with JetBrains decompiler
// Type: Useful_Patch.OilWellCap_x10
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using UnityEngine;

namespace Useful_Patch
{
  internal class OilWellCap_x10
  {
    [HarmonyPatch(typeof (OilWellCapConfig), "ConfigureBuildingTemplate")]
    public class OilWellCapConfigUp
    {
      public static void Postfix(GameObject go)
      {
        ConduitConsumer conduitConsumer = go.AddOrGet<ConduitConsumer>();
        conduitConsumer.consumptionRate = 10f;
        conduitConsumer.capacityKG = 10f;
        ElementConverter elementConverter = go.AddOrGet<ElementConverter>();
        elementConverter.consumedElements = new ElementConverter.ConsumedElement[1]
        {
          new ElementConverter.ConsumedElement(new Tag("Water"), 10f)
        };
        elementConverter.outputElements = new ElementConverter.OutputElement[1]
        {
          new ElementConverter.OutputElement(33.33333f, SimHashes.CrudeOil, 363.15f, outputElementOffsetx: 2f, outputElementOffsety: 1.5f, diseaseWeight: 0.0f)
        };
        OilWellCap oilWellCap = go.AddOrGet<OilWellCap>();
        oilWellCap.gasElement = SimHashes.Methane;
        oilWellCap.gasTemperature = 573.15f;
        oilWellCap.addGasRate = 0.3333333f;
        oilWellCap.maxGasPressure = 80.00001f;
        oilWellCap.releaseGasRate = 0.4444445f;
      }
    }
  }
}

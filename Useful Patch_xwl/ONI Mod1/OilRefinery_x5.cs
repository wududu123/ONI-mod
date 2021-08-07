// Decompiled with JetBrains decompiler
// Type: Useful_Patch.OilRefinery_x5
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using UnityEngine;

namespace Useful_Patch
{
  internal class OilRefinery_x5
  {
    [HarmonyPatch(typeof (OilRefineryConfig), "ConfigureBuildingTemplate")]
    public class OilRefineryConfigUp
    {
      public static void Postfix(GameObject go)
      {
        go.AddOrGet<ConduitConsumer>().consumptionRate = 100f;
        ElementConverter elementConverter = go.AddOrGet<ElementConverter>();
        elementConverter.consumedElements = new ElementConverter.ConsumedElement[1]
        {
          new ElementConverter.ConsumedElement(SimHashes.CrudeOil.CreateTag(), 50f)
        };
        elementConverter.outputElements = new ElementConverter.OutputElement[2]
        {
          new ElementConverter.OutputElement(25f, SimHashes.Petroleum, 348.15f, storeOutput: true, outputElementOffsety: 1f),
          new ElementConverter.OutputElement(0.45f, SimHashes.Methane, 348.15f, outputElementOffsety: 3f)
        };
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Useful_Patch.Polymerizer
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using UnityEngine;

namespace Useful_Patch
{
  internal class Polymerizer
  {
    [HarmonyPatch(typeof (PolymerizerConfig), "ConfigureBuildingTemplate")]
    public class PolymerizerConfigUp
    {
      public static void Postfix(GameObject go)
      {
        ConduitConsumer conduitConsumer = go.AddOrGet<ConduitConsumer>();
        conduitConsumer.consumptionRate = 16.66667f;
        conduitConsumer.capacityKG = 16.66667f;
        ElementConverter elementConverter = go.AddOrGet<ElementConverter>();
        elementConverter.consumedElements = new ElementConverter.ConsumedElement[1]
        {
          new ElementConverter.ConsumedElement(GameTagExtensions.Create(SimHashes.Petroleum), 8.333333f)
        };
        elementConverter.outputElements = new ElementConverter.OutputElement[3]
        {
          new ElementConverter.OutputElement(5f, SimHashes.Polypropylene, 348.15f, storeOutput: true),
          new ElementConverter.OutputElement(0.08333334f, SimHashes.Steam, 473.15f, storeOutput: true),
          new ElementConverter.OutputElement(0.08333334f, SimHashes.CarbonDioxide, 423.15f, storeOutput: true)
        };
      }
    }
  }
}

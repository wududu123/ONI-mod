// Decompiled with JetBrains decompiler
// Type: Useful_Patch.OxyliteRefinery
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using UnityEngine;

namespace Useful_Patch
{
  internal class OxyliteRefinery
  {
    [HarmonyPatch(typeof (OxyliteRefineryConfig), "ConfigureBuildingTemplate")]
    public class OxyliteRefineryConfigUp
    {
      public static void Postfix(GameObject go)
      {
        Tag tag1 = SimHashes.Oxygen.CreateTag();
        Tag tag2 = SimHashes.Gold.CreateTag();
        ConduitConsumer conduitConsumer = go.AddOrGet<ConduitConsumer>();
        conduitConsumer.consumptionRate = 2.4f;
        conduitConsumer.capacityKG = 18f;
        ElementConverter elementConverter = go.AddOrGet<ElementConverter>();
        elementConverter.consumedElements = new ElementConverter.ConsumedElement[2]
        {
          new ElementConverter.ConsumedElement(tag1, 6f),
          new ElementConverter.ConsumedElement(tag2, 0.03f)
        };
        elementConverter.outputElements = new ElementConverter.OutputElement[1]
        {
          new ElementConverter.OutputElement(6f, SimHashes.OxyRock, 303.15f, storeOutput: true)
        };
      }
    }
  }
}

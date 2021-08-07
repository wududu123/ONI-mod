// Decompiled with JetBrains decompiler
// Type: Useful_Patch.WaterPurifier
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using UnityEngine;

namespace Useful_Patch
{
  internal class WaterPurifier
  {
    [HarmonyPatch(typeof (WaterPurifierConfig), "ConfigureBuildingTemplate")]
    public class WaterPurifierConfigUp
    {
      public static void Postfix(GameObject go, Tag prefab_tag)
      {
        ElementConverter elementConverter = go.AddOrGet<ElementConverter>();
        elementConverter.consumedElements = new ElementConverter.ConsumedElement[2]
        {
          new ElementConverter.ConsumedElement(new Tag("Filter"), 10f),
          new ElementConverter.ConsumedElement(new Tag("DirtyWater"), 50f)
        };
        elementConverter.outputElements = new ElementConverter.OutputElement[2]
        {
          new ElementConverter.OutputElement(50f, SimHashes.Water, 0.0f, storeOutput: true, diseaseWeight: 0.75f),
          new ElementConverter.OutputElement(2f, SimHashes.ToxicSand, 0.0f, storeOutput: true, diseaseWeight: 0.25f)
        };
        ConduitConsumer conduitConsumer = go.AddOrGet<ConduitConsumer>();
        conduitConsumer.consumptionRate = 100f;
        conduitConsumer.capacityKG = 200f;
      }
    }
  }
}

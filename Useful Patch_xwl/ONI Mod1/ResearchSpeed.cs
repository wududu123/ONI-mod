// Decompiled with JetBrains decompiler
// Type: Useful_Patch.ResearchSpeed
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using UnityEngine;

namespace Useful_Patch
{
  internal class ResearchSpeed
  {
    [HarmonyPatch(typeof (ResearchCenterConfig), "ConfigureBuildingTemplate")]
    public class Research_Speed
    {
      public static void Postfix(GameObject go) => go.AddOrGet<ElementConverter>().consumedElements = new ElementConverter.ConsumedElement[1]
      {
        new ElementConverter.ConsumedElement(ResearchCenterConfig.INPUT_MATERIAL, 16.6f)
      };
    }

    [HarmonyPatch(typeof (AdvancedResearchCenterConfig), "ConfigureBuildingTemplate")]
    public class AdvancedResearch_Speed
    {
      public static void Postfix(GameObject go) => go.AddOrGet<ElementConverter>().consumedElements = new ElementConverter.ConsumedElement[1]
      {
        new ElementConverter.ConsumedElement(AdvancedResearchCenterConfig.INPUT_MATERIAL, 8.3f)
      };
    }

    [HarmonyPatch(typeof (CosmicResearchCenterConfig), "ConfigureBuildingTemplate")]
    public class CosmicResearch_Speed
    {
      public static void Postfix(GameObject go) => go.AddOrGet<ElementConverter>().consumedElements = new ElementConverter.ConsumedElement[1]
      {
        new ElementConverter.ConsumedElement(CosmicResearchCenterConfig.INPUT_MATERIAL, 0.5f)
      };
    }
  }
}

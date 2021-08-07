// Decompiled with JetBrains decompiler
// Type: Useful_Patch.AdvanceResearchCenterWaterInput
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using UnityEngine;

namespace Useful_Patch
{
  internal class AdvanceResearchCenterWaterInput
  {
    [HarmonyPatch(typeof (AdvancedResearchCenterConfig), "CreateBuildingDef")]
    public class AdvancedResearchCenterConfig_CreateBuildingDef
    {
      public static void Postfix(BuildingDef __result)
      {
        __result.InputConduitType = ConduitType.Liquid;
        __result.UtilityInputOffset = new CellOffset(0, 0);
      }
    }

    [HarmonyPatch(typeof (AdvancedResearchCenterConfig), "ConfigureBuildingTemplate")]
    public class AdvancedResearchCenterConfig_ConfigureBuildingTemplate
    {
      public static bool Prefix(GameObject go)
      {
        go.AddOrGet<BuildingComplete>().isManuallyOperated = true;
        Prioritizable.AddRef(go);
        Storage storage = go.AddOrGet<Storage>();
        storage.capacityKg = 1000f;
        storage.showInUI = true;
        ConduitConsumer conduitConsumer = go.AddOrGet<ConduitConsumer>();
        conduitConsumer.conduitType = ConduitType.Liquid;
        conduitConsumer.consumptionRate = 50f;
        conduitConsumer.capacityTag = SimHashes.Water.CreateTag();
        conduitConsumer.wrongElementResult = ConduitConsumer.WrongElementResult.Dump;
        conduitConsumer.capacityKG = 750f;
        conduitConsumer.forceAlwaysSatisfied = true;
        ResearchCenter researchCenter = go.AddOrGet<ResearchCenter>();
        researchCenter.overrideAnims = new KAnimFile[1]
        {
          Assets.GetAnim((HashedString) "anim_interacts_research2_kanim")
        };
        researchCenter.research_point_type_id = "beta";
        researchCenter.inputMaterial = AdvancedResearchCenterConfig.INPUT_MATERIAL;
        researchCenter.mass_per_point = 50f;
        researchCenter.requiredSkillPerk = Db.Get().SkillPerks.AllowAdvancedResearch.Id;
        ElementConverter elementConverter = go.AddOrGet<ElementConverter>();
        elementConverter.consumedElements = new ElementConverter.ConsumedElement[1]
        {
          new ElementConverter.ConsumedElement(AdvancedResearchCenterConfig.INPUT_MATERIAL, 8.3f)
        };
        elementConverter.showDescriptors = false;
        go.AddOrGetDef<PoweredController.Def>();
        return false;
      }
    }
  }
}

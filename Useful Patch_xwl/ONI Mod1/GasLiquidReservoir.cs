// Decompiled with JetBrains decompiler
// Type: Useful_Patch.GasLiquidReservoir
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using TUNING;
using UnityEngine;

namespace Useful_Patch
{
  internal class GasLiquidReservoir
  {
    [HarmonyPatch(typeof (GasReservoirConfig), "ConfigureBuildingTemplate")]
    public class GasReservoirUp
    {
      public static void Postfix(GameObject go)
      {
        go.AddOrGet<Reservoir>();
        Storage defaultStorage = BuildingTemplates.CreateDefaultStorage(go);
        defaultStorage.showDescriptor = true;
        defaultStorage.storageFilters = STORAGEFILTERS.GASES;
        defaultStorage.capacityKg = 15000f;
        defaultStorage.SetDefaultStoredItemModifiers(GasReservoirConfig.ReservoirStoredItemModifiers);
        go.AddOrGet<SmartReservoir>();
        ConduitConsumer conduitConsumer = go.AddOrGet<ConduitConsumer>();
        conduitConsumer.conduitType = ConduitType.Gas;
        conduitConsumer.ignoreMinMassCheck = true;
        conduitConsumer.forceAlwaysSatisfied = true;
        conduitConsumer.alwaysConsume = true;
        conduitConsumer.capacityKG = defaultStorage.capacityKg;
        ConduitDispenser conduitDispenser = go.AddOrGet<ConduitDispenser>();
        conduitDispenser.conduitType = ConduitType.Gas;
        conduitDispenser.elementFilter = (SimHashes[]) null;
      }
    }

    [HarmonyPatch(typeof (LiquidReservoirConfig), "ConfigureBuildingTemplate")]
    public class LiquidReservoirUp
    {
      public static void Postfix(GameObject go)
      {
        go.AddOrGet<Reservoir>();
        Storage defaultStorage = BuildingTemplates.CreateDefaultStorage(go);
        defaultStorage.showDescriptor = true;
        defaultStorage.allowItemRemoval = false;
        defaultStorage.storageFilters = STORAGEFILTERS.LIQUIDS;
        defaultStorage.capacityKg = 50000f;
        defaultStorage.SetDefaultStoredItemModifiers(GasReservoirConfig.ReservoirStoredItemModifiers);
        go.AddOrGet<SmartReservoir>();
        ConduitConsumer conduitConsumer = go.AddOrGet<ConduitConsumer>();
        conduitConsumer.conduitType = ConduitType.Liquid;
        conduitConsumer.ignoreMinMassCheck = true;
        conduitConsumer.forceAlwaysSatisfied = true;
        conduitConsumer.alwaysConsume = true;
        conduitConsumer.capacityKG = defaultStorage.capacityKg;
        ConduitDispenser conduitDispenser = go.AddOrGet<ConduitDispenser>();
        conduitDispenser.conduitType = ConduitType.Liquid;
        conduitDispenser.elementFilter = (SimHashes[]) null;
      }
    }
  }
}

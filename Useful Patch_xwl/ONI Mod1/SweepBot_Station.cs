// Decompiled with JetBrains decompiler
// Type: Useful_Patch.SweepBot_Station
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using TUNING;
using UnityEngine;

namespace Useful_Patch
{
  internal class SweepBot_Station
  {
    [HarmonyPatch(typeof (SweepBotConfig), "CreatePrefab")]
    public class SweepBotConfigUp
    {
      public static void Postfix(GameObject __result) => __result.GetComponents<Storage>()[1].capacityKg = 5000f;
    }

    [HarmonyPatch(typeof (SweepBotStationConfig), "ConfigureBuildingTemplate")]
    public class SweepBotStationConfigUp
    {
      public static bool Prefix(GameObject go, Tag prefab_tag)
      {
        Prioritizable.AddRef(go);
        Storage storage1 = go.AddComponent<Storage>();
        storage1.showInUI = true;
        storage1.allowItemRemoval = false;
        storage1.ignoreSourcePriority = true;
        storage1.showDescriptor = true;
        storage1.storageFilters = STORAGEFILTERS.NOT_EDIBLE_SOLIDS;
        storage1.storageFullMargin = STORAGE.STORAGE_LOCKER_FILLED_MARGIN;
        storage1.fetchCategory = Storage.FetchCategory.Building;
        storage1.capacityKg = 25f;
        storage1.allowClearable = false;
        Storage storage2 = go.AddComponent<Storage>();
        storage2.showInUI = true;
        storage2.allowItemRemoval = true;
        storage2.ignoreSourcePriority = true;
        storage2.showDescriptor = true;
        storage2.storageFilters = STORAGEFILTERS.NOT_EDIBLE_SOLIDS;
        storage2.storageFullMargin = STORAGE.STORAGE_LOCKER_FILLED_MARGIN;
        storage2.fetchCategory = Storage.FetchCategory.StorageSweepOnly;
        storage2.capacityKg = 10000f;
        storage2.allowClearable = true;
        go.AddOrGet<CharacterOverlay>();
        go.AddOrGet<SweepBotStation>();
        return false;
      }
    }
  }
}

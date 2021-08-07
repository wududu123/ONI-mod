// Decompiled with JetBrains decompiler
// Type: Useful_Patch.Refrigerator
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using TUNING;
using UnityEngine;

namespace Useful_Patch
{
  internal class Refrigerator
  {
    [HarmonyPatch(typeof (RefrigeratorConfig), "DoPostConfigureComplete")]
    public class RefrigeratorConfigUp
    {
      public static void Postfix(GameObject go)
      {
        Storage storage = go.AddOrGet<Storage>();
        storage.showInUI = true;
        storage.showDescriptor = true;
        storage.storageFilters = STORAGEFILTERS.FOOD;
        storage.allowItemRemoval = true;
        storage.capacityKg = 8000f;
        storage.storageFullMargin = STORAGE.STORAGE_LOCKER_FILLED_MARGIN;
        storage.fetchCategory = Storage.FetchCategory.GeneralStorage;
        Prioritizable.AddRef(go);
        go.AddOrGet<TreeFilterable>();
        go.AddOrGet<global::Refrigerator>();
        go.AddOrGet<UserNameable>();
        go.AddOrGet<DropAllWorkable>();
        go.AddOrGetDef<StorageController.Def>();
      }
    }
  }
}

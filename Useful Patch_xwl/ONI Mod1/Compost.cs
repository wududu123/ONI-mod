// Decompiled with JetBrains decompiler
// Type: Useful_Patch.Compost
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using UnityEngine;

namespace Useful_Patch
{
  internal class Compost
  {
    [HarmonyPatch(typeof (CompostConfig), "ConfigureBuildingTemplate")]
    public class CompostConfigUp
    {
      public static void Postfix(GameObject go)
      {
        go.AddOrGet<CompostWorkable>().workTime = 10f;
        ElementConverter elementConverter = go.AddOrGet<ElementConverter>();
        elementConverter.consumedElements = new ElementConverter.ConsumedElement[1]
        {
          new ElementConverter.ConsumedElement(CompostConfig.COMPOST_TAG, 1f)
        };
        elementConverter.outputElements = new ElementConverter.OutputElement[1]
        {
          new ElementConverter.OutputElement(1f, SimHashes.Dirt, 348.15f, storeOutput: true)
        };
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Useful_Patch.Oxyfern_Input_Output
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using UnityEngine;

namespace Useful_Patch
{
  internal class Oxyfern_Input_Output
  {
    [HarmonyPatch(typeof (OxyfernConfig), "CreatePrefab")]
    public class OxyfernConfigUp
    {
      public static void Postfix(GameObject __result)
      {
        ElementConsumer elementConsumer = __result.AddOrGet<ElementConsumer>();
        elementConsumer.consumptionRadius = (byte) 5;
        elementConsumer.consumptionRate = 0.0015625f;
        ElementConverter elementConverter = __result.AddOrGet<ElementConverter>();
        elementConverter.consumedElements = new ElementConverter.ConsumedElement[1]
        {
          new ElementConverter.ConsumedElement(SimHashes.CarbonDioxide.ToString().ToTag(), 0.006250001f)
        };
        elementConverter.outputElements = new ElementConverter.OutputElement[1]
        {
          new ElementConverter.OutputElement(0.3125f, SimHashes.Oxygen, 0.0f, true, outputElementOffsety: 1f, diseaseWeight: 0.75f)
        };
      }
    }

    [HarmonyPatch(typeof (Oxyfern), "SetConsumptionRate")]
    public class OxyfernUp
    {
      public static void Postfix(Oxyfern __instance)
      {
        Traverse traverse = Traverse.Create((object) __instance);
        ReceptacleMonitor receptacleMonitor = traverse.Field("receptacleMonitor").GetValue<ReceptacleMonitor>();
        ElementConsumer elementConsumer = traverse.Field("elementConsumer").GetValue<ElementConsumer>();
        if (receptacleMonitor.Replanted)
          elementConsumer.consumptionRate = 0.006250001f;
        else
          elementConsumer.consumptionRate = 0.0015625f;
      }
    }
  }
}

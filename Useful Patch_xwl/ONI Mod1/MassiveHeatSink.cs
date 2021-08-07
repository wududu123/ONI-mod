// Decompiled with JetBrains decompiler
// Type: Useful_Patch.MassiveHeatSink
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using UnityEngine;

namespace Useful_Patch
{
  internal class MassiveHeatSink
  {
    [HarmonyPatch(typeof (MassiveHeatSinkConfig), "CreateBuildingDef")]
    public class MassiveHeatSinkConfigUp
    {
      public static void Postfix(BuildingDef __result)
      {
        __result.LogicInputPorts = LogicOperationalController.CreateSingleInputPortList(new CellOffset(1, 0));
        __result.ExhaustKilowattsWhenActive = -160f;
        __result.SelfHeatKilowattsWhenActive = -640f;
      }
    }

    [HarmonyPatch(typeof (MassiveHeatSinkConfig), "DoPostConfigureComplete")]
    public class MassiveHeatSinkConfigUp_Logic
    {
      public static void Postfix(GameObject go) => go.AddOrGet<LogicOperationalController>();
    }
  }
}

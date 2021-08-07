// Decompiled with JetBrains decompiler
// Type: Useful_Patch.Refresh
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using KSerialization;
using System;
using UnityEngine;

namespace Useful_Patch
{
  internal class Refresh
  {
    [Serialize]
    private bool bImmigrantAvailable;

    private bool IsHalted()
    {
      foreach (Component component1 in Components.Telepads.Items)
      {
        Operational component2 = component1.GetComponent<Operational>();
        if ((UnityEngine.Object) component2 != (UnityEngine.Object) null && component2.IsOperational)
          return false;
      }
      return true;
    }

    [HarmonyPatch(typeof (Immigration), "Sim200ms")]
    public class Useful_Patch_Refresh
    {
      internal static void Postfix(float dt, Immigration __instance)
      {
        Refresh refresh = new Refresh();
        if (refresh.IsHalted() || refresh.bImmigrantAvailable)
          return;
        __instance.timeBeforeSpawn -= dt * (float) Configurations.GetConfig().LandingPodRefreshTime.Value;
        __instance.timeBeforeSpawn = Math.Max(__instance.timeBeforeSpawn, 0.0f);
        if ((double) __instance.timeBeforeSpawn <= 0.0)
          refresh.bImmigrantAvailable = true;
      }
    }
  }
}

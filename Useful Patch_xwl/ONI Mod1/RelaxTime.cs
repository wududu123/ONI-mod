// Decompiled with JetBrains decompiler
// Type: Useful_Patch.RelaxTime
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;

namespace Useful_Patch
{
  internal class RelaxTime
  {
    [HarmonyPatch(typeof (BeachChairWorkable), "OnPrefabInit")]
    public class BeachChair_20s
    {
      public static void Postfix(Workable __instance) => __instance.SetWorkTime(20f);
    }

    [HarmonyPatch(typeof (EspressoMachineWorkable), "OnPrefabInit")]
    public class EspressoMachine_20s
    {
      public static void Postfix(Workable __instance) => __instance.SetWorkTime(20f);
    }

    [HarmonyPatch(typeof (SodaFountainWorkable), "OnPrefabInit")]
    public class SodaFountain_20s
    {
      public static void Postfix(Workable __instance) => __instance.SetWorkTime(20f);
    }

    [HarmonyPatch(typeof (SaunaWorkable), "OnPrefabInit")]
    public class Sauna_20s
    {
      public static void Postfix(Workable __instance) => __instance.SetWorkTime(20f);
    }

    [HarmonyPatch(typeof (JuicerWorkable), "OnPrefabInit")]
    public class Juicer_20s
    {
      public static void Postfix(Workable __instance) => __instance.SetWorkTime(20f);
    }

    [HarmonyPatch(typeof (MechanicalSurfboardWorkable), "OnPrefabInit")]
    public class MechanicalSurfboard_20s
    {
      public static void Postfix(Workable __instance) => __instance.SetWorkTime(20f);
    }

    [HarmonyPatch(typeof (VerticalWindTunnelWorkable), "OnPrefabInit")]
    public class VerticalWindTunnel_20s
    {
      public static void Postfix(Workable __instance) => __instance.SetWorkTime(20f);
    }

    [HarmonyPatch(typeof (HotTubWorkable), "OnPrefabInit")]
    public class HotTub_20s
    {
      public static void Postfix(Workable __instance) => __instance.SetWorkTime(20f);
    }
  }
}

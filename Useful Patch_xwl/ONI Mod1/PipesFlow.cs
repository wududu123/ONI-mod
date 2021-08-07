// Decompiled with JetBrains decompiler
// Type: Useful_Patch.PipesFlow
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;

namespace Useful_Patch
{
  internal class PipesFlow
  {
    [HarmonyPatch(typeof (Game), "OnPrefabInit")]
    public class PipesFlowUp
    {
      public static void Postfix(ref Game __instance)
      {
        __instance.gasConduitFlow = new ConduitFlow(ConduitType.Gas, Grid.CellCount, (IUtilityNetworkMgr) __instance.gasConduitSystem, 5f, 2f);
        __instance.liquidConduitFlow = new ConduitFlow(ConduitType.Liquid, Grid.CellCount, (IUtilityNetworkMgr) __instance.liquidConduitSystem, 100f, 2f);
        __instance.solidConduitFlow = new SolidConduitFlow(Grid.CellCount, (IUtilityNetworkMgr) __instance.solidConduitSystem, 2f);
        __instance.gasFlowVisualizer = new ConduitFlowVisualizer(__instance.gasConduitFlow, __instance.gasConduitVisInfo, GlobalResources.Instance().ConduitOverlaySoundGas, Lighting.Instance.Settings.GasConduit);
        __instance.liquidFlowVisualizer = new ConduitFlowVisualizer(__instance.liquidConduitFlow, __instance.liquidConduitVisInfo, GlobalResources.Instance().ConduitOverlaySoundLiquid, Lighting.Instance.Settings.LiquidConduit);
        __instance.solidFlowVisualizer = new SolidConduitFlowVisualizer(__instance.solidConduitFlow, __instance.solidConduitVisInfo, GlobalResources.Instance().ConduitOverlaySoundSolid, Lighting.Instance.Settings.SolidConduit);
      }
    }
  }
}

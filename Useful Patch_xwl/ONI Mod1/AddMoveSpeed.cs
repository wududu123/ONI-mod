// Decompiled with JetBrains decompiler
// Type: Useful_Patch.AddMoveSpeed
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using UnityEngine;

namespace Useful_Patch
{
  internal class AddMoveSpeed
  {
    [HarmonyPatch(typeof (InsulationTileConfig), "ConfigureBuildingTemplate")]
    public class InsulationTile_AddSpeed
    {
      public static void Postfix(GameObject go)
      {
        SimCellOccupier simCellOccupier = go.AddOrGet<SimCellOccupier>();
        simCellOccupier.strengthMultiplier = 2f;
        simCellOccupier.movementSpeedMultiplier = 3f;
      }
    }

    [HarmonyPatch(typeof (MeshTileConfig), "ConfigureBuildingTemplate")]
    public class MeshTile_AddSpeed
    {
      public static void Postfix(GameObject go)
      {
        SimCellOccupier simCellOccupier = go.AddOrGet<SimCellOccupier>();
        simCellOccupier.strengthMultiplier = 2f;
        simCellOccupier.movementSpeedMultiplier = 2f;
      }
    }

    [HarmonyPatch(typeof (MetalTileConfig), "ConfigureBuildingTemplate")]
    public class MetalTile_AddSpeed
    {
      public static void Postfix(GameObject go)
      {
        SimCellOccupier simCellOccupier = go.AddOrGet<SimCellOccupier>();
        simCellOccupier.strengthMultiplier = 2f;
        simCellOccupier.movementSpeedMultiplier = 3f;
      }
    }

    [HarmonyPatch(typeof (BunkerTileConfig), "ConfigureBuildingTemplate")]
    public class BunkerTile_AddSpeed
    {
      public static void Postfix(GameObject go) => go.AddOrGet<SimCellOccupier>().movementSpeedMultiplier = 3f;
    }

    [HarmonyPatch(typeof (CarpetTileConfig), "ConfigureBuildingTemplate")]
    public class CarpetTile_AddSpeed
    {
      public static void Postfix(GameObject go)
      {
        SimCellOccupier simCellOccupier = go.AddOrGet<SimCellOccupier>();
        simCellOccupier.strengthMultiplier = 2f;
        simCellOccupier.movementSpeedMultiplier = 2f;
      }
    }

    [HarmonyPatch(typeof (FarmTileConfig), "ConfigureBuildingTemplate")]
    public class FarmTile_AddSpeed
    {
      public static void Postfix(GameObject go)
      {
        SimCellOccupier simCellOccupier = go.AddOrGet<SimCellOccupier>();
        simCellOccupier.strengthMultiplier = 2f;
        simCellOccupier.movementSpeedMultiplier = 2f;
      }
    }

    [HarmonyPatch(typeof (GlassTileConfig), "ConfigureBuildingTemplate")]
    public class GlassTile_AddSpeed
    {
      public static void Postfix(GameObject go)
      {
        SimCellOccupier simCellOccupier = go.AddOrGet<SimCellOccupier>();
        simCellOccupier.strengthMultiplier = 2f;
        simCellOccupier.movementSpeedMultiplier = 2f;
      }
    }

    [HarmonyPatch(typeof (TileConfig), "ConfigureBuildingTemplate")]
    public class Tile_AddSpeed
    {
      public static void Postfix(GameObject go)
      {
        SimCellOccupier simCellOccupier = go.AddOrGet<SimCellOccupier>();
        simCellOccupier.strengthMultiplier = 2f;
        simCellOccupier.movementSpeedMultiplier = 2f;
      }
    }

    [HarmonyPatch(typeof (PlasticTileConfig), "ConfigureBuildingTemplate")]
    public class PlasticTile_AddSpeed
    {
      public static void Postfix(GameObject go)
      {
        SimCellOccupier simCellOccupier = go.AddOrGet<SimCellOccupier>();
        simCellOccupier.strengthMultiplier = 2f;
        simCellOccupier.movementSpeedMultiplier = 2f;
      }
    }

    [HarmonyPatch(typeof (GasPermeableMembraneConfig), "ConfigureBuildingTemplate")]
    public class GasPermeableMembrane_AddSpeed
    {
      public static void Postfix(GameObject go)
      {
        SimCellOccupier simCellOccupier = go.AddOrGet<SimCellOccupier>();
        simCellOccupier.strengthMultiplier = 2f;
        simCellOccupier.movementSpeedMultiplier = 2f;
      }
    }

    [HarmonyPatch(typeof (LadderConfig), "ConfigureBuildingTemplate")]
    public class LadderConfig_AddSpeed
    {
      public static void Postfix(GameObject go)
      {
        Ladder ladder = go.AddOrGet<Ladder>();
        ladder.upwardsMovementSpeedMultiplier = 2f;
        ladder.downwardsMovementSpeedMultiplier = 2f;
      }
    }

    [HarmonyPatch(typeof (LadderFastConfig), "ConfigureBuildingTemplate")]
    public class LadderFastConfig_AddSpeed
    {
      public static void Postfix(GameObject go)
      {
        Ladder ladder = go.AddOrGet<Ladder>();
        ladder.upwardsMovementSpeedMultiplier = 2.4f;
        ladder.downwardsMovementSpeedMultiplier = 2.4f;
      }
    }

    [HarmonyPatch(typeof (FirePoleConfig), "ConfigureBuildingTemplate")]
    public class FirePoleConfig_AddSpeed
    {
      public static void Postfix(GameObject go)
      {
        Ladder ladder = go.AddOrGet<Ladder>();
        ladder.upwardsMovementSpeedMultiplier = 0.5f;
        ladder.downwardsMovementSpeedMultiplier = 8f;
      }
    }
  }
}

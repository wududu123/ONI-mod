// Decompiled with JetBrains decompiler
// Type: WormHoleHand.WormHoleHand
// Assembly: WormHoleHand, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2103E631-8330-4587-8E7D-E3E17DE47CD5
// Assembly location: C:\Users\xu198\Documents\WormHoleHand\WormHoleHand.dll

using HarmonyLib;

namespace WormHoleHand
{
  public class WormHoleHand
  {
    [HarmonyPatch(typeof (Game), "OnPrefabInit")]
    internal class WormHoleHand_OffsetGroups_StaticConstructor
    {
      public static CellOffset[][] modifiedTable = new CellOffset[66][]
      {
        new CellOffset[1]{ new CellOffset(0, 0) },
        new CellOffset[1]{ new CellOffset(0, 1) },
        new CellOffset[1]{ new CellOffset(0, 2) },
        new CellOffset[1]{ new CellOffset(0, 3) },
        new CellOffset[1]{ new CellOffset(0, 4) },
        new CellOffset[1]{ new CellOffset(0, 5) },
        new CellOffset[1]{ new CellOffset(1, 0) },
        new CellOffset[1]{ new CellOffset(1, 1) },
        new CellOffset[1]{ new CellOffset(1, 2) },
        new CellOffset[1]{ new CellOffset(1, 3) },
        new CellOffset[1]{ new CellOffset(1, 4) },
        new CellOffset[1]{ new CellOffset(1, 5) },
        new CellOffset[1]{ new CellOffset(2, 0) },
        new CellOffset[1]{ new CellOffset(2, 1) },
        new CellOffset[1]{ new CellOffset(2, 2) },
        new CellOffset[1]{ new CellOffset(2, 3) },
        new CellOffset[1]{ new CellOffset(2, 4) },
        new CellOffset[1]{ new CellOffset(2, 5) },
        new CellOffset[1]{ new CellOffset(3, 0) },
        new CellOffset[1]{ new CellOffset(3, 1) },
        new CellOffset[1]{ new CellOffset(3, 2) },
        new CellOffset[1]{ new CellOffset(3, 3) },
        new CellOffset[1]{ new CellOffset(3, 4) },
        new CellOffset[1]{ new CellOffset(3, 5) },
        new CellOffset[1]{ new CellOffset(4, 0) },
        new CellOffset[1]{ new CellOffset(4, 1) },
        new CellOffset[1]{ new CellOffset(4, 2) },
        new CellOffset[1]{ new CellOffset(4, 3) },
        new CellOffset[1]{ new CellOffset(4, 4) },
        new CellOffset[1]{ new CellOffset(4, 5) },
        new CellOffset[1]{ new CellOffset(5, 0) },
        new CellOffset[1]{ new CellOffset(5, 1) },
        new CellOffset[1]{ new CellOffset(5, 2) },
        new CellOffset[1]{ new CellOffset(5, 3) },
        new CellOffset[1]{ new CellOffset(5, 4) },
        new CellOffset[1]{ new CellOffset(5, 5) },
        new CellOffset[1]{ new CellOffset(0, -1) },
        new CellOffset[1]{ new CellOffset(0, -2) },
        new CellOffset[1]{ new CellOffset(0, -3) },
        new CellOffset[1]{ new CellOffset(0, -4) },
        new CellOffset[1]{ new CellOffset(0, -5) },
        new CellOffset[1]{ new CellOffset(1, -1) },
        new CellOffset[1]{ new CellOffset(1, -2) },
        new CellOffset[1]{ new CellOffset(1, -3) },
        new CellOffset[1]{ new CellOffset(1, -4) },
        new CellOffset[1]{ new CellOffset(1, -5) },
        new CellOffset[1]{ new CellOffset(2, -1) },
        new CellOffset[1]{ new CellOffset(2, -2) },
        new CellOffset[1]{ new CellOffset(2, -3) },
        new CellOffset[1]{ new CellOffset(2, -4) },
        new CellOffset[1]{ new CellOffset(2, -5) },
        new CellOffset[1]{ new CellOffset(3, -1) },
        new CellOffset[1]{ new CellOffset(3, -2) },
        new CellOffset[1]{ new CellOffset(3, -3) },
        new CellOffset[1]{ new CellOffset(3, -4) },
        new CellOffset[1]{ new CellOffset(3, -5) },
        new CellOffset[1]{ new CellOffset(4, -1) },
        new CellOffset[1]{ new CellOffset(4, -2) },
        new CellOffset[1]{ new CellOffset(4, -3) },
        new CellOffset[1]{ new CellOffset(4, -4) },
        new CellOffset[1]{ new CellOffset(4, -5) },
        new CellOffset[1]{ new CellOffset(5, -1) },
        new CellOffset[1]{ new CellOffset(5, -2) },
        new CellOffset[1]{ new CellOffset(5, -3) },
        new CellOffset[1]{ new CellOffset(5, -4) },
        new CellOffset[1]{ new CellOffset(5, -5) }
      };

      public static void Postfix()
      {
        OffsetGroups.InvertedStandardTable = OffsetTable.Mirror(WormHoleHand.WormHoleHand_OffsetGroups_StaticConstructor.modifiedTable);
        OffsetGroups.InvertedStandardTableWithCorners = OffsetTable.Mirror(WormHoleHand.WormHoleHand_OffsetGroups_StaticConstructor.modifiedTable);
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Useful_Patch.SolidConduit
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

namespace Useful_Patch
{
  internal class SolidConduit
  {
    [HarmonyPatch(typeof (SolidConduitDispenser), "ConduitUpdate")]
    private static class SolidConduit_100kg
    {
      private static IEnumerable<CodeInstruction> Transpiler(
        IEnumerable<CodeInstruction> instructions)
      {
        List<CodeInstruction> codeInstructionList = new List<CodeInstruction>(instructions);
        for (int index = 0; index < codeInstructionList.Count; ++index)
        {
          if ((OpCode) codeInstructionList[index].opcode == OpCodes.Ldc_R4 && (double) (float) codeInstructionList[index].operand == 20.0)
            codeInstructionList[index].operand = (ValueType) 100f;
        }
        return ((IEnumerable<CodeInstruction>) codeInstructionList).AsEnumerable<CodeInstruction>();
      }
    }
  }
}

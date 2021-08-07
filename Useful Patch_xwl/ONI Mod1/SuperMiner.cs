// Decompiled with JetBrains decompiler
// Type: Useful_Patch.SuperMiner
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
  internal class SuperMiner
  {
    [HarmonyPatch(typeof (WorldDamage), "OnDigComplete")]
    internal class SuperMinerMod_WorldDamage_OnDigComplete
    {
      private static IEnumerable<CodeInstruction> Transpiler(
        IEnumerable<CodeInstruction> instr)
      {
        IEnumerable<CodeInstruction> source;
        List<CodeInstruction> list = source.ToList<CodeInstruction>();
        foreach (CodeInstruction codeInstruction in list)
        {
          if ((OpCode) codeInstruction.opcode == OpCodes.Ldc_R4 && (double) (float) codeInstruction.operand == 0.5)
          {
            Debug.Log((object) " === Transpiler applied === ");
            codeInstruction.operand = (__Null) (ValueType) 1f;
          }
          yield return codeInstruction;
        }
        List<CodeInstruction>.Enumerator enumerator = new List<CodeInstruction>.Enumerator();
      }
    }
  }
}

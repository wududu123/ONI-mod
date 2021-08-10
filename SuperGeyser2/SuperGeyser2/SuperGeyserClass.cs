// Decompiled with JetBrains decompiler
// Type: SuperGeyser2.SuperGeyserClass
// Assembly: SuperGeyser2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3EC01680-2A65-4F6A-A81A-96908D06DBC3
// Assembly location: D:\Devlop\mod_SuperGeyser2\SuperGeyser2.dll

using HarmonyLib;
using System.Collections.Generic;

namespace SuperGeyser2
{
  public class SuperGeyserClass
  {

    public static void OnLoad()
        {
            Debug.Log("I execute OnLoad! superGeyser");
        }

    [HarmonyPatch(typeof (GeyserGenericConfig), "GenerateConfigs")]
    internal class SuperGeyser_GenerateConfigs
    {
      private static void Postfix(
        ref List<GeyserGenericConfig.GeyserPrefabParams> __result)
      {

        Debug.Log(string.Format("asdfadsf {0} adsfasdf", __result.Count));


        for (int index = 0; index < __result.Count; ++index)
        {
            Debug.Log(string.Format("GeyserGenericConfig {0}", __result[index].geyserType.id));
            __result[index].geyserType.minRatePerCycle = __result[index].geyserType.maxRatePerCycle * 10;
            __result[index].geyserType.maxRatePerCycle = __result[index].geyserType.maxRatePerCycle * 10;
                    //一个喷发周期秒数
                    __result[index].geyserType.minIterationLength = 1140f;
                    __result[index].geyserType.maxIterationLength = 1140f;
                    //每个周期，喷发的比例
                    __result[index].geyserType.minIterationPercent = 1.0f;
                    __result[index].geyserType.maxIterationPercent = 1.0f;
                }



      }
    }
  }
}

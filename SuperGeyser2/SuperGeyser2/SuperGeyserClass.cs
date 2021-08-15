// Decompiled with JetBrains decompiler
// Type: SuperGeyser2.SuperGeyserClass
// Assembly: SuperGeyser2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3EC01680-2A65-4F6A-A81A-96908D06DBC3
// Assembly location: D:\Devlop\mod_SuperGeyser2\SuperGeyser2.dll

using HarmonyLib;
using System.Collections.Generic;
using PeterHan.PLib.Core;
using PeterHan.PLib.Options;
using Newtonsoft.Json;
using KMod;

namespace SuperGeyser2
{
    [RestartRequired]
    [JsonObject(MemberSerialization.OptIn)]

    public class SuperGeyserSettings
    {
        [Option("steamTemperature", "steamTemperature")]
        [Limit(0, 120)]
        [JsonProperty]
        public int steamTemperature { get; set; }

        public SuperGeyserSettings()
        {
            steamTemperature = 110;
        }
    }

    public class SuperGeyser2 : UserMod2
    {
        public static SuperGeyserSettings Settings;
        public override void OnLoad(Harmony harmony)
        {
            Debug.Log("I execute OnLoad! superGeyser");
            base.OnLoad(harmony);
            new POptions().RegisterOptions(this, typeof(SuperGeyserSettings));


            // Init PLib and settings
            PUtil.InitLibrary();

            Settings = POptions.ReadSettings<SuperGeyserSettings>();
            if (Settings == null)
            {
                Settings = new SuperGeyserSettings();
            }
        }

        public static void ReadSettings()
        {
            Debug.Log("Loading settings");

            Settings = POptions.ReadSettings<SuperGeyserSettings>();
            if (Settings == null)
            {
                Settings = new SuperGeyserSettings();
            }
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
                    __result[index].geyserType.minRatePerCycle = __result[index].geyserType.maxRatePerCycle * 5;
                    __result[index].geyserType.maxRatePerCycle = __result[index].geyserType.maxRatePerCycle * 5;
                    //一个喷发周期秒数
                    __result[index].geyserType.minIterationLength = 1140f;
                    __result[index].geyserType.maxIterationLength = 1140f;
                    //每个周期，喷发的比例
                    __result[index].geyserType.minIterationPercent = 1.0f;
                    __result[index].geyserType.maxIterationPercent = 1.0f;
                    __result[index].geyserType.minYearPercent = 1.0f;
                    __result[index].geyserType.maxYearPercent = 1.0f;
                    if(__result[index].geyserType.id == "hot_water")
                    {
                        __result[index].geyserType.temperature = 293.15f;
                    }else if (__result[index].geyserType.id == "filthy_water")
                    {
                        __result[index].geyserType.temperature = 263.15f;
                    }else if (__result[index].geyserType.id == "steam")
                    {
                        __result[index].geyserType.temperature = SuperGeyser2.Settings.steamTemperature + 273.15f;
                    }

                }



      }
    }
  }
}

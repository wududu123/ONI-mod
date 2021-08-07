// Decompiled with JetBrains decompiler
// Type: Useful_Patch.SeverlWires
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;

namespace Useful_Patch
{
  internal class SeverlWires
  {
    [HarmonyPatch(typeof (Wire), "GetMaxWattageAsFloat")]
    public class WireUp
    {
      private static bool Prefix(Wire.WattageRating rating, ref float __result)
      {
        float num;
        switch (rating)
        {
          case Wire.WattageRating.Max500:
            num = 720f;
            break;
          case Wire.WattageRating.Max1000:
            num = 1440f;
            break;
          case Wire.WattageRating.Max2000:
            num = 2880f;
            break;
          case Wire.WattageRating.Max20000:
            num = 28800f;
            break;
          case Wire.WattageRating.Max50000:
            num = 72000f;
            break;
          default:
            num = 0.0f;
            break;
        }
        __result = num;
        return false;
      }
    }
  }
}

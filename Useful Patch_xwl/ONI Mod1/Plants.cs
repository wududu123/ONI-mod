// Decompiled with JetBrains decompiler
// Type: Useful_Patch.Plants
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using Harmony;

namespace Useful_Patch
{
  internal class Plants
  {
    [HarmonyPatch(typeof (SeedProducer), "DropSeed")]
    public class DropSeedUp
    {
      public static bool Prefix(SeedProducer __instance)
      {
        if (Configurations.GetConfig().DropMoreSeeds.Value != 1)
          return true;
        __instance.ProduceSeed(__instance.seedInfo.seedId, 1);
        return false;
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Useful_Patch.Generator
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;

namespace Useful_Patch
{
  internal class Generator
  {
    [HarmonyPatch(typeof (GeneratorConfig), "CreateBuildingDef")]
    public class GeneratorConfigUp
    {
      public static void Postfix(BuildingDef __result) => __result.GeneratorWattageRating = 700f;
    }

    [HarmonyPatch(typeof (HydrogenGeneratorConfig), "CreateBuildingDef")]
    public class HydrogenGeneratorConfigUp
    {
      public static void Postfix(BuildingDef __result) => __result.GeneratorWattageRating = 900f;
    }

    [HarmonyPatch(typeof (ManualGeneratorConfig), "CreateBuildingDef")]
    public class ManualGeneratorConfigUp
    {
      public static void Postfix(BuildingDef __result) => __result.GeneratorWattageRating = 500f;
    }

    [HarmonyPatch(typeof (MethaneGeneratorConfig), "CreateBuildingDef")]
    public class MethaneGeneratorConfigUp
    {
      public static void Postfix(BuildingDef __result) => __result.GeneratorWattageRating = 900f;
    }

    [HarmonyPatch(typeof (WoodGasGeneratorConfig), "CreateBuildingDef")]
    public class WoodGasGeneratorConfigUp
    {
      public static void Postfix(BuildingDef __result) => __result.GeneratorWattageRating = 400f;
    }
  }
}

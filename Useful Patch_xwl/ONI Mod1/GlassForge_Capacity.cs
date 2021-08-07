// Decompiled with JetBrains decompiler
// Type: Useful_Patch.GlassForge_Capacity
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using STRINGS;
using System.Collections.Generic;
using UnityEngine;

namespace Useful_Patch
{
  internal class GlassForge_Capacity
  {
    private static readonly List<Storage.StoredItemModifier> RefineryStoredItemModifiers = new List<Storage.StoredItemModifier>()
    {
      Storage.StoredItemModifier.Hide,
      Storage.StoredItemModifier.Preserve
    };

    [HarmonyPatch(typeof (GlassForgeConfig), "ConfigureBuildingTemplate")]
    internal class GlassForgeConfig_CapacityUp
    {
      internal static bool Prefix(GameObject go, Tag prefab_tag)
      {
        go.AddOrGet<DropAllWorkable>();
        go.AddOrGet<BuildingComplete>().isManuallyOperated = true;
        GlassForge glassForge = go.AddOrGet<GlassForge>();
        glassForge.sideScreenStyle = ComplexFabricatorSideScreen.StyleSetting.ListQueueHybrid;
        go.AddOrGet<FabricatorIngredientStatusManager>();
        go.AddOrGet<CopyBuildingSettings>();
        ComplexFabricatorWorkable fabricatorWorkable = go.AddOrGet<ComplexFabricatorWorkable>();
        glassForge.duplicantOperated = true;
        BuildingTemplates.CreateComplexFabricatorStorage(go, (ComplexFabricator) glassForge);
        glassForge.outStorage.capacityKg = 2000f;
        glassForge.storeProduced = true;
        glassForge.inStorage.SetDefaultStoredItemModifiers(GlassForge_Capacity.RefineryStoredItemModifiers);
        glassForge.buildStorage.SetDefaultStoredItemModifiers(GlassForge_Capacity.RefineryStoredItemModifiers);
        glassForge.outStorage.SetDefaultStoredItemModifiers(GlassForge_Capacity.RefineryStoredItemModifiers);
        glassForge.outputOffset = new Vector3(1f, 0.5f);
        fabricatorWorkable.overrideAnims = new KAnimFile[1]
        {
          Assets.GetAnim((HashedString) "anim_interacts_metalrefinery_kanim")
        };
        ConduitDispenser conduitDispenser = go.AddOrGet<ConduitDispenser>();
        conduitDispenser.storage = glassForge.outStorage;
        conduitDispenser.conduitType = ConduitType.Liquid;
        conduitDispenser.elementFilter = (SimHashes[]) null;
        conduitDispenser.alwaysDispense = true;
        ComplexRecipe.RecipeElement[] recipeElementArray1 = new ComplexRecipe.RecipeElement[1]
        {
          new ComplexRecipe.RecipeElement(ElementLoader.FindElementByHash(SimHashes.Sand).tag, 400f)
        };
        ComplexRecipe.RecipeElement[] recipeElementArray2 = new ComplexRecipe.RecipeElement[1]
        {
          new ComplexRecipe.RecipeElement(ElementLoader.FindElementByHash(SimHashes.MoltenGlass).tag, 100f)
        };
        string obsolete_id = ComplexRecipeManager.MakeObsoleteRecipeID("GlassForge", recipeElementArray1[0].material);
        string new_id = ComplexRecipeManager.MakeRecipeID("GlassForge", (IList<ComplexRecipe.RecipeElement>) recipeElementArray1, (IList<ComplexRecipe.RecipeElement>) recipeElementArray2);
        new ComplexRecipe(new_id, recipeElementArray1, recipeElementArray2)
        {
          time = 10f,
          nameDisplay = ComplexRecipe.RecipeNameDisplay.Result,
          description = string.Format((string) BUILDINGS.PREFABS.GLASSFORGE.RECIPE_DESCRIPTION, (object) ElementLoader.GetElement(recipeElementArray2[0].material).name, (object) ElementLoader.GetElement(recipeElementArray1[0].material).name)
        }.fabricators = new List<Tag>()
        {
          TagManager.Create("GlassForge")
        };
        ComplexRecipeManager.Get().AddObsoleteIDMapping(obsolete_id, new_id);
        Prioritizable.AddRef(go);
        return false;
      }
    }
  }
}

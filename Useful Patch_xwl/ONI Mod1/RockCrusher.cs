// Decompiled with JetBrains decompiler
// Type: Useful_Patch.RockCrusher
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using STRINGS;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Useful_Patch
{
  internal class RockCrusher
  {
    [HarmonyPatch(typeof (RockCrusherConfig), "ConfigureBuildingTemplate")]
    public class RockCrusherConfig_time
    {
      public static bool Prefix(GameObject go, Tag prefab_tag)
      {
        go.AddOrGet<DropAllWorkable>();
        go.AddOrGet<BuildingComplete>().isManuallyOperated = true;
        ComplexFabricator fabricator = go.AddOrGet<ComplexFabricator>();
        fabricator.sideScreenStyle = ComplexFabricatorSideScreen.StyleSetting.ListQueueHybrid;
        fabricator.duplicantOperated = true;
        go.AddOrGet<FabricatorIngredientStatusManager>();
        go.AddOrGet<CopyBuildingSettings>();
        ComplexFabricatorWorkable fabricatorWorkable = go.AddOrGet<ComplexFabricatorWorkable>();
        BuildingTemplates.CreateComplexFabricatorStorage(go, fabricator);
        fabricatorWorkable.overrideAnims = new KAnimFile[1]
        {
          Assets.GetAnim((HashedString) "anim_interacts_rockrefinery_kanim")
        };
        fabricatorWorkable.workingPstComplete = new HashedString[1]
        {
          (HashedString) "working_pst_complete"
        };
        Tag tag = SimHashes.Sand.CreateTag();
        foreach (Element element in ElementLoader.elements.FindAll((Predicate<Element>) (e => e.HasTag(GameTags.Crushable))))
        {
          ComplexRecipe.RecipeElement[] recipeElementArray1 = new ComplexRecipe.RecipeElement[1]
          {
            new ComplexRecipe.RecipeElement(element.tag, 100f)
          };
          ComplexRecipe.RecipeElement[] recipeElementArray2 = new ComplexRecipe.RecipeElement[1]
          {
            new ComplexRecipe.RecipeElement(tag, 100f)
          };
          string obsolete_id = ComplexRecipeManager.MakeObsoleteRecipeID(nameof (RockCrusher), element.tag);
          string new_id = ComplexRecipeManager.MakeRecipeID(nameof (RockCrusher), (IList<ComplexRecipe.RecipeElement>) recipeElementArray1, (IList<ComplexRecipe.RecipeElement>) recipeElementArray2);
          new ComplexRecipe(new_id, recipeElementArray1, recipeElementArray2)
          {
            time = 10f,
            description = string.Format((string) BUILDINGS.PREFABS.ROCKCRUSHER.RECIPE_DESCRIPTION, (object) element.name, (object) tag.ProperName()),
            nameDisplay = ComplexRecipe.RecipeNameDisplay.IngredientToResult
          }.fabricators = new List<Tag>()
          {
            TagManager.Create(nameof (RockCrusher))
          };
          ComplexRecipeManager.Get().AddObsoleteIDMapping(obsolete_id, new_id);
        }
        foreach (Element element in ElementLoader.elements.FindAll((Predicate<Element>) (e => e.IsSolid && e.HasTag(GameTags.Metal))))
        {
          Element lowTempTransition = element.highTempTransition.lowTempTransition;
          if (lowTempTransition != element)
          {
            ComplexRecipe.RecipeElement[] recipeElementArray3 = new ComplexRecipe.RecipeElement[1]
            {
              new ComplexRecipe.RecipeElement(element.tag, 100f)
            };
            ComplexRecipe.RecipeElement[] recipeElementArray4 = new ComplexRecipe.RecipeElement[2]
            {
              new ComplexRecipe.RecipeElement(lowTempTransition.tag, 50f),
              new ComplexRecipe.RecipeElement(tag, 50f)
            };
            string obsolete_id = ComplexRecipeManager.MakeObsoleteRecipeID(nameof (RockCrusher), lowTempTransition.tag);
            string new_id = ComplexRecipeManager.MakeRecipeID(nameof (RockCrusher), (IList<ComplexRecipe.RecipeElement>) recipeElementArray3, (IList<ComplexRecipe.RecipeElement>) recipeElementArray4);
            new ComplexRecipe(new_id, recipeElementArray3, recipeElementArray4)
            {
              time = 10f,
              description = string.Format((string) BUILDINGS.PREFABS.ROCKCRUSHER.METAL_RECIPE_DESCRIPTION, (object) lowTempTransition.name, (object) element.name),
              nameDisplay = ComplexRecipe.RecipeNameDisplay.IngredientToResult
            }.fabricators = new List<Tag>()
            {
              TagManager.Create(nameof (RockCrusher))
            };
            ComplexRecipeManager.Get().AddObsoleteIDMapping(obsolete_id, new_id);
          }
        }
        Element elementByHash1 = ElementLoader.FindElementByHash(SimHashes.Lime);
        ComplexRecipe.RecipeElement[] recipeElementArray5 = new ComplexRecipe.RecipeElement[1]
        {
          new ComplexRecipe.RecipeElement((Tag) "EggShell", 5f)
        };
        ComplexRecipe.RecipeElement[] recipeElementArray6 = new ComplexRecipe.RecipeElement[1]
        {
          new ComplexRecipe.RecipeElement(ElementLoader.FindElementByHash(SimHashes.Lime).tag, 5f)
        };
        string obsolete_id1 = ComplexRecipeManager.MakeObsoleteRecipeID(nameof (RockCrusher), elementByHash1.tag);
        string new_id1 = ComplexRecipeManager.MakeRecipeID(nameof (RockCrusher), (IList<ComplexRecipe.RecipeElement>) recipeElementArray5, (IList<ComplexRecipe.RecipeElement>) recipeElementArray6);
        new ComplexRecipe(new_id1, recipeElementArray5, recipeElementArray6)
        {
          time = 10f,
          description = string.Format((string) BUILDINGS.PREFABS.ROCKCRUSHER.LIME_RECIPE_DESCRIPTION, (object) SimHashes.Lime.CreateTag().ProperName(), (object) MISC.TAGS.EGGSHELL),
          nameDisplay = ComplexRecipe.RecipeNameDisplay.IngredientToResult
        }.fabricators = new List<Tag>()
        {
          TagManager.Create(nameof (RockCrusher))
        };
        ComplexRecipeManager.Get().AddObsoleteIDMapping(obsolete_id1, new_id1);
        Element elementByHash2 = ElementLoader.FindElementByHash(SimHashes.Lime);
        ComplexRecipe.RecipeElement[] recipeElementArray7 = new ComplexRecipe.RecipeElement[1]
        {
          new ComplexRecipe.RecipeElement((Tag) "BabyCrabShell", 1f)
        };
        ComplexRecipe.RecipeElement[] recipeElementArray8 = new ComplexRecipe.RecipeElement[1]
        {
          new ComplexRecipe.RecipeElement(elementByHash2.tag, 5f)
        };
        new ComplexRecipe(ComplexRecipeManager.MakeRecipeID(nameof (RockCrusher), (IList<ComplexRecipe.RecipeElement>) recipeElementArray7, (IList<ComplexRecipe.RecipeElement>) recipeElementArray8), recipeElementArray7, recipeElementArray8)
        {
          time = 10f,
          description = string.Format((string) BUILDINGS.PREFABS.ROCKCRUSHER.LIME_RECIPE_DESCRIPTION, (object) SimHashes.Lime.CreateTag().ProperName(), (object) ITEMS.INDUSTRIAL_PRODUCTS.CRAB_SHELL.NAME),
          nameDisplay = ComplexRecipe.RecipeNameDisplay.IngredientToResult
        }.fabricators = new List<Tag>()
        {
          TagManager.Create(nameof (RockCrusher))
        };
        Element elementByHash3 = ElementLoader.FindElementByHash(SimHashes.Lime);
        ComplexRecipe.RecipeElement[] recipeElementArray9 = new ComplexRecipe.RecipeElement[1]
        {
          new ComplexRecipe.RecipeElement((Tag) "CrabShell", 1f)
        };
        ComplexRecipe.RecipeElement[] recipeElementArray10 = new ComplexRecipe.RecipeElement[1]
        {
          new ComplexRecipe.RecipeElement(elementByHash3.tag, 10f)
        };
        new ComplexRecipe(ComplexRecipeManager.MakeRecipeID(nameof (RockCrusher), (IList<ComplexRecipe.RecipeElement>) recipeElementArray9, (IList<ComplexRecipe.RecipeElement>) recipeElementArray10), recipeElementArray9, recipeElementArray10)
        {
          time = 10f,
          description = string.Format((string) BUILDINGS.PREFABS.ROCKCRUSHER.LIME_RECIPE_DESCRIPTION, (object) SimHashes.Lime.CreateTag().ProperName(), (object) ITEMS.INDUSTRIAL_PRODUCTS.CRAB_SHELL.NAME),
          nameDisplay = ComplexRecipe.RecipeNameDisplay.IngredientToResult
        }.fabricators = new List<Tag>()
        {
          TagManager.Create(nameof (RockCrusher))
        };
        ComplexRecipe.RecipeElement[] recipeElementArray11 = new ComplexRecipe.RecipeElement[1]
        {
          new ComplexRecipe.RecipeElement(ElementLoader.FindElementByHash(SimHashes.Fossil).tag, 100f)
        };
        ComplexRecipe.RecipeElement[] recipeElementArray12 = new ComplexRecipe.RecipeElement[2]
        {
          new ComplexRecipe.RecipeElement(ElementLoader.FindElementByHash(SimHashes.Lime).tag, 5f),
          new ComplexRecipe.RecipeElement(ElementLoader.FindElementByHash(SimHashes.SedimentaryRock).tag, 95f)
        };
        new ComplexRecipe(ComplexRecipeManager.MakeRecipeID(nameof (RockCrusher), (IList<ComplexRecipe.RecipeElement>) recipeElementArray11, (IList<ComplexRecipe.RecipeElement>) recipeElementArray12), recipeElementArray11, recipeElementArray12)
        {
          time = 10f,
          description = string.Format((string) BUILDINGS.PREFABS.ROCKCRUSHER.LIME_FROM_LIMESTONE_RECIPE_DESCRIPTION, (object) SimHashes.Fossil.CreateTag().ProperName(), (object) SimHashes.SedimentaryRock.CreateTag().ProperName(), (object) SimHashes.Lime.CreateTag().ProperName()),
          nameDisplay = ComplexRecipe.RecipeNameDisplay.IngredientToResult
        }.fabricators = new List<Tag>()
        {
          TagManager.Create(nameof (RockCrusher))
        };
        float num = 5E-05f;
        ComplexRecipe.RecipeElement[] recipeElementArray13 = new ComplexRecipe.RecipeElement[1]
        {
          new ComplexRecipe.RecipeElement(SimHashes.Salt.CreateTag(), 100f)
        };
        ComplexRecipe.RecipeElement[] recipeElementArray14 = new ComplexRecipe.RecipeElement[2]
        {
          new ComplexRecipe.RecipeElement(TableSaltConfig.ID.ToTag(), 100f * num),
          new ComplexRecipe.RecipeElement(SimHashes.Sand.CreateTag(), (float) (100.0 * (1.0 - (double) num)))
        };
        new ComplexRecipe(ComplexRecipeManager.MakeRecipeID(nameof (RockCrusher), (IList<ComplexRecipe.RecipeElement>) recipeElementArray13, (IList<ComplexRecipe.RecipeElement>) recipeElementArray14), recipeElementArray13, recipeElementArray14)
        {
          time = 10f,
          description = string.Format((string) BUILDINGS.PREFABS.ROCKCRUSHER.RECIPE_DESCRIPTION, (object) SimHashes.Salt.CreateTag().ProperName(), (object) ITEMS.INDUSTRIAL_PRODUCTS.TABLE_SALT.NAME),
          nameDisplay = ComplexRecipe.RecipeNameDisplay.IngredientToResult
        }.fabricators = new List<Tag>()
        {
          TagManager.Create(nameof (RockCrusher))
        };
        Prioritizable.AddRef(go);
        return false;
      }
    }
  }
}

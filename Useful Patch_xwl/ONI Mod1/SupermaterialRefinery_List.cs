// Decompiled with JetBrains decompiler
// Type: Useful_Patch.SupermaterialRefinery_List
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using HarmonyLib;
using System.Collections.Generic;
using UnityEngine;

namespace Useful_Patch
{
  internal class SupermaterialRefinery_List
  {
    [HarmonyPatch(typeof (SupermaterialRefineryConfig), "ConfigureBuildingTemplate")]
    public class SupermaterialRefinery_AddList
    {
      public static void Postfix(GameObject go)
      {
        ComplexRecipe.RecipeElement[] recipeElementArray1 = new ComplexRecipe.RecipeElement[2]
        {
          new ComplexRecipe.RecipeElement(SimHashes.DirtyWater.CreateTag(), 100f),
          new ComplexRecipe.RecipeElement(SimHashes.Dirt.CreateTag(), 400f)
        };
        ComplexRecipe.RecipeElement[] recipeElementArray2 = new ComplexRecipe.RecipeElement[1]
        {
          new ComplexRecipe.RecipeElement(SimHashes.SlimeMold.CreateTag(), 500f)
        };
        new ComplexRecipe(ComplexRecipeManager.MakeRecipeID("SupermaterialRefinery", (IList<ComplexRecipe.RecipeElement>) recipeElementArray1, (IList<ComplexRecipe.RecipeElement>) recipeElementArray2), recipeElementArray1, recipeElementArray2)
        {
          time = 10f,
          description = "菌泥获取快捷方式",
          nameDisplay = ComplexRecipe.RecipeNameDisplay.Result
        }.fabricators = new List<Tag>()
        {
          TagManager.Create("SupermaterialRefinery")
        };
        ComplexRecipe.RecipeElement[] recipeElementArray3 = new ComplexRecipe.RecipeElement[2]
        {
          new ComplexRecipe.RecipeElement(SimHashes.SaltWater.CreateTag(), 100f),
          new ComplexRecipe.RecipeElement(SimHashes.Sand.CreateTag(), 400f)
        };
        ComplexRecipe.RecipeElement[] recipeElementArray4 = new ComplexRecipe.RecipeElement[1]
        {
          new ComplexRecipe.RecipeElement(SimHashes.Phosphorite.CreateTag(), 500f)
        };
        new ComplexRecipe(ComplexRecipeManager.MakeRecipeID("SupermaterialRefinery", (IList<ComplexRecipe.RecipeElement>) recipeElementArray3, (IList<ComplexRecipe.RecipeElement>) recipeElementArray4), recipeElementArray3, recipeElementArray4)
        {
          time = 10f,
          description = "磷矿获取快捷方式",
          nameDisplay = ComplexRecipe.RecipeNameDisplay.Result
        }.fabricators = new List<Tag>()
        {
          TagManager.Create("SupermaterialRefinery")
        };
        ComplexRecipe.RecipeElement[] recipeElementArray5 = new ComplexRecipe.RecipeElement[2]
        {
          new ComplexRecipe.RecipeElement(SimHashes.Water.CreateTag(), 200f),
          new ComplexRecipe.RecipeElement(SimHashes.Carbon.CreateTag(), 300f)
        };
        ComplexRecipe.RecipeElement[] recipeElementArray6 = new ComplexRecipe.RecipeElement[1]
        {
          new ComplexRecipe.RecipeElement(SimHashes.Diamond.CreateTag(), 500f)
        };
        new ComplexRecipe(ComplexRecipeManager.MakeRecipeID("SupermaterialRefinery", (IList<ComplexRecipe.RecipeElement>) recipeElementArray5, (IList<ComplexRecipe.RecipeElement>) recipeElementArray6), recipeElementArray5, recipeElementArray6)
        {
          time = 10f,
          description = "钻石获取快捷方式",
          nameDisplay = ComplexRecipe.RecipeNameDisplay.Result
        }.fabricators = new List<Tag>()
        {
          TagManager.Create("SupermaterialRefinery")
        };
        ComplexRecipe.RecipeElement[] recipeElementArray7 = new ComplexRecipe.RecipeElement[3]
        {
          new ComplexRecipe.RecipeElement(SimHashes.TempConductorSolid.CreateTag(), 10f),
          new ComplexRecipe.RecipeElement(SimHashes.SuperInsulator.CreateTag(), 10f),
          new ComplexRecipe.RecipeElement(SimHashes.Diamond.CreateTag(), 30f)
        };
        ComplexRecipe.RecipeElement[] recipeElementArray8 = new ComplexRecipe.RecipeElement[1]
        {
          new ComplexRecipe.RecipeElement(TagManager.Create("GeneShufflerRecharge"), 1f)
        };
        new ComplexRecipe(ComplexRecipeManager.MakeRecipeID("SupermaterialRefinery", (IList<ComplexRecipe.RecipeElement>) recipeElementArray7, (IList<ComplexRecipe.RecipeElement>) recipeElementArray8), recipeElementArray7, recipeElementArray8)
        {
          time = 10f,
          description = "震荡充电器获取快捷方式",
          nameDisplay = ComplexRecipe.RecipeNameDisplay.Result
        }.fabricators = new List<Tag>()
        {
          TagManager.Create("SupermaterialRefinery")
        };
      }
    }
  }
}

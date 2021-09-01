// Decompiled with JetBrains decompiler
// Type: MolecularForge.MolecularForgePatches
// Assembly: MolecularForge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4C951792-F10F-4A61-8C43-785FF79DC05B
// Assembly location: D:\Devlop\ONI_ORI_MOD\fenzi\MolecularForge.dll

using HarmonyLib;
using System.Collections.Generic;

namespace MolecularForge
{
  public class MolecularForgePatches
  {
    [HarmonyPatch(typeof (SupermaterialRefineryConfig))]
    [HarmonyPatch("ConfigureBuildingTemplate")]
    public class SupermaterialRefineryConfig_ConfigureBuildingTemplate_Patch
    {
      public static void Postfix()
      {
        ComplexRecipe.RecipeElement[] recipeElementArray1 = new ComplexRecipe.RecipeElement[1]
        {
          new ComplexRecipe.RecipeElement(SimHashes.SedimentaryRock.CreateTag(), 1000f)
        };
        ComplexRecipe.RecipeElement[] recipeElementArray2 = new ComplexRecipe.RecipeElement[1]
        {
          new ComplexRecipe.RecipeElement(SimHashes.Salt.CreateTag(), 5000f)
        };
        ComplexRecipe complexRecipe1 = new ComplexRecipe(ComplexRecipeManager.MakeRecipeID("SupermaterialRefinery", (IList<ComplexRecipe.RecipeElement>) recipeElementArray1, (IList<ComplexRecipe.RecipeElement>) recipeElementArray2), recipeElementArray1, recipeElementArray2)
        {
          time = 80f,
          description = "for food and rust deoxidizer. ",
          nameDisplay = ComplexRecipe.RecipeNameDisplay.Result,
          fabricators = new List<Tag>()
          {
            TagManager.Create("SupermaterialRefinery")
          }
        };
        ComplexRecipe.RecipeElement[] recipeElementArray3 = new ComplexRecipe.RecipeElement[1]
        {
          new ComplexRecipe.RecipeElement(SimHashes.MaficRock.CreateTag(), 1000f)
        };
        ComplexRecipe.RecipeElement[] recipeElementArray4 = new ComplexRecipe.RecipeElement[1]
        {
          new ComplexRecipe.RecipeElement(SimHashes.Fertilizer.CreateTag(), 5000f)
        };
        ComplexRecipe complexRecipe2 = new ComplexRecipe(ComplexRecipeManager.MakeRecipeID("SupermaterialRefinery", (IList<ComplexRecipe.RecipeElement>) recipeElementArray3, (IList<ComplexRecipe.RecipeElement>) recipeElementArray4), recipeElementArray3, recipeElementArray4)
        {
          time = 80f,
          description = "to make crops grow faster.",
          nameDisplay = ComplexRecipe.RecipeNameDisplay.Result,
          fabricators = new List<Tag>()
          {
            TagManager.Create("SupermaterialRefinery")
          }
        };
        ComplexRecipe.RecipeElement[] recipeElementArray5 = new ComplexRecipe.RecipeElement[1]
        {
          new ComplexRecipe.RecipeElement(SimHashes.Granite.CreateTag(), 1000f)
        };
        ComplexRecipe.RecipeElement[] recipeElementArray6 = new ComplexRecipe.RecipeElement[1]
        {
          new ComplexRecipe.RecipeElement(SimHashes.Isoresin.CreateTag(), 5000f)
        };
        ComplexRecipe complexRecipe3 = new ComplexRecipe(ComplexRecipeManager.MakeRecipeID("SupermaterialRefinery", (IList<ComplexRecipe.RecipeElement>) recipeElementArray5, (IList<ComplexRecipe.RecipeElement>) recipeElementArray6), recipeElementArray5, recipeElementArray6)
        {
          time = 80f,
          description = "to insolate heat air. ",
          nameDisplay = ComplexRecipe.RecipeNameDisplay.Result,
          fabricators = new List<Tag>()
          {
            TagManager.Create("SupermaterialRefinery")
          }
        };
        ComplexRecipe.RecipeElement[] recipeElementArray7 = new ComplexRecipe.RecipeElement[1]
        {
          new ComplexRecipe.RecipeElement(SimHashes.IgneousRock.CreateTag(), 1000f)
        };
        ComplexRecipe.RecipeElement[] recipeElementArray8 = new ComplexRecipe.RecipeElement[1]
        {
          new ComplexRecipe.RecipeElement(SimHashes.Fullerene.CreateTag(), 500f)
        };
        ComplexRecipe complexRecipe4 = new ComplexRecipe(ComplexRecipeManager.MakeRecipeID("SupermaterialRefinery", (IList<ComplexRecipe.RecipeElement>) recipeElementArray7, (IList<ComplexRecipe.RecipeElement>) recipeElementArray8), recipeElementArray7, recipeElementArray8)
        {
          time = 80f,
          description = "the ingredient of supercooler",
          nameDisplay = ComplexRecipe.RecipeNameDisplay.Result,
          fabricators = new List<Tag>()
          {
            TagManager.Create("SupermaterialRefinery")
          }
        };
        ComplexRecipe.RecipeElement[] recipeElementArray9 = new ComplexRecipe.RecipeElement[1]
        {
          new ComplexRecipe.RecipeElement(SimHashes.Obsidian.CreateTag(), 1000f)
        };
        ComplexRecipe.RecipeElement[] recipeElementArray10 = new ComplexRecipe.RecipeElement[1]
        {
          new ComplexRecipe.RecipeElement(SimHashes.Niobium.CreateTag(), 5000f)
        };
        ComplexRecipe complexRecipe5 = new ComplexRecipe(ComplexRecipeManager.MakeRecipeID("SupermaterialRefinery", (IList<ComplexRecipe.RecipeElement>) recipeElementArray9, (IList<ComplexRecipe.RecipeElement>) recipeElementArray10), recipeElementArray9, recipeElementArray10)
        {
          time = 80f,
          description = "high temperature resistant",
          nameDisplay = ComplexRecipe.RecipeNameDisplay.Result,
          fabricators = new List<Tag>()
          {
            TagManager.Create("SupermaterialRefinery")
          }
        };
        ComplexRecipe.RecipeElement[] recipeElementArray11 = new ComplexRecipe.RecipeElement[1]
        {
          new ComplexRecipe.RecipeElement(SimHashes.Regolith.CreateTag(), 1000f)
        };
        ComplexRecipe.RecipeElement[] recipeElementArray12 = new ComplexRecipe.RecipeElement[1]
        {
          new ComplexRecipe.RecipeElement(SimHashes.Lime.CreateTag(), 500f)
        };
        ComplexRecipe complexRecipe6 = new ComplexRecipe(ComplexRecipeManager.MakeRecipeID("SupermaterialRefinery", (IList<ComplexRecipe.RecipeElement>) recipeElementArray11, (IList<ComplexRecipe.RecipeElement>) recipeElementArray12), recipeElementArray11, recipeElementArray12)
        {
          time = 80f,
          description = "to make steel",
          nameDisplay = ComplexRecipe.RecipeNameDisplay.Result,
          fabricators = new List<Tag>()
          {
            TagManager.Create("SupermaterialRefinery")
          }
        };
      }
    }
  }
}

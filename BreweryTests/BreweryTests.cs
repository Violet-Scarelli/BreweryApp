﻿using NUnit.Framework;
using BreweryApp.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BreweryTests
{
	[TestFixture]
	public class BreweryTests
	{
		BreweryAppContext dbContext;

		[SetUp]
		public void Setup()
		{
			dbContext = new BreweryAppContext();
		}
		[Test]
		public void GetIngredientsTest()
		{
			List<Ingredient> ingredients = dbContext.Ingredients.OrderBy(i => i.IngredientId).ToList();
			Assert.AreEqual(1149, ingredients.Count);
			Assert.AreEqual(ingredients[102].OnHandQuantity, 5.443104);
			Assert.AreEqual(ingredients[105].Name, "Pale Malt, Maris Otter");
		}
		[Test]
		public void GetRecipesTest()
		{
			List<Recipe> recipes = dbContext.Recipes.OrderBy(i => i.RecipeId).ToList();
			List<Ingredient> ingredients = dbContext.Ingredients.OrderBy(i => i.IngredientId).ToList();
			Assert.AreEqual(4, recipes.Count);
			Assert.AreEqual(recipes[0].Name, "Fuzzy Tales Juicy IPA");
			Console.WriteLine(recipes[0].Name);
			List<RecipeIngredient> selectedIngredients = dbContext.RecipeIngredients.Where(ingredient => ingredient.RecipeId == recipes[0].RecipeId).ToList();
			foreach(var ingredient in selectedIngredients)
			{
				Console.WriteLine(ingredients[ingredient.IngredientId].Name);
			}
		}

	}
}
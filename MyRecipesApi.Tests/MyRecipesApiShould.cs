using System;
using System.Collections.Generic;
using FluentAssertions;
using MyRecipesApi.Controllers;
using Xunit;

namespace MyRecipesApi.Tests
{
    public class MyRecipesApiShould
    {
        [Fact]
        public void AddRecipe()
        {
            RecipeRepository recipeRepository = new();
            recipeRepository.AddRecipe(new Recipe("Pimientos con patatas"));
            RecipesController recipesController = new(recipeRepository);
            
            var responseBody = recipesController.ListRecipes();

            List<Recipe> expectedRecipes = new List<Recipe>();
            expectedRecipes.Add(new Recipe("Pimientos con patatas"));
            responseBody.Should().BeEquivalentTo(expectedRecipes);
        }
    }
}
using System;
using Xunit;

namespace MyRecipesApi.Tests
{
    public class MyRecipesApiShould
    {
        [Fact]
        public void AddRecipe()
        {
            //Recipes es el nombre de la clase, y recipes es la instancia del objeto
            //Arrange
            var recipes = new Recipes();
            //Act -> recipes.Add()
            recipes.AddRecipe("Pimientos con patatas");
            //Assert
            Assert.Equal("Pimientos con patatas",recipes.CheckRecipe("Pimientos con patatas"));
        }
    }
}
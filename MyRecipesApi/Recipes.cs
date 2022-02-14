using System.Collections.Generic;

namespace MyRecipesApi
{
    public class Recipes
    {
        private List<string> _myRecipes = new();

        public void AddRecipe(string recipe)
        {
            //Atributos en minúscula y con barra baja al inicio
            _myRecipes.Add(recipe);
        }

        public string CheckRecipe(string recipe)
        {
            foreach (string recipeInList in _myRecipes)
            {
                if (recipeInList.Contains(recipe))
                    return recipeInList;
            }

            return "";
        }
    }
}
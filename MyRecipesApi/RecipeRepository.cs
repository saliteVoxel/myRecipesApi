using System.Collections.Generic;

namespace MyRecipesApi
{
    public class RecipeRepository : IRepository
    {
        //solo se puede asignar una vez la referencia, no se puede instanciar de nuevo
        private readonly List<Recipe> _recipes = new (); 
        public void AddRecipe(Recipe recipe)
        {
            _recipes.Add(recipe);
        }

        public List<Recipe> FindAll()
        {
            return _recipes;
        }
    }
}
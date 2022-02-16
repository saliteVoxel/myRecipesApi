using System.Collections.Generic;

namespace MyRecipesApi.Controllers
{
    public class RecipesController
    {
        private readonly RecipeRepository _recipeRepository;

        public RecipesController(RecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        public List<Recipe> ListRecipes()
        {
            return _recipeRepository.FindAll();
        }
    }
}
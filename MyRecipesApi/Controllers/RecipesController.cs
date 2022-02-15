namespace MyRecipesApi.Controllers
{
    public class RecipesController
    {
        private readonly RecipeRepository _recipeRepository;

        public RecipesController(RecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        public object ListRecipes()
        {
            throw new System.NotImplementedException();
        }
    }
}
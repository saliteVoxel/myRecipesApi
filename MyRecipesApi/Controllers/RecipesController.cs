using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MyRecipesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipesController : ControllerBase
    {
        private readonly RecipeRepository _recipeRepository;

        public RecipesController(RecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        [HttpGet]
        public List<Recipe> ListRecipes()
        {
            return _recipeRepository.FindAll();
        }
    }
}
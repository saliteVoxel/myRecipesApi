using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MyRecipesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipesController : ControllerBase
    {
        private readonly MockRecipeRepository _mockRecipeRepository;

        public RecipesController(MockRecipeRepository mockRecipeRepository)
        {
            _mockRecipeRepository = mockRecipeRepository;
        }

        [HttpGet]
        [Route("ListRecipe")]
        public List<Recipe> ListRecipes()
        {
            return _mockRecipeRepository.FindAll();
        }
    }
}
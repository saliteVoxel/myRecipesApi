using System.Collections.Generic;

namespace MyRecipesApi
{
    public interface IRepository
    {
        void AddRecipe(Recipe recipe);
        List<Recipe> FindAll();
    }
}
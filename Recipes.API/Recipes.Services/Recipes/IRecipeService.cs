using Recipes.Models.Recipe;

namespace Recipes.Services.Recipes
{
    public interface IRecipeService
    {
        IEnumerable<Recipe> GetAllRecipes();
    }
}

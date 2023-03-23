using Microsoft.AspNetCore.Mvc;
using Recipes.Models.Recipe;
using Recipes.Services.Recipes;

namespace Recipes.API.Controllers
{
    [Route("[controller]/[action]")]
    public class RecipeController : Controller
    {
        private readonly IRecipeService recipeService;

        public RecipeController(IRecipeService recipeService)
        {
            this.recipeService = recipeService;
        }

        public IEnumerable<Recipe> Index()
        {
            return this.recipeService.GetAllRecipes();
        }
    }
}

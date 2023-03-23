using Recipes.Models.Recipe;

namespace Recipes.Services.Recipes
{
    public class RecipeService : IRecipeService
    {
        public IEnumerable<Recipe> GetAllRecipes()
        {
            var products = new List<Recipe>()
            {
                new Recipe()
                {
                    Name = "Cheeseburger",
                    Servings = 1,
                    Ingredients = "1 hamburger roll, 100g freshly ground beef chuck, 1 slice cheddar",
                    PreparationSteps = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."
                },
                new Recipe()
                {
                    Name = "Pizza Margherita",
                    Servings = 1,
                    Ingredients = "100g pizza dough, mozzarella, tomato sauce, basil",
                    PreparationSteps = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."
                },
                new Recipe()
                {
                    Name = "Hot Chocolate",
                    Servings = 1,
                    Ingredients = "milk, milk chocolate, sugar, vanilla extract",
                    PreparationSteps = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."
                }
            };

            return products;
        }
    }
}

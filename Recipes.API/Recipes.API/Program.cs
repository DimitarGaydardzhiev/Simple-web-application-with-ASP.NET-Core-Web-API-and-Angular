using Recipes.Services.Recipes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IRecipeService, RecipeService>();

const string AllowSpecificOriginsCors = "AllowSpecificOrigins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(AllowSpecificOriginsCors,
        builder =>
        {
            builder.WithOrigins("http://localhost:4200")
                .AllowAnyMethod();
        });
});

var app = builder.Build();
app.UseCors(AllowSpecificOriginsCors);

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();

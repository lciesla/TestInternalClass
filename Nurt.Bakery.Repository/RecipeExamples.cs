using Nurt.Bakery.Model;

namespace Nurt.Bakery.Repository
{
    public static class RecipeExamples
    {
        public static readonly Recipe RecipeChlebDlaZaoranych = new Recipe
        {
            Id = 1,
            Name = "chleb dla zaoranych",
            Description = "chleb 100% żytni razowy, wielofazowo zakwaszany",
            RecipeItems =
            {
                new RecipeItem
                {
                    Ingredient = IngredientExamples.Water,
                    Mass = 350,
                },
                new RecipeItem
                {
                    Ingredient = IngredientExamples.RyeFlour,
                    Mass = 250,
                },
                new RecipeItem
                {
                    Ingredient = IngredientExamples.RyeBran,
                    Mass = 150,
                },
                new RecipeItem
                {
                    Ingredient = IngredientExamples.Salt,
                    Mass = 8,
                },
                new RecipeItem
                {
                    Ingredient = IngredientExamples.RyeSourdough,
                    Mass = 6,
                },
            },
        };

        public static readonly Recipe RecipeChlebKociewski = new Recipe
        {
            Id = 1,
            Name = "chleb kociewski",
            Description = "chleb 100% żytni razowy, wielofazowo zakwaszany",
            RecipeItems =
            {
                new RecipeItem
                {
                    Ingredient = IngredientExamples.Water,
                    Mass = 350,
                },
                new RecipeItem
                {
                    Ingredient = IngredientExamples.RyeFlour,
                    Mass = 400,
                },
                new RecipeItem
                {
                    Ingredient = IngredientExamples.Salt,
                    Mass = 8,
                },
                new RecipeItem
                {
                    Ingredient = IngredientExamples.RyeSourdough,
                    Mass = 6,
                },
            },
        };
    }

}

using Nurt.Bakery.Model;

namespace Nurt.Bakery.Repository
{
    public static class IngredientExamples
    {
        public static Ingredient Water { get; } = new Ingredient
        {
            Id = 1,
            Name = "Woda źródlana",
        };

        public static Ingredient RyeFlour { get; } = new Ingredient
        {
            Id = 2,
            Name = "Mąka żytnia",
        };
        public static Ingredient RyeBran { get; } = new Ingredient
        {
            Id = 3,
            Name = "Otręby żytnie",
        };
        public static Ingredient Salt { get; } = new Ingredient
        {
            Id = 4,
            Name = "Sól morska",
        };
        public static Ingredient RyeSourdough { get; } = new Ingredient
        {
            Id = 5,
            Name = "Zakwas żytni",
        };
    }

}

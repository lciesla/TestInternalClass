using Nurt.Bakery.Model;
using System.Collections.Generic;

namespace Nurt.Bakery.Repository
{
    public class RecipeRepository
    {
        private static readonly Recipe Recipe1 = RecipeExamples.RecipeChlebDlaZaoranych;
        private static readonly Recipe Recipe2 = RecipeExamples.RecipeChlebKociewski;


        private IDictionary<long, Recipe> repo = new Dictionary<long, Recipe>
        {
            {Recipe1.Id, Recipe1},
            {Recipe2.Id, Recipe2},
        };

        public Recipe Get(long id)
        {
            return repo[id];
        }

        public void Add(Recipe recipe)
        {
            repo[recipe.Id]=recipe;
        }
    }

}

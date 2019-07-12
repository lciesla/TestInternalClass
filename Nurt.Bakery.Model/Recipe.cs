using System.Collections.Generic;

namespace Nurt.Bakery.Model
{
    public class Recipe
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<RecipeItem> RecipeItems { get; set; }
    }
}

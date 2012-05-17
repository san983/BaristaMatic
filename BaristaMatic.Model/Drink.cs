using System.Collections.Generic;
using System.Linq;

namespace BaristaMatic.Model
{
    public class Drink
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Ingredient> Ingredients { get; set; }

        public string GetUSFormattedCost()
        {
            var result = Ingredients.Sum(ingredient => ingredient.GetCostByIngredient());
            return result.ToString("C");
        }
    }
}
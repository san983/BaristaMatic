using System.Collections.Generic;
using System.Linq;

namespace BaristaMatic.Model
{
    public class Drink
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Ingredient> Ingredients { get; set; }

        public string GetCost()
        {
            var aa = Ingredients.Sum(ingredient => ingredient.UnitCost * ingredient.Units).ToString("C");

            return aa;
        }

        public bool IsAvailable()
        {
            return true;
        }
    }
}
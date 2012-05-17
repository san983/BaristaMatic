namespace BaristaMatic.Model
{
    public class Ingredient
    {
        public string Name { get; set; }

        public int Units { get; set; }

        public decimal UnitCost { get; set; }

        public decimal GetCostByIngredient()
        {
            return UnitCost * Units;
        }
    }
}

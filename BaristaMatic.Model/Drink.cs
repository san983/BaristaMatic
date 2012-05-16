namespace BaristaMatic.Model
{
    public class Drink
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string GetCost()
        {
            return "$0.00";
        }

        public bool IsAvailable()
        {
            return true;
        }
    }
}
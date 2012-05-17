using BaristaMatic.Model;

namespace BaristaMatic.Console
{
    public class Program
    {
        public static void Main()
        {
            var baristaMagicMachine = new CoffeeMachine();
            baristaMagicMachine.Run();
        }
    }
}

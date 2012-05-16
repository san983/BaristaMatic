using BaristaMatic.Model;

namespace BaristaMatic.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var baristaMagic = new CoffeeMachine();

            baristaMagic.Run();
            
            //System.Console.ReadKey();
        }
    }
}

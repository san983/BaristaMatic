using BaristaMatic.Model;

namespace BaristaMatic.Console
{
    public class Program
    {
        CoffeeMachine _baristaMagic;

        public static void Main()
        {
            new Program
            {
                _baristaMagic = new CoffeeMachine()
            }.Run();
        }

        void Run()
        {
            _baristaMagic.Run();
        }
    }
}

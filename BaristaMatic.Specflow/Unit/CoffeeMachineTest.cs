using BaristaMatic.Model;
using NUnit.Framework;

namespace BaristaMatic.Specflow.Specs
{
    [TestFixture]
    public class CoffeeMachineSpec
    {
        [Test]
        public void ShouldCreateCoffeeMachine()
        {
            var coffeeMachine = new CoffeeMachine();
            Assert.IsInstanceOf<CoffeeMachine>(coffeeMachine);
        }
    }
}

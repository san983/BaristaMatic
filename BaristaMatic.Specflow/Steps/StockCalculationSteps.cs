using System.Linq;
using BaristaMatic.Model;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BaristaMatic.Specflow.Steps
{
    [Binding]
    public class StockCalculationSteps
    {
        private CoffeeMachine _coffeeMachine;

        [Given("a full loaded barista matic coffee machine")]
        public void GivenAFullLoadedBaristaMaticCoffeeMachine()
        {
            _coffeeMachine = new CoffeeMachine();
        }

        [When("I start the machine")]
        public void WhenIStartTheMachine()
        {
        }

        [When("I press (.*)")]
        public void WhenIPress(string selection)
        {
            _coffeeMachine.SelectOption(selection);
        }

        [Then("the delivery status should be (.*)")]
        public void ThenTheDeliveryStatusShouldBe(bool result)
        {
            Assert.That(_coffeeMachine.DeliveryStatus, Is.EqualTo(result));
        }

        [Then("the stock should be")]
        public void ThenTheStockShouldBe(Table table)
        {
            foreach (var row in table.Rows)
            {
                var key = row["Ingredient"];
                var units = row["Units"];
                
                var ingredient = _coffeeMachine.Ingredients.FirstOrDefault(t => t.Name == key);

                Assert.That(ingredient.Units.ToString(), Is.EqualTo(units));
            }
        }

        [Then("the stock and unit cost should be")]
        public void ThenTheStockAndUnitCostShouldBe(Table table)
        {
            foreach (var row in table.Rows)
            {
                var key = row["Ingredient"];
                var units = row["Units"];
                var unitCost = row["UnitCost"];

                var ingredient = _coffeeMachine.Ingredients.FirstOrDefault(t => t.Name == key);
      
                Assert.That(ingredient.Units.ToString(), Is.EqualTo(units));
                Assert.That(ingredient.UnitCost.ToString(), Is.EqualTo(unitCost));
            }
        }
    }
}

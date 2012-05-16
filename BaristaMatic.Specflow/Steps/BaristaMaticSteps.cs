using System.Globalization;
using BaristaMatic.Model;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BaristaMatic.Specflow.Steps
{
    [Binding]
    public class BaristaMaticSteps
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
                var value = row["Units"];

                var currentStock = _coffeeMachine.Ingredients[key].ToString(CultureInfo.InvariantCulture);

                Assert.That(currentStock, Is.EqualTo(value));
            }
        }
    }
}

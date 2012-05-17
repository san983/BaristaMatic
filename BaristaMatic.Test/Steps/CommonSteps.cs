using System;
using System.Globalization;
using System.Linq;
using BaristaMatic.Model;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BaristaMatic.Test.Steps
{
    [Binding]
    public class CommonSteps
    {
        private CoffeeMachine _coffeeMachine;

        [Given("a full loaded barista matic coffee machine")]
        public void GivenAFullLoadedBaristaMaticCoffeeMachine()
        {
            _coffeeMachine = new CoffeeMachine();
        }

        [When("I press (.*)")]
        public void WhenIPress(string selection)
        {
            _coffeeMachine.RunWithSelection(selection);
        }

        [Then("the stock should be")]
        public void ThenTheStockShouldBe(Table table)
        {
            foreach (var row in table.Rows)
            {
                var key = row["Ingredient"];
                var units = row["Units"];
                
                var ingredient = _coffeeMachine.Ingredients.FirstOrDefault(t => t.Name == key);

                Assert.That(ingredient.Units.ToString(CultureInfo.InvariantCulture), Is.EqualTo(units));
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

        [Then("the console output should read like this")]
        public void ThenTheConsoleOutputShouldBe(Table table)
        {
            var expected = ParseInventoryTable(table);
            Assert.AreEqual(expected, _coffeeMachine.GetConsoleOut());
        }

        private static string ParseInventoryTable(Table table)
        {
            return table.Rows.Select(row => row["OutputLine"]).Aggregate("", (current, line) => current + line + Environment.NewLine);
        }
    }
}

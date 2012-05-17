using BaristaMatic.Model;
using NUnit.Framework;

namespace BaristaMatic.Test.Unit
{
    [TestFixture]
    public class IngredientTest
    {
        private Ingredient _ingredient;

        private const string JustAIngredientName = "Just A Ingredient Name";
        private const decimal InitialUnitCost = 1.10m;
        private const int InitialUnits = 3;

        [SetUp]
        public void TestFixtureSetUp()
        {
            _ingredient = new Ingredient 
            {  
                Name = JustAIngredientName,
                UnitCost = InitialUnitCost,
                Units = InitialUnits
            };
        }

        [Test]
        public void TestIngredientShouldHaveNameUnitCostAndUnits()
        {
            Assert.AreEqual(JustAIngredientName, _ingredient.Name);
            Assert.AreEqual(InitialUnitCost, _ingredient.UnitCost);
            Assert.AreEqual(InitialUnits, _ingredient.Units);
        }

        [Test]
        public void TestGetCostByIngredient()
        {
            Assert.AreEqual(3.30m,_ingredient.GetCostByIngredient());
        }
    }
}
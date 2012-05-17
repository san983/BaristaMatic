using System.Collections.Generic;
using BaristaMatic.Model;
using NUnit.Framework;

namespace BaristaMatic.Test.Unit
{
    [TestFixture]
    public class DrinkTest
    {
        private Drink _drink;

        private const int InitialId = 1;
        private const string JustADrinktName = "Just A Drink Name";
        private const decimal InitialUnitCost = 1.10m;
        private const int InitialUnits = 1;

        [SetUp]
        public void TestFixtureSetUp()
        {
            _drink = new Drink
                              {
                                  Name = JustADrinktName,
                                  Id = 1,
                                  Ingredients = Ingredients()
                              };
        }

        [Test]
        public void ShouldHaveNameIdAndIngredients()
        {
            Assert.AreEqual(JustADrinktName, _drink.Name);

            Assert.AreEqual(InitialId, _drink.Id);
            Assert.AreEqual(Ingredients().Count, _drink.Ingredients.Count);
        }

        [Test]
        public void ShouldGetUSFormattedCost()
        {
            const decimal expected = 5.50m;
            Assert.AreEqual(expected.ToString("C"),_drink.GetUSFormattedCost());
        }

        private static List<Ingredient> Ingredients()
        {
            const string justAnIngredientName = "Just An Ingredient";

            var ingredient1 = new Ingredient
                        {
                            Name = justAnIngredientName,
                            UnitCost = InitialUnitCost,
                            Units = InitialUnits
                        };

            var ingredient2 = new Ingredient
                        {
                            Name = justAnIngredientName + " More",
                            UnitCost = InitialUnitCost*2,
                            Units = InitialUnits*2
                        };

            return new List<Ingredient> { ingredient1, ingredient2 };
        }
    }
}
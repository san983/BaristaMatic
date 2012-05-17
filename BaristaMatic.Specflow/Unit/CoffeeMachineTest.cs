using System.Collections.Generic;
using BaristaMatic.Model;
using NUnit.Framework;

namespace BaristaMatic.Specflow.Unit
{
    [TestFixture]
    public class CoffeeMachineTest
    {
        private CoffeeMachine _coffeeMachine;
        private Drink _myCoffeeDrink;
        const string JustAIngredient = "Just A Ingredient";

        [SetUp]
        public void TestFixtureSetUp()
        {
            _coffeeMachine = new CoffeeMachine {Ingredients = IngredientsForStock()};

            _myCoffeeDrink = new Drink
            {
                Id = 1,
                Ingredients = IngredientsForRecipe(),
                Name = "Caffee Santo"
            };
        }
        
        [Test]
        public void ShouldCreateCoffeeMachine()
        {
            Assert.IsInstanceOf<CoffeeMachine>(_coffeeMachine);
        }

        [Test]
        public void ShouldCheckIfADrinkWithOneIngredientIsAvailable()
        {
            Assert.IsTrue(_coffeeMachine.IsDrinkAvailable(_myCoffeeDrink));

            _coffeeMachine.Ingredients[0].Units = 1;
            Assert.IsTrue(_coffeeMachine.IsDrinkAvailable(_myCoffeeDrink));
        }

        [Test]
        public void ShouldCheckIfADrinkWithOneIngredientIsNotAvailable()
        {
            _coffeeMachine.Ingredients[0].Units = 0;
            Assert.IsFalse(_coffeeMachine.IsDrinkAvailable(_myCoffeeDrink));
        }

        [Test]
        public void ShouldRestockTheIngredients()
        {
            const int stockToTest = 25;

            //Goes to -1 just for test porpouses
            _coffeeMachine.Ingredients[0].Units = -1;

            _coffeeMachine.RestockMachine(stockToTest);

            Assert.AreEqual(stockToTest, _coffeeMachine.Ingredients[0].Units);
        }

        private static List<Ingredient> IngredientsForStock()
        {
            var ingredientForStock = new Ingredient
            {
                Name = JustAIngredient,
                Units = 2
            };

            return new List<Ingredient> { ingredientForStock };
        }

        private static List<Ingredient> IngredientsForRecipe()
        {
            var ingredientForRecipe = new Ingredient
            {
                Name = JustAIngredient,
                Units = 1
            };

            return new List<Ingredient> { ingredientForRecipe };
        }
    }
}

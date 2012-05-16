using System.Collections.Generic;
using System.Linq;

namespace BaristaMatic.Model
{
    public class CoffeeMachine
    {
        public CoffeeMachine()
        {
            Ingredients = InitializeIngredientsList();
            Drinks = InitializeDrinksList();
        }

        private static List<Drink> InitializeDrinksList()
        {
            var drinksList = new List<Drink>
                           {
                               new Drink { Id = 1, Name = "Caffe Americano" },
                               new Drink { Id = 2, Name = "Caffe Latte" },
                               new Drink { Id = 3, Name = "Caffe Mocha" },
                               new Drink { Id = 4, Name = "Cappuccino" },
                               new Drink { Id = 5, Name = "Coffee" },
                               new Drink { Id = 6, Name = "Decaf Coffee" }
                           };

            return drinksList;
        }

        public bool DeliveryStatus
        {
            get { return true; }
        }

        public IList<Ingredient> Ingredients;
        private IList<Drink> Drinks;

        public void SelectOption(string selection)
        {
            switch (selection.ToUpper())
            {
                case "1":
                    PrepareCoffee();
                    break;

                case "2":
                    PrepareDecafCoffee();
                    break;

                case "3":
                    PrepareCaffeLatte();
                    break;

                case "4":
                    PrepareCaffeAmericano();
                    break;

                case "5":
                    PrepareCaffeMocha();
                    break;

                case "6":
                    PrepareCapuccino();
                    break;

                case "R":
                    Restock();
                    break;

            }
        }

        private void Restock()
        {


            Ingredients = InitializeIngredientsList();
        }

        private void PrepareCaffeMocha()
        {
            Ingredients.FirstOrDefault(t => t.Name == "Espresso").Units -= 1;
            Ingredients.FirstOrDefault(t => t.Name == "Cocoa").Units -= 1;
            Ingredients.FirstOrDefault(t => t.Name == "Steamed Milk").Units -= 1;
            Ingredients.FirstOrDefault(t => t.Name == "Whipped Cream").Units -= 1;
        }

        private void PrepareCapuccino()
        {
            Ingredients.FirstOrDefault(t => t.Name == "Espresso").Units -= 2;
            Ingredients.FirstOrDefault(t => t.Name == "Steamed Milk").Units -= 1;
            Ingredients.FirstOrDefault(t => t.Name == "Foamed Milk").Units -= 1;
        }

        private void PrepareCaffeAmericano()
        {
            Ingredients.FirstOrDefault(t => t.Name == "Espresso").Units -= 3;
        }

        private void PrepareCaffeLatte()
        {
            Ingredients.FirstOrDefault(t => t.Name == "Espresso").Units -= 2;
            Ingredients.FirstOrDefault(t => t.Name == "Steamed Milk").Units -= 1;
        }

        private void PrepareDecafCoffee()
        {
            Ingredients.FirstOrDefault(t => t.Name == "Decaf Coffee").Units -= 3;
            Ingredients.FirstOrDefault(t => t.Name == "Sugar").Units -= 1;
            Ingredients.FirstOrDefault(t => t.Name == "Cream").Units -= 1;
        }

        private void PrepareCoffee()
        {
            Ingredients.FirstOrDefault(t => t.Name == "Coffee").Units -= 3;
            Ingredients.FirstOrDefault(t => t.Name == "Sugar").Units -= 1;
            Ingredients.FirstOrDefault(t => t.Name == "Cream").Units -= 1;
        }

        private static List<Ingredient> InitializeIngredientsList()
        {
            return new List<Ingredient>
                       {
                            new Ingredient { Name = "Coffee", Units = 10, UnitCost = 0.75m},
                            new Ingredient { Name = "Decaf Coffee", Units = 10, UnitCost = 0.75m},
                            new Ingredient { Name = "Sugar", Units = 10, UnitCost = 0.25m},
                            new Ingredient { Name = "Cream", Units = 10, UnitCost = 0.25m},
                            new Ingredient { Name = "Steamed Milk", Units = 10, UnitCost = 0.35m},
                            new Ingredient { Name = "Foamed Milk", Units = 10, UnitCost = 0.35m},
                            new Ingredient { Name = "Espresso", Units = 10, UnitCost = 1.10m},
                            new Ingredient { Name = "Cocoa", Units = 10, UnitCost = 0.90m},
                            new Ingredient { Name = "Whipped Cream", Units = 10, UnitCost = 1.00m}
                       };
        }

        public void Run()
        {
            DisplayIngredientsStock();
            DisplayMenu();
        }

        private void DisplayIngredientsStock()
        {
            ConsoleWrite("Inventory:");

            foreach (var newLine in Ingredients.OrderBy(t => t.Name).Select(ingredient => string.Format("{0},{1}", ingredient.Name, ingredient.Units)))
            {
                ConsoleWrite(newLine);
            }
        }

        private void DisplayMenu()
        {
            ConsoleWrite("Menu:");
            foreach (var drink in Drinks.OrderBy(t => t.Id))
            {
                var newline = string.Format("{0},{1},{2},{3}", drink.Id, drink.Name, drink.GetCost(), drink.IsAvailable().ToString() ); 
                ConsoleWrite(newline);
            }
        }

        private static void ConsoleWrite(string line)
        {
            System.Console.WriteLine(line);
        }
    }
}

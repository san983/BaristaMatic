using System;
using System.Collections.Generic;
using System.Linq;

namespace BaristaMatic.Model
{
    public class CoffeeMachine
    {
        public CoffeeMachine()
        {
            Ingredients = InitializeIngredientsList();
            _drinks = InitializeDrinksList();
        }

        private List<Drink> InitializeDrinksList()
        {
            var drinksList = new List<Drink>
                           {
                               new Drink { Id = 1, Name = "Caffe Americano", Ingredients = GetCaffeAmericanoIngredients()},
                               new Drink { Id = 2, Name = "Caffe Latte", Ingredients = GetCaffeLatteIngredients() },
                               new Drink { Id = 3, Name = "Caffe Mocha", Ingredients = GetCaffeMochaIngredients() },
                               new Drink { Id = 4, Name = "Cappuccino", Ingredients = GetCappuccinoIngredients() },
                               new Drink { Id = 5, Name = "Coffee", Ingredients = GetCoffeeIngredients() },
                               new Drink { Id = 6, Name = "Decaf Coffee", Ingredients = GetDecafCoffeeIngredients() }
                           };

            return drinksList;
        }

        public bool DeliveryStatus
        {
            get { return true; }
        }

        public IList<Ingredient> Ingredients;
        private readonly IList<Drink> _drinks;

        public void SelectOption(string selection)
        {
            switch (selection.ToUpper())
            {
                case "1":
                case "2": 
                case "3": 
                case "4": 
                case "5": 
                case "6":
                    CheckDrink(selection);
                    PrepareDrink(selection);
                    break;

                case "R":
                    
                    break;
            }
        }

        private void CheckDrink(string selection)
        {
            
        }

        private void PrepareDrink(string selection)
        {
            var actualDrink = _drinks.FirstOrDefault(t => t.Id.ToString() == selection);

            if (true)
                Console.WriteLine(string.Format("Dispensing: {0}", actualDrink.Name));
            else
                Console.WriteLine(string.Format("Out of stock: {0}", actualDrink.Name));

            foreach (var recipeIngredient in actualDrink.Ingredients)
            {
                var currentIngredientStock = Ingredients.FirstOrDefault(t => t.Name == recipeIngredient.Name);
                currentIngredientStock.Units -= recipeIngredient.Units;
            }
        }

        private void Restock()
        {
            Ingredients = InitializeIngredientsList();
        }

        private List<Ingredient> GetCaffeMochaIngredients()
        {
            return new List<Ingredient>
                       {
                           new Ingredient { Name = "Espresso", Units = 1, UnitCost = 1.10m},
                           new Ingredient { Name = "Steamed Milk", Units = 1, UnitCost = 0.35m},                           
                           new Ingredient { Name = "Cocoa", Units = 1, UnitCost = 0.90m},
                           new Ingredient { Name = "Whipped Cream", Units = 1, UnitCost = 1.00m}
                       };
        }

        private List<Ingredient> GetCappuccinoIngredients()
        {
            return new List<Ingredient>
                       {
                           new Ingredient { Name = "Espresso", Units = 2, UnitCost = 1.10m},
                           new Ingredient { Name = "Steamed Milk", Units = 1, UnitCost = 0.35m},                           
                           new Ingredient { Name = "Foamed Milk", Units = 1, UnitCost = 0.35m}
                       };
        }

        private List<Ingredient> GetCaffeAmericanoIngredients()
        {
            return new List<Ingredient>
                       {
                           new Ingredient { Name = "Espresso", Units = 3, UnitCost = 1.10m}
                       };
        }

        private List<Ingredient> GetCaffeLatteIngredients()
        {
            return new List<Ingredient>
                       {
                           new Ingredient { Name = "Espresso", Units = 2, UnitCost = 1.10m},
                           new Ingredient { Name = "Steamed Milk", Units = 1, UnitCost = 0.35m}
                       };
        }

        private List<Ingredient> GetDecafCoffeeIngredients()
        {
            return new List<Ingredient>
                       {
                           new Ingredient { Name = "Decaf Coffee", Units = 3, UnitCost = 0.75m},
                           new Ingredient { Name = "Sugar", Units = 1, UnitCost = 0.25m},                           
                           new Ingredient { Name = "Cream", Units = 1, UnitCost = 0.25m}
                       };
        }

        private List<Ingredient> GetCoffeeIngredients()
        {
            return new List<Ingredient>
                       {
                           new Ingredient { Name = "Coffee", Units = 3, UnitCost = 0.75m},
                           new Ingredient { Name = "Sugar", Units = 1, UnitCost = 0.25m},                           
                           new Ingredient { Name = "Cream", Units = 1, UnitCost = 0.25m}
                       };
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

            ConsoleKeyInfo cki;
            do
            {
                cki = Console.ReadKey(true);

                if (Char.IsDigit(cki.KeyChar) 
                    && int.Parse(cki.KeyChar.ToString()) > 0
                    && int.Parse(cki.KeyChar.ToString()) < 7)
                    SelectOption(cki.KeyChar.ToString());
                else if (cki.Key == ConsoleKey.R)
                    Restock();
                else
                    Console.WriteLine(String.Format("Invalid selection: {0}", cki.KeyChar.ToString()));

                DisplayIngredientsStock();
                DisplayMenu();

            } while (cki.Key != ConsoleKey.Q);
        }

        private void DisplayIngredientsStock()
        {
            Console.WriteLine("Inventory:");
            foreach (var newLine in Ingredients.OrderBy(t => t.Name).Select(ingredient => string.Format("{0},{1}", ingredient.Name, ingredient.Units)))
            {
                Console.WriteLine(newLine);
            }
        }

        private void DisplayMenu()
        {
            Console.WriteLine("Menu:");
            foreach (var drink in _drinks.OrderBy(t => t.Id))
            {
                var newline = string.Format("{0},{1},{2},{3}", drink.Id, drink.Name, drink.GetCost(), drink.IsAvailable().ToString().ToLower()); 
                Console.WriteLine(newline);
            }
        }
    }
}

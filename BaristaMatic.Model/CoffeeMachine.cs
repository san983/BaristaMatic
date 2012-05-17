using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BaristaMatic.Model
{
    public class CoffeeMachine
    {
        private const string ExitKey = "Q";
        private const string RestockKey = "R";

        public IList<Ingredient> Ingredients;
        private readonly IList<Drink> _drinks;
        private string _consoleOut;

        public string GetConsoleOut()
        {
            return _consoleOut;
        }

        public CoffeeMachine()
        {
            _consoleOut = string.Empty;
            Ingredients = InitializeIngredientsList(10);
            _drinks = InitializeDrinksList();

            DisplayIngredientsStockAndMenu();
        }

        public void Run()
        {
            //Predefine EitKey just for Specflow run
            var pressedKey = ExitKey;

            try
            {
                pressedKey = GetPressedKey();
            }
            catch
            {
            }

            while (IsNotExitCommand(pressedKey))
            {
                RunWithSelection(pressedKey);
                pressedKey = GetPressedKey();
            }
        }
        
        public void RunWithSelection(string pressedKey)
        {
            if (!IsNotExitCommand(pressedKey))
                return;

            if (IsValidDrinkOption(pressedKey))
                SelectDrinkOption(pressedKey);
            else if (IsRestockCommand(pressedKey))
                RestockMachine();
            else
                ShowInvalidSelection(pressedKey);

            DisplayIngredientsStockAndMenu();
        }

        public bool IsDrinkAvailable(Drink drink)
        {
            var result = true;

            foreach (var ingredient in drink.Ingredients)
            {
                result = Ingredients.First(t => t.Name == ingredient.Name).Units >= ingredient.Units;
                if (!result) break;
            }

            return result;
        }

        public void RestockMachine(int initialIngredientStock = 10)
        {
            Ingredients = InitializeIngredientsList(initialIngredientStock);
        }
       
        private void SelectDrinkOption(string selection)
        {
            switch (selection)
            {
                case "1":
                case "2": 
                case "3": 
                case "4": 
                case "5": 
                case "6":
                    CheckAndPrepareDrink(selection);
                    break;
            }
        }

        private void CheckAndPrepareDrink(string selection)
        {
            var actualDrink = _drinks.FirstOrDefault(t => t.Id.ToString() == selection);

            if (IsDrinkAvailable(actualDrink))
            {
                Write(string.Format("Dispensing: {0}", actualDrink.Name));

                foreach (var recipeIngredient in actualDrink.Ingredients)
                {
                    var currentIngredientStock = Ingredients.FirstOrDefault(t => t.Name == recipeIngredient.Name);
                    currentIngredientStock.Units -= recipeIngredient.Units;
                }
            }
            else
            {
                Write(string.Format("Out of stock: {0}", actualDrink.Name));
            }
        }

        private void ShowInvalidSelection(string key)
        {
            Write(String.Format("Invalid selection: {0}", key));
        }

        private static bool IsNotExitCommand(string key)
        {
            return key.ToUpper() != ExitKey;
        }

        private static bool IsRestockCommand(string key)
        {
            return key.ToUpper() == RestockKey;
        }

        private static bool IsValidDrinkOption(string option)
        {
            return Char.IsDigit(option, 0)
                   && int.Parse(option) > 0
                   && int.Parse(option) < 7;
        }

        private static string GetPressedKey()
        {
            return Console.ReadKey(true).KeyChar.ToString(CultureInfo.InvariantCulture);
        }

        private void DisplayIngredientsStockAndMenu()
        {
            DisplayIngredientsStock();
            DisplayDrinksMenu();
        }
        
        private void DisplayIngredientsStock()
        {
            Write("Inventory:");
            foreach (var newLine in Ingredients.OrderBy(t => t.Name).Select(ingredient => string.Format("{0},{1}", ingredient.Name, ingredient.Units)))
            {
                Write(newLine);
            }
        }

        private void DisplayDrinksMenu()
        {
            Write("Menu:");

            foreach (var drink in _drinks.OrderBy(t => t.Id))
            {
                var newline = string.Format("{0},{1},{2},{3}",
                    drink.Id,
                    drink.Name,
                    drink.GetUSFormattedCost(),
                    IsDrinkAvailable(drink).ToString().ToLower());

                Write(newline);
            }
        }
        
        private void Write(string text)
        {
            _consoleOut += (text + Environment.NewLine);
            Console.WriteLine(text);
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

        private static List<Ingredient> InitializeIngredientsList(int initialIngredientStock)
        {
            return new List<Ingredient>
                       {
                            new Ingredient { Name = "Coffee", Units = initialIngredientStock, UnitCost = 0.75m},
                            new Ingredient { Name = "Decaf Coffee", Units = initialIngredientStock, UnitCost = 0.75m},
                            new Ingredient { Name = "Sugar", Units = initialIngredientStock, UnitCost = 0.25m},
                            new Ingredient { Name = "Cream", Units = initialIngredientStock, UnitCost = 0.25m},
                            new Ingredient { Name = "Steamed Milk", Units = initialIngredientStock, UnitCost = 0.35m},
                            new Ingredient { Name = "Foamed Milk", Units = initialIngredientStock, UnitCost = 0.35m},
                            new Ingredient { Name = "Espresso", Units = initialIngredientStock, UnitCost = 1.10m},
                            new Ingredient { Name = "Cocoa", Units = initialIngredientStock, UnitCost = 0.90m},
                            new Ingredient { Name = "Whipped Cream", Units = initialIngredientStock, UnitCost = 1.00m}
                       };
        }
    }
}

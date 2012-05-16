﻿using System.Collections.Generic;

namespace BaristaMatic.Model
{
    public class CoffeeMachine
    {
        public CoffeeMachine()
        {
            Ingredients = InitializeIngredientsList();
        }

        public bool DeliveryStatus
        {
            get { return true; }
        }

        public Dictionary<string, int> Ingredients;  
    
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
            Ingredients["Espresso"] -= 1;
            Ingredients["Cocoa"] -= 1;
            Ingredients["Steamed Milk"] -= 1;
            Ingredients["Whipped Cream"] -= 1;
        }

        private void PrepareCapuccino()
        {
            Ingredients["Espresso"] -= 2;
            Ingredients["Steamed Milk"] -= 1;
            Ingredients["Foamed Milk"] -= 1;
        }

        private void PrepareCaffeAmericano()
        {
            Ingredients["Espresso"] -= 3;
        }

        private void PrepareCaffeLatte()
        {
            Ingredients["Espresso"] -= 2;
            Ingredients["Steamed Milk"] -= 1;
        }

        private void PrepareDecafCoffee()
        {
            Ingredients["Decaf Coffee"] -= 3;
            Ingredients["Sugar"] -= 1;
            Ingredients["Cream"] -= 1;
        }

        private void PrepareCoffee()
        {
            Ingredients["Coffee"] -= 3;
            Ingredients["Sugar"] -= 1;
            Ingredients["Cream"] -= 1;
        }

        private static Dictionary<string, int> InitializeIngredientsList()
        {
            return new Dictionary<string, int>
                       {
                           {"Coffee", 10},
                           {"Decaf Coffee", 10},
                           {"Sugar", 10},
                           {"Cream", 10},
                           {"Steamed Milk", 10},
                           {"Foamed Milk", 10},
                           {"Espresso", 10},
                           {"Cocoa", 10},
                           {"Whipped Cream", 10}
                       };
        }
    }
}

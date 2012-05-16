using System.Collections.Generic;

namespace BaristaMatic.Model
{
    public class CoffeeMachine
    {
        public CoffeeMachine()
        {
            Ingredients = new Dictionary<string, int>
                              {
                                  {"Coffee", 7},
                                  {"Decaf Coffee", 10},
                                  {"Sugar", 9},
                                  {"Cream", 9},
                                  {"Steamed Milk", 10},
                                  {"Foamed Milk", 10},
                                  {"Espresso", 10},
                                  {"Cocoa Coffee", 10}
                              };
        }

        public bool DeliveryStatus
        {
            get { return true; }
        }

        public Dictionary<string, int> Ingredients;  
    
        public void SetOption(string selection)
        {
            
        }
    }
}

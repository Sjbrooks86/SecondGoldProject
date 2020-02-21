using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _01_CafeClass
{
    /*A meal number, so customers can say "I'll have the #5"
    A meal name
    A description
    A list of ingredients,
    A price
    
         Your Task:
        Create a Menu Class with properties, constructors, and fields.
        Create a MenuRepository Class that has methods needed.
        Create a Test Class for your repository methods. (You don't need to test your constructors or objects, just your methods)
        Create a Program file that allows the cafe manager to add, delete, and see all items in the menu list.*/
    public class Menu
    {
        private double _price;
        public string MealName { get; set; }

        public int MealNumber { get; set; }
        public string Description { get; set; }
        public double Price
        {
            get
            {
                return _price;
            }
        }
        public string Ingredients { get; set; }
        public Menu() { }
        public Menu(string mealname, int mealnumber, string description, string ingredients, double price)
        {
            MealNumber = mealnumber;
            MealName = mealname;
            Description = description;
            Ingredients = ingredients;
            SetPrice(price);
        }

      
        private void SetPrice(double settingPrice)
        {
            _price = settingPrice;
        }
    }
}
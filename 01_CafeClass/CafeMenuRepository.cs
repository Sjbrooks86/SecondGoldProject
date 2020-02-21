using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CafeClass
{   //  CRUD
    //  Create
    //  Read
    //  Delete

    public class CafeMenuRepository
    {
        //create new meal items, delete meal items, and receive a list of all items on the cafe's menu.

        //add items to menu

        private List<Menu> _menu = new List<Menu>();
        public bool AddItemToMenu(Menu items)
        {
            int menuLength = _menu.Count();
            _menu.Add(items);
            bool wasAdded = menuLength + 1 == _menu.Count();
            return wasAdded;
        }

        // Getting menu item
        public Menu GetMealbyMealNumber(int mealNumber)
        {
            foreach (Menu meal in _menu)
            {
                if (meal.MealNumber == meal.MealNumber)
                {
                    return meal;
                }
            }
            return null;
        }

        
        //Delete menu items
        public bool RemoveMealItem(int existingMeal)
        {
            Menu removeMeal = GetMealbyMealNumber(existingMeal);
            bool deletedResult = _menu.Remove(removeMeal);
            return deletedResult;
        }
    }
}
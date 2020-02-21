using _01_CafeClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_UI
{
    class ProgramUI
    {
        private readonly CafeMenuRepository _menuRepository = new CafeMenuRepository();
        public void Run()
        {
            SeedMeals();
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Komodo Cafe Menu");
                Console.WriteLine("Please make a selection from the following options:\n" +
                    "1 - Get list of Meals\n" +
                    "2 - Add a new Meal to the Menu\n" +
                    "3 - Remove an existing Meal from the Menu\n" +
                    "4 - Exit");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        ShowAllMeals();
                        break;

                    case "2":
                        AddNewMeal();
                        break;

                    case "3":
                        RemoveMealFromMenu();
                        break;

                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        break;
                }
            }
        }

        private void AddNewMeal()
        {
            CafeMenuRepository newMeal = new CafeMenuRepository();

            Console.WriteLine("What is the Meal Number?");
            int mealNumber = Convert.ToString(Console.ReadLine();

            Console.WriteLine("What is the Meal Name?");
            string mealName = Console.ReadLine();

            Console.WriteLine("What is the Meal Description?");
            string mealDescription = Console.ReadLine();

            Console.WriteLine("What ingredients are included in this meal");
            string ingredients = Console.ReadLine();
            {
                List<Menu> listOfIngredients = new List<Menu>();
                listOfIngredients.Add(Console.ReadLine());
                int numberOfIngredients = listOfIngredients.Count;
                Console.WriteLine($"Ingredient {numberOfIngredients + 1}:");
                string userInput = Console.ReadLine();
            } 
            
            Console.WriteLine("What is the Price of this meal ? Enter a decimal amount (ex: 10.50):");
            decimal mealPrice = decimal.Parse(Console.ReadLine());
            
            _menuRepository.AddItemToMenu(newMeal);
            Console.WriteLine($"{} has been added to the Menu.\n" +
                $"Press any key to continue.");
            Console.ReadKey();
        }

        private void ShowAllMeals()
        {
            List<Menu> listOfMeals = new List<Menu>();
            foreach (Menu meal in listOfMeals)
            {
                Console.WriteLine($"Meal Number: {meal.MealNumber} | Meal Name: {meal.MealName} | Meal Price: ${meal.Price}\n");
            }
        }

        private void RemoveMealFromMenu()
        {
            Console.WriteLine("What Meal would you like to remove?\n" +
                "Please enter a Meal Number:");
            string userInput = Console.ReadLine();
            Menu existingMeal = _menuRepository.GetMealbyMealNumber(1);
            Console.WriteLine($"{existingMeal.MealName} will be removed from the Menu. Press any key to continue...");
            _menuRepository.RemoveMealItem(1);
            Console.ReadKey();
        }

        private void SeedMeals()
        {
            Menu newMeal = new Menu("Burger", '1', "Grilled Burger", "Two all beef patties, special sauce lettuce, cheese, pickle, onion, and a sesame seed bun.", 9.99d);
            
            //(string mealname, int mealnumber, string description, string ingredients, double price)
            _menuRepository.AddItemToMenu(newMeal);
        }
    }
}

//"Burger", '1', "Grilled Burger", "Two all beef patties, special sauce lettuce, cheese, pickle, onion, and a sesame seed bun."
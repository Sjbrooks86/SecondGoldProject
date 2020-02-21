using System;
using _01_CafeClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace O1_CafeTest
{
    [TestClass]
    public class CafeTest
    {
        private CafeMenuRepository _CafeMenuRepository;
        private Menu _meal;
        [TestInitialize]
        public void Arrange()
        {
            _CafeMenuRepository = new CafeMenuRepository();
            _meal = new Menu("Burger", '1', "Grilled Burger", "Two all beef patties, special sauce, lettuce, cheese, pickle, onion, and a sesame seed bun.", 9.99d);
            _CafeMenuRepository.AddItemToMenu(_meal);
        }

        [TestMethod]
        public void TestMethod1()
        {
            Menu mealItem = new Menu("Burger", '1', "Grilled Burger", "Two all beef patties, special sauce, lettuce, cheese, pickle, onion, and a sesame seed bun.", 9.99d);

            Console.WriteLine($"{mealItem.Price}");
            Assert.AreEqual(9.99d, mealItem.Price);
        }

        [TestMethod]
        public void RemoveMealItemTest()
        {
            bool RemoveMealFromMenuTest = _CafeMenuRepository.RemoveMealItem(5);
            Assert.IsTrue(RemoveMealFromMenuTest);
        }
    }
}



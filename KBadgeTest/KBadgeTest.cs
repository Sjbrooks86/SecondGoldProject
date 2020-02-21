using System;
using System.Collections.Generic;
using _03_Badge_Class;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KBadgeTest
{
    [TestClass]
    public class BadgeTests
    {
        private BadgeRepo _badgeRepo;
        private BadgeClass _BadgeClass;

        [TestInitialize]
        public void Arrange()
        {
            _badgeRepo = new BadgeRepo();
            _BadgeClass = new BadgeClass(12345, new List<string> { "A7" });
            _BadgeClass = new BadgeClass(22345, new List<string> { "A1, A4, B1, B2" });
            _BadgeClass = new BadgeClass(32345, new List<string> { "A4, A5" });
            _badgeRepo.AddNewBadgeToList(_BadgeClass);
        }

        [TestMethod]
        public void AddNewBadgeToListTest()
        {
            _badgeRepo.AddNewBadgeToList(_BadgeClass);
            int expected = 1;
            int actual = _badgeRepo.DisplayAllBadges().Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetBadgeByBadgeIDTest()
        {
            _badgeRepo.AddNewBadgeToList(_BadgeClass);
            BadgeClass actual = _badgeRepo.DisplayAllBadges();
            Assert.AreEqual(_BadgeClass.BadgeID, actual.BadgeID);
            Assert.AreEqual(_BadgeClass.ListOfDoorName, actual.ListOfDoorName);
        }
    }
}
    using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KomodoClaim_Test
{
    [TestClass]
    public class ClaimTest
    {
        private ClaimRepository _claimCarAccident;
        private ClaimRepository _houseFire;
        private ClaimRepository _theftOfPancakes;

        [TestInitialize]

        [TestMethod]
        public void Arrange()
        {
            _claimCarAccident = new ClaimRepository();
            
        }

        [TestMethod]
        public void TestAddClaimToList()
        {
            _claimCarAccident.AddNewClaimtoQueue(_houseFire);
            int expected = 1;
            int actual = _claimCarAccident.GetListOfAllClaims().Count;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TimeLapse_ShouldReturnFalse_Invalid()
        {
            {
                
            }

        [TestMethod]
        public void TestIsClaimValid()
        {
            //Assert Fail
            _claimCarAccident.AddNewClaimtoQueue(_houseFire);
            bool actual = _claimCarAccident.IsClaimValid(_houseFire);
            bool expected = false;
            Assert.AreEqual(expected, actual);

            //Assert Pass
            _claimCarAccident.AddNewClaimtoQueue(_theftOfPancakes);
            bool actualTwo = _claimCarAccident.IsClaimValid(_theftOfPancakes);
            bool expectedTwo = true;
            Assert.AreEqual(expectedTwo, actualTwo);
        }
    }
}
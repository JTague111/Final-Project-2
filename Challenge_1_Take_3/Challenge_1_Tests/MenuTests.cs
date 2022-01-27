using Challenge_1_Take_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Challenge_1_Tests
{
    [TestClass]
    public class MenuTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Menu menu = new Menu();

            menu.Name = "Steak&Eggs";

            string expected = "Steak&Eggs";
            string actual = menu.Name;

            Assert.AreEqual(expected, actual);
        }
    }
}

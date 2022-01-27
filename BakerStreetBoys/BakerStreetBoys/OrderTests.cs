using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using W2_D4_MC_BakerStreetChallenge.Orders;
using W2_D4_MC_BakerStreetChallenge.Products;

namespace W2_D4_MC_BakerStreetChallenge
{
    [TestClass]
    public class OrderTests
    {
        private OrderRepository _orderRepo;
        private Order _oderA;
        private Cake _cake;
        private Bread _bread;
        private Pastry _pastry;
        private Pie _pies;

        [TestInitialize]
        public void Init()
        {
            _orderRepo = new OrderRepository();
            _oderA = new Order();
            _cake = new Cake();
            _bread = new Bread();
            _pastry = new Pastry();
            _pies = new Pie();
        }


        [TestMethod]
        public void OrderA_Cake_ShouldReturnTotal()
        {
            _oderA.Product = _cake;
            _oderA.NumberOfBatches = 100;

            var grandTotal = _oderA.Total;

            Console.WriteLine(grandTotal);

            var expected = (2000 * 100) + 100m;
            var actual = grandTotal;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OrderA_Bread_ShouldReturnTotal()
        {
            _oderA.Product = _bread;
            _oderA.NumberOfBatches = 100;

            var grandTotal = _oderA.Total;

            Console.WriteLine(grandTotal);

            var expected = (500.01m * 100) + 100m;
            var actual = grandTotal;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShowDetails()
        {
            _oderA.Product = _pies;
            _oderA.NumberOfBatches = 100;

            _orderRepo.AddOrder(_oderA);

            Order value = _orderRepo.GetOrder(_oderA.OrderNumber);
            string expected = "Pie";

            Assert.AreEqual(expected, value.Product.GetType().Name);
        }
    }
}
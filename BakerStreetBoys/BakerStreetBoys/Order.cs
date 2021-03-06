using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W2_D4_MC_BakerStreetChallenge.Products;

namespace W2_D4_MC_BakerStreetChallenge.Orders
{
    public class Order
    {
        public Order()
        {
        }

        public int OrderNumber { get; set; }
        public Product Product { get; set; }
        public int NumberOfBatches { get; set; }
        public decimal OrderBasePrice
        {
            get
            {
                return 100.0m;
            }
        }
        public decimal Total
        {
            get
            {
                return GrandTotal();
            }
        }
        private decimal GrandTotal()
        {
            decimal productInitialCost = Product.Price;
            decimal totalCostOfBatches = productInitialCost * NumberOfBatches;
            decimal finalCost = totalCostOfBatches + OrderBasePrice;
            return finalCost;
        }
    }
}
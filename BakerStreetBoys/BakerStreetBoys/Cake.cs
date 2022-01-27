using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2_D4_MC_BakerStreetChallenge.Products
{
    public class Cake : Product
    {
        public Cake()
        {
            Price = 2000.00m;
            ProductType = ProductType.Cake;
        }
    }
}
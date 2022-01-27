using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2_D4_MC_BakerStreetChallenge.Products
{
    public enum ProductType { Bread, Cake, Pastry, Pies }
    public abstract class Product
    {
        public Product()
        {
        }
        public decimal Price { get; protected set; }
        public ProductType ProductType { get; protected set; }
    }
}
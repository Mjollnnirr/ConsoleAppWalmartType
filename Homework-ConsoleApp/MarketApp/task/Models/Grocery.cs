using System;
using System.Collections.Generic;
using System.Text;

namespace task.Models
{
    class Grocery : Product
    {
        public double PricePerCount { get; set; }
        public int ProductCount = 0;

        public Grocery(string name, double priceOfProduct, int countOfProduct) : base()
        {
            ItemName = name;
            PricePerCount = priceOfProduct;
            ProductCount = countOfProduct;
        }

        public bool Availablty()
        {
            if (ProductCount > 0)
            {
                return true;
            }
            return false;
        }
    }
}

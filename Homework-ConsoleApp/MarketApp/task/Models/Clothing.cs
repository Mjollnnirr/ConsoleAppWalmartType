using System;
using System.Collections.Generic;
using System.Text;

namespace task.Models
{
    enum Sizes
    {
        XS,
        S,
        M,
        L,
        XL,
        XXL
    }
    class Clothing : Product, IAccessibility
    {
        public Sizes Size { get; set; }
        public double PricePerCount { get; set; }
        public int ProductCount = 0;

        public Clothing(string name, double priceOfProduct, int countOfProduct, Sizes size) : base()
        {
            ItemName = name;
            PricePerCount = priceOfProduct;
            ProductCount = countOfProduct;
            Size = size;
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

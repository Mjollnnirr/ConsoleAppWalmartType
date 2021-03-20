using System;
using System.Collections.Generic;
using System.Text;

namespace task.Models
{
    class Grocery : Product, IAccessibility
    {
        public static List<Grocery> IteratorList { get; protected set; }
        private double _pricePerCount;
        public double PricePerCount 
        {
            get 
            {
                return _pricePerCount;
            }
            set 
            {
                TryAgain:
                if (value > 0)
                {
                    _pricePerCount = value;
                }
                else
                {
                    InvalidNumber:
                    Console.WriteLine("Invalid ram Input!\nTry Again!");
                    try
                    {
                        value = Convert.ToDouble(Console.ReadLine());
                        goto TryAgain;
                    }
                    catch (Exception)
                    {
                        goto InvalidNumber;
                    }
                }
            }
        }
        public override string ItemName { get; protected set; }
        private int _productCount = 0;
        public int ProductCount
        {
            get 
            {
                return _productCount;
            }
            set
            {
                TryAgain:
                if (value > 0)
                {
                    _productCount = value;
                }
                else
                {
                    InvalidNumber:
                    Console.WriteLine("Invalid ram Input!\nTry Again!");
                    try
                    {
                        value = Convert.ToInt32(Console.ReadLine());
                        goto TryAgain;
                    }
                    catch (Exception)
                    {
                        goto InvalidNumber;
                    }
                }
            }
        }
        public Grocery(string name, double priceOfProduct, int countOfProduct) : base()
        {
            ItemName = name;
            PricePerCount = priceOfProduct;
            ProductCount = countOfProduct;
            IteratorList.Add(this);
        }
        static Grocery()
        {
            IteratorList = new List<Grocery>();
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

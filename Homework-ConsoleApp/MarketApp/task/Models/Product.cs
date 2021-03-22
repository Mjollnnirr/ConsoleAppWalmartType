using System;
using System.Collections.Generic;
using System.Text;

namespace task.Models
{
    abstract class Product
    {
        abstract public string ItemName { get; protected set; }
        public int Id { get; protected set; }
        protected static int _countId = 0;

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
                    Console.WriteLine("Invalid input!\nTry Again!");
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
                    Console.WriteLine("Invalid Input!\nTry Again!");
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

        public Product()
        {
            Id = ++_countId;
        }
        public Product(double price, int count):this()
        {
            PricePerCount = price;
            ProductCount = count;
        }
    }
}

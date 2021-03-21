using System;
using System.Collections.Generic;
using System.Text;

namespace task.Models
{
    enum Sizes
    {
        XS = 1,
        S,
        M,
        L,
        XL,
        XXL
    }
    class Clothing : Product, IAccessibility
    {
        public static List<Clothing> IteratorList { get; protected set; }
        public Sizes Size { get; set; }
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

        static Clothing()
        {
            IteratorList = new List<Clothing>();
        }
        public Clothing(string name, double priceOfProduct, int countOfProduct, Sizes size) : base()
        {
            ItemName = name;
            PricePerCount = priceOfProduct;
            ProductCount = countOfProduct;
            Size = size;
            IteratorList.Add(this);
        }

        public bool Availablty()
        {
            if (ProductCount > 0)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"\n++++++++++++++++++++++++\nItem name: {ItemName}\nItem size: {Size}\nItem price: {PricePerCount}$\nItem left: {ProductCount}\n++++++++++++++++++++++++\n";
        }

        public static void ForEachItem()
        {
            foreach (Clothing item in IteratorList)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}

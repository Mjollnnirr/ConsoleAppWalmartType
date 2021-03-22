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
        public override string ToString()
        {
            return $"\n++++++++++++++++++++++++\nItem name: {ItemName}\nItem price: {PricePerCount}$\nItem left: {ProductCount}\n++++++++++++++++++++++++\n";
        }
        public static void ForEachItem()
        {
            foreach (Grocery item in IteratorList)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public static Grocery AddItem()
        {
            Console.Write("Add item name: ");
            string name = Console.ReadLine().Trim();
            double price;
            Price:
            try
            {
                Console.Write("Add price: ");
                price = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid price!\nTry again!");
                goto Price;
            }
            int count;
            Count:
            try
            {
                Console.Write("Add count: ");
                count = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid count!\nTry again!");
                goto Count;
            }
            Grocery grocery = new Grocery(name, price, count);
            return grocery;
        }
    }
}

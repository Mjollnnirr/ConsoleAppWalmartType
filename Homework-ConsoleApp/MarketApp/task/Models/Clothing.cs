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
        public static Sizes ChooseSize(ref Sizes size)
        {
            Sizes:
            Console.WriteLine("Sizes: ");
            Console.WriteLine($"Press 1 for: {Sizes.XS}" +
                $"\nPress 2 for: {Sizes.S}" +
                $"\nPress 3 for: {Sizes.M}" +
                $"\nPress 4 for: {Sizes.L}" +
                $"\nPress 5 for: {Sizes.XL}" +
                $"\nPress 6 for: {Sizes.XXL}");
            string choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    size = Sizes.XS;
                    break;
                case "2":
                    size = Sizes.S;
                    break;
                case "3":
                    size = Sizes.M;
                    break;
                case "4":
                    size = Sizes.L;
                    break;
                case "5":
                    size = Sizes.XL;
                    break;
                case "6":
                    size = Sizes.XXL;
                    break;
                default:
                    Console.WriteLine("Wrong choise!\nTry again!");
                    goto Sizes;
            }
            return size;
        }
        public static Clothing AddItem()
        {
            Console.Write("Add clothing name: ");
            string name = Console.ReadLine();
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
                Console.Write("Add count of item: ");
                count = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid count!\nTry again!");
                goto Count;
            }
            Sizes size = Sizes.S;
            Clothing.ChooseSize(ref size);
            Clothing clothing = new Clothing(name, price, count, size);
            return clothing;
        }
    }
}

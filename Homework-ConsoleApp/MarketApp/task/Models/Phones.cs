using System;
using System.Collections.Generic;
using System.Text;

namespace task.Models
{
    enum Brands
    {
        iPhone = 1,
        Samsung,
        LG,
        Huawei,
        BlackBerry
    }
    class Phones : Electronic
    {
        public static List<Phones> IteratorList { get; protected set; }
        public Brands Brand { get; set; }
        public string Model { get; set; }
        private int _storage;
        public int Storage 
        { 
            get
            {
                return _storage;
            }
            set 
            {
                if (value > 0)
                {
                    _storage = value;
                }
                else
                {
                    TryAgain:
                    Console.WriteLine("Invalid storage!\nTry Again!");
                    try
                    {
                        _storage = Convert.ToInt32(Console.ReadLine());
                        if (_storage < 0)
                        {
                            goto TryAgain;
                        }
                    }
                    catch (Exception)
                    {
                        goto TryAgain;
                    }
                }
            } 
        }
        static Phones()
        {
            IteratorList = new List<Phones>();
        }
        public Phones(double price, int productCount, Brands brand, string model, int storage):base(price, productCount)
        {
            Brand = brand;
            Model = model;
            Storage = storage;
            IteratorList.Add(this);
        }
        public override string ToString()
        {
            return $"\n++++++++++++++++++++++++\nPhone brand: {Brand}\nPhone model: {Model}\nPhone storage: {Storage} GB\nPhone price: {PricePerCount}$\nItem left: {ProductCount}\n++++++++++++++++++++++++\n";
        }
        public static void ForEachItem()
        {
            foreach (Phones item in IteratorList)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public static Brands ChooseBrand(out Brands brand)
        {
        Brands:
            Console.WriteLine("Choose brand: ");
            Console.WriteLine($"Press 1 for: {Brands.iPhone}" +
                $"\nPress 2 for: {Brands.Samsung}" +
                $"\nPress 3 for: {Brands.LG}" +
                $"\nPress 4 for: {Brands.Huawei}" +
                $"\npress 5 for: {Brands.BlackBerry}");
            string choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    brand = Brands.iPhone;
                    break;
                case "2":
                    brand = Brands.Samsung;
                    break;
                case "3":
                    brand = Brands.LG;
                    break;
                case "4":
                    brand = Brands.Huawei;
                    break;
                case "5":
                    brand = Brands.BlackBerry;
                    break;
                default:
                    Console.WriteLine("Wrong choise!\nTry again!");
                    goto Brands;
            }
            return brand;
        }
    }
}

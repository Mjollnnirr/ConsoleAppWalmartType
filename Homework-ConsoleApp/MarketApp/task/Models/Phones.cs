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
            Console.Clear();
            foreach (Phones item in IteratorList)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public static void Remove(int id)
        {
            Console.Clear();
            foreach (Phones item in IteratorList)
            {
                Console.WriteLine($"ID: {item.Id} - " + item.ToString());
            }
            Console.WriteLine("=================================================");
        ID:
            try
            {
                Console.Write("Enter the ID of product that you want to remove: ");
                id = Convert.ToInt32(Console.ReadLine());
                IteratorList.Remove(IteratorList.Find(item => item.Id == id));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid ID!\nTry again!");
                goto ID;
            }
            Console.Clear();
            Console.WriteLine("-----Item succesfully removed!-----");
        }
        public static Brands ChooseBrand(out Brands brand)
        {
        Brands:
            Console.WriteLine($"Press 1 for: {Brands.iPhone}" +
                $"\nPress 2 for: {Brands.Samsung}" +
                $"\nPress 3 for: {Brands.LG}" +
                $"\nPress 4 for: {Brands.Huawei}" +
                $"\npress 5 for: {Brands.BlackBerry}");
            Console.Write("Choose brand: ");
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
        public static Phones AddItem()
        {
            Brands brand;
            ChooseBrand(out brand);
            Console.Write("Add model: ");
            string model = Console.ReadLine().Trim();
            int storage;
            Storage:
            try
            {
                Console.Write("Add storage: ");
                storage = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid storage!\nTry again!");
                goto Storage;
            }
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
            Phones phones = new Phones(price, count, brand, model, storage);
            Console.Clear();
            Console.WriteLine("-----Phone is succesfully added!-----");
            return phones;
        }
        public static void Sell(ref bool isGoingBack, ref bool isAddingMore, ref double finalPay, List<Product> cartList)
        {
            foreach (Phones item in IteratorList)
            {
                Console.WriteLine($"ID: {item.Id} - " + item.ToString());
            }
            Console.WriteLine("=================================================");
            int id;
        ID:
            try
            {
                Console.WriteLine("Press '0' for go back\n------------------------ Or");
                Console.Write("Enter the ID of product that you want to add to cart: ");
                id = Convert.ToInt32(Console.ReadLine());
                if (id == 0)
                {
                    isGoingBack = true;
                    return;
                }
                int count;
            Count:
                Console.Write("Add count of item: ");
                try
                {
                    count = Convert.ToInt32(Console.ReadLine());
                    if (!IteratorList.Find(item => item.Id == id).Availablty(count))
                    {
                        Console.WriteLine("There is not enough item!\nPlease add less!");
                        goto Count;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input!\nTry Again!");
                    goto Count;
                }
                for (int i = 0; i < count; i++)
                {
                    cartList.Add(IteratorList.Find(item => item.Id == id));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid ID!\nTry again!");
                goto ID;
            }
            Console.WriteLine("=================================================");
        WrongAnswer:
            Console.Write("Item succesfully added to cart!\nDo you want to add more?\n'Y'/'N': ");
            string answer = Console.ReadLine().Trim().ToUpper();
            switch (answer)
            {
                case "Y":
                    isAddingMore = true;
                    break;
                case "N":
                    foreach (Product item in cartList)
                    {
                        finalPay += item.PricePerCount;
                    }
                    break;
                default:
                    Console.WriteLine("=================================================");
                    Console.WriteLine("Wrong answer!\nTry again!");
                    goto WrongAnswer;
            }
        }
    }
}

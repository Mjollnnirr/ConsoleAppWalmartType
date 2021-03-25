using System;
using System.Collections.Generic;
using System.Text;

namespace task.Models
{
    enum Models
    {
        Playstation5 = 1,
        Playstation4,
        NintendoSwitch,
        XboxSeriesX,
        XboxSeriesS
    }
    class GamingConsole : Electronic
    {
        public static List<GamingConsole> IteratorList { get; protected set; }
        public List<Games> GameList { 
            get
            {
                if (GameList.Count != 0)
                {
                    return GameList;
                }
                Console.WriteLine($"There is no game avalible for {Model}!");
                return GameList;
            }
            protected set 
            {
                foreach (Games item in Games.IteratorList)
                {
                    if (item.Playable == Model)
                    {
                        GameList.Add(item);
                    }
                }
            } 
        }
        public Models Model { get; protected set; }
        static GamingConsole()
        {
            IteratorList = new List<GamingConsole>();
        }
        public GamingConsole(Models model, double price, int productCount) : base(price, productCount)
        {
            Model = model;
            IteratorList.Add(this);
        }

        public override string ToString()
        {
            return $"\n++++++++++++++++++++++++\nConsole name: {Model}\nConsole price: {PricePerCount}$\nConsole left: {ProductCount}\n++++++++++++++++++++++++\n";
        }
        public static void ForEachItem()
        {
            Console.Clear();
            foreach (GamingConsole item in IteratorList)
            {
                Console.WriteLine(item.ToString());
            }
        }
        //public static void Remove(int id)
        //{
        //    Console.Clear();
        //    foreach (GamingConsole item in IteratorList)
        //    {
        //        Console.WriteLine($"ID: {item.Id} - " + item.ToString());
        //    }
        //    Console.WriteLine("=================================================");
        //ID:
        //    try
        //    {
        //        Console.Write("Enter the ID of product that you want to remove: ");
        //        id = Convert.ToInt32(Console.ReadLine());
        //        IteratorList.Remove(IteratorList.Find(item => item.Id == id));
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("Invalid ID!\nTry again!");
        //        goto ID;
        //    }
        //    Console.Clear();
        //    Console.WriteLine("-----Item succesfully removed!-----");
        //}
        public static void Remove(int id)
        {
            Console.Clear();
        CouldNotFound:
            foreach (GamingConsole item in IteratorList)
            {
                Console.WriteLine($"ID: {item.Id} - " + item.ToString());
            }
            Console.WriteLine("=================================================");
        ID:
            try
            {
                Console.Write("Enter the ID of product that you want to remove: ");
                try
                {
                    id = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid ID!\nTry again!");
                    goto ID;
                }
                Console.Clear();
                //IteratorList.Remove(IteratorList.Find(item => item.Id == id));
                //Console.WriteLine(IteratorList.Find(item => item.Id == id));
                if (IteratorList.Find(item => item.Id == id) == null)
                {
                    Console.WriteLine("ID could not found!\nTry again!");
                    goto CouldNotFound;
                }
                GamingConsole item = IteratorList.Find(item => item.Id == id);
                int count;
            Count:
                Console.WriteLine(item.ToString());
                Console.Write("Enter count of item that you want to remove: ");
                try
                {
                    count = Convert.ToInt32(Console.ReadLine());
                    if (count <= 0)
                    {
                        Console.WriteLine("Count must be more than '0'");
                        goto Count;
                    }
                    if (count > item.ProductCount)
                    {
                        Console.WriteLine($"Only {item.ProductCount} left!\nPlease add less!");
                        goto Count;
                    }
                    else if (count == item.ProductCount)
                    {
                        IteratorList.Remove(IteratorList.Find(item => item.Id == id));
                        Console.WriteLine("Item removed!");
                    }
                    else if (count < item.ProductCount && count > 0)
                    {
                        item.ProductCount -= count;
                        IteratorList.Remove(IteratorList.Find(item => item.Id == id));
                        IteratorList.Add(item);
                        Console.WriteLine($"{count} of item is removed!");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid count!\nTry again!");
                    goto Count;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid ID!\nTry again!");
                goto ID;
            }
            //Console.Clear();
            Console.WriteLine("-----Item succesfully removed!-----");
        }
        public static Models ChooseModel(out Models model)
        {
            Models:
            Console.WriteLine($"Press 1 for: {Models.Playstation5}" +
                $"\nPress 2 for: {Models.Playstation4}" +
                $"\nPress 3 for: {Models.NintendoSwitch}" +
                $"\nPress 4 for: {Models.XboxSeriesX}" +
                $"\npress 5 for: {Models.XboxSeriesS}");
            Console.Write("Working on: ");
            string choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    model = Models.Playstation5;
                    break;
                case "2":
                    model = Models.Playstation4;
                    break;
                case "3":
                    model = Models.NintendoSwitch;
                    break;
                case "4":
                    model = Models.XboxSeriesX;
                    break;
                case "5":
                    model = Models.XboxSeriesS;
                    break;
                default:
                    Console.WriteLine("Wrong choise!\nTry again!");
                    goto Models;
            }
            return model;
        }
        public static GamingConsole AddItem()
        {
            Models model;
            ChooseModel(out model);
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
                Console.WriteLine("Invalid price!\nTry again!");
                goto Count;
            }
            GamingConsole gamingConsole = new GamingConsole(model, price, count);
            Console.Clear();
            Console.WriteLine("-----Gaming Console is succesfully added!-----");
            return gamingConsole;
        }
        public static void Sell(ref bool isGoingback, ref bool isAddingMore, ref double finalPay, List<Product> cartList)
        {
            isGoingback = false;
            isAddingMore = false;
            foreach (GamingConsole item in IteratorList)
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
                try
                {
                    id = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid ID!\nTry Again!");
                    goto ID;
                }
                if (id == 0)
                {
                    isGoingback = true;
                    Console.Clear();
                    return;
                }
                GamingConsole item = IteratorList.Find(item => item.Id == id);
                if (item == null)
                {
                    Console.WriteLine("There is no item found on this item\nAdd other ID");
                    goto ID;
                }
                int count;
                Console.Clear();
            Count:
                Console.WriteLine(item.ToString());
                Console.Write("Add count of item: ");
                try
                {
                    count = Convert.ToInt32(Console.ReadLine());
                    if (item.ProductCount < count)
                    {
                        Console.Clear();
                        Console.WriteLine("There is not enough item!\nPlease add less!");
                        goto Count;
                    }
                    else if (count <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Count must bu more than '0'");
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
                    cartList.Add(item);
                }
                if (item.ProductCount == count)
                {
                    IteratorList.Remove(item);
                }
                else
                {
                    item.ProductCount -= count;
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
                    Console.Clear();
                    Console.WriteLine($"Your final pay is: {finalPay} $");
                    finalPay = 0;
                    cartList.Clear();
                    break;
                default:
                    Console.WriteLine("=================================================");
                    Console.WriteLine("Wrong answer!\nTry again!");
                    goto WrongAnswer;
            }
        }
    }
}

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
        public static void Remove(int id)
        {
            Console.Clear();
            foreach (GamingConsole item in IteratorList)
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
        public static void Sell(ref bool isGoingBack, ref bool isAddingMore, ref double finalPay, List<Product> cartList)
        {
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

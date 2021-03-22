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
            foreach (GamingConsole item in IteratorList)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public static Models ChooseModel(out Models model)
        {
            Models:
            Console.WriteLine("Working on: ");
            Console.WriteLine($"Press 1 for: {Models.Playstation5}" +
                $"\nPress 2 for: {Models.Playstation4}" +
                $"\nPress 3 for: {Models.NintendoSwitch}" +
                $"\nPress 4 for: {Models.XboxSeriesX}" +
                $"\npress 5 for: {Models.XboxSeriesS}");
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
            return gamingConsole;
        }
    }
}

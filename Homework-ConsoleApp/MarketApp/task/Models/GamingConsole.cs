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
    }
}

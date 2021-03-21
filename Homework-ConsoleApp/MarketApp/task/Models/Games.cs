using System;
using System.Collections.Generic;
using System.Text;

namespace task.Models
{
    class Games : Electronic
    {
        public string GameName { get; protected set; }
        public Models Playable { get; protected set; }
        public static List<Games> IteratorList { get; protected set; }
        static Games()
        {
            IteratorList = new List<Games>();
        }
        public Games(string gameName, double price, int productCount, Models playable) : base(price, productCount)
        {
            GameName = gameName;
            Playable = playable;
            IteratorList.Add(this);
        }
        public override string ToString()
        {
            return $"\n++++++++++++++++++++++++\nGame name: {GameName}\nAvalible on: {Playable}\nGame price: {PricePerCount}$\nGame left: {ProductCount}\n++++++++++++++++++++++++\n";
        }
        public static void ForEachItem()
        {
            foreach (Games item in IteratorList)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}

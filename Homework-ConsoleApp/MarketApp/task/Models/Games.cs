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
        public static void Remove(int id)
        {
            foreach (Games item in IteratorList)
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
        }
        public static Games AddItem()
        {
            Console.Write("Enter name of the game: ");
            string name = Console.ReadLine().Trim();
            Models model;
            GamingConsole.ChooseModel(out model);
            double price;
            Price:
            try
            {
                Console.Write("Enter the price: ");
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
                Console.WriteLine("Add count: ");
                count = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid price!\nTry again!");
                goto Count;
            }
            Games game = new Games(name, price, count, model);
            return game;
        }
        public static void Sell(ref bool isGoingBack, ref bool isAddingMore, ref double finalPay, List<Product> cartList)
        {
            foreach (Games item in IteratorList)
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

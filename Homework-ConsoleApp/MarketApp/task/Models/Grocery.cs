using System;
using System.Collections.Generic;
using System.Text;

namespace task.Models
{
    class Grocery : Product, IAccessibility
    {
        public static List<Grocery> IteratorList { get; protected set; }
        public override string ItemName { get; protected set; }
        public Grocery(string name, double priceOfProduct, int countOfProduct) : base(priceOfProduct, countOfProduct)
        {
            ItemName = name;
            IteratorList.Add(this);
        }
        static Grocery()
        {
            IteratorList = new List<Grocery>();
        }

        public bool Availablty(int CountOfChoise)
        {
            if (ProductCount * CountOfChoise > 0)
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

        public static void Remove(int id)
        {
            foreach (Grocery item in IteratorList)
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

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
            Console.Clear();
            foreach (Grocery item in IteratorList)
            {
                Console.WriteLine(item.ToString());
            }
        }

        //public static void Remove(int id)
        //{
        //    Console.Clear();
        //    foreach (Grocery item in IteratorList)
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
            foreach (Grocery item in IteratorList)
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
                Grocery item = IteratorList.Find(item => item.Id == id);
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
            Console.Clear();
            Console.WriteLine("-----Item is succesfully added!-----");
            return grocery;
        }
        public static void Sell(ref bool isGoingback, ref bool isAddingMore, ref double finalPay, List<Product> cartList)
        {
            isGoingback = false;
            isAddingMore = false;
            foreach (Grocery item in IteratorList)
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
                Grocery item = IteratorList.Find(item => item.Id == id);
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

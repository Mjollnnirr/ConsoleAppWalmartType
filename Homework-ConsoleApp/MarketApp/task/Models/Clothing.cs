using System;
using System.Collections.Generic;
using System.Text;

namespace task.Models
{
    enum Sizes
    {
        XS = 1,
        S,
        M,
        L,
        XL,
        XXL
    }
    class Clothing : Product, IAccessibility
    {
        public static List<Clothing> IteratorList { get; protected set; }
        public Sizes Size { get; set; }
        public override string ItemName { get; protected set; }

        static Clothing()
        {
            IteratorList = new List<Clothing>();
        }
        public Clothing(string name, double priceOfProduct, int countOfProduct, Sizes size) : base(priceOfProduct, countOfProduct)
        {
            ItemName = name;
            Size = size;
            IteratorList.Add(this);
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
            return $"\n++++++++++++++++++++++++\nItem name: {ItemName}\nItem size: {Size}\nItem price: {PricePerCount}$\nItem left: {ProductCount}\n++++++++++++++++++++++++\n";
        }

        public static void ForEachItem()
        {
            foreach (Clothing item in IteratorList)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public static Sizes ChooseSize(ref Sizes size)
        {
            Sizes:
            Console.WriteLine("Sizes: ");
            Console.WriteLine($"Press 1 for: {Sizes.XS}" +
                $"\nPress 2 for: {Sizes.S}" +
                $"\nPress 3 for: {Sizes.M}" +
                $"\nPress 4 for: {Sizes.L}" +
                $"\nPress 5 for: {Sizes.XL}" +
                $"\nPress 6 for: {Sizes.XXL}");
            string choise = Console.ReadLine().Trim();
            switch (choise)
            {
                case "1":
                    size = Sizes.XS;
                    break;
                case "2":
                    size = Sizes.S;
                    break;
                case "3":
                    size = Sizes.M;
                    break;
                case "4":
                    size = Sizes.L;
                    break;
                case "5":
                    size = Sizes.XL;
                    break;
                case "6":
                    size = Sizes.XXL;
                    break;
                default:
                    Console.WriteLine("Wrong choise!\nTry again!");
                    goto Sizes;
            }
            return size;
        }
        public static Clothing AddItem()
        {
            Console.Write("Add clothing name: ");
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
                Console.Write("Add count of item: ");
                count = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid count!\nTry again!");
                goto Count;
            }
            Sizes size = Sizes.S;
            ChooseSize(ref size);
            Clothing clothing = new Clothing(name, price, count, size);
            Console.WriteLine("-----Item succesfully added!-----");
            return clothing;
        }
        public static void Remove(int id)
        {
            foreach (Clothing item in IteratorList)
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
        public static void Sell(ref bool isGoingback, ref bool isAddingMore, ref double finalPay, List<Product> cartList)
        {
            foreach (Clothing item in IteratorList)
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
                    isGoingback = true;
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

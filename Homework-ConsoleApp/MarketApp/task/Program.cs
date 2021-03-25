using System;
using System.Collections.Generic;
using task.Models;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Items
            Clothing clothing1 = new Clothing("LC Waiki", 15.5, 4, Sizes.S);
            Clothing clothing2 = new Clothing("Adidas", 32.5, 4, Sizes.L);
            Clothing clothing3 = new Clothing("Jordan", 53.5, 4, Sizes.XXL);
            Clothing clothing4 = new Clothing("Nike", 34.5, 4, Sizes.M);
            Computers computer1 = new Computers(2000, 3, false, CPU.CoreI9, 32, 12);
            Computers computer2 = new Computers(1200, 6, true, CPU.CoreI7, 16, 4);
            Computers computer3 = new Computers(600, 3, false, CPU.CoreI3, 8, 2);
            Computers computer4 = new Computers(800, 1, false, CPU.CoreI5, 12, 4);
            Games game1 = new Games("Call of Duty", 30, 5, Models.Models.Playstation5);
            Games game2 = new Games("Civilization 6", 25, 3, Models.Models.XboxSeriesX);
            Games game3 = new Games("Rainbow 6 Siege", 10, 15, Models.Models.Playstation4);
            Games game4 = new Games("Legend of Zelda", 60, 10, Models.Models.NintendoSwitch);
            GamingConsole gamingConsole1 = new GamingConsole(Models.Models.Playstation5, 400, 3);
            GamingConsole gamingConsole2 = new GamingConsole(Models.Models.Playstation4, 400, 5);
            GamingConsole gamingConsole3 = new GamingConsole(Models.Models.NintendoSwitch, 400, 10);
            Grocery grocery1 = new Grocery("Coca-Cola", 1.0, 20);
            Grocery grocery2 = new Grocery("Lay's", 2.5, 10);
            Grocery grocery3 = new Grocery("Camel", 14.67, 15);
            Grocery grocery4 = new Grocery("Jack Daniel's", 40, 4);
            Grocery grocery5 = new Grocery("Captain Morgan", 40, 9);
            Grocery grocery6 = new Grocery("Toblerone", 5, 7);
            Grocery grocery7 = new Grocery("Absolute", 40, 10);
            Grocery grocery8 = new Grocery("M&M's", 1, 10);
            Grocery grocery9 = new Grocery("Oreo", 3, 10);
            Grocery grocery10 = new Grocery("Ramen", 0.4, 10);
            Grocery grocery11 = new Grocery("Frozen Shrimp", 10, 10);
            Grocery grocery12 = new Grocery("Toilet Paper Bounty", 3, 10);
            Grocery grocery13 = new Grocery("Frozen Chicken Wings", 20, 10);
            Phones phones1 = new Phones(400, 2, Brands.iPhone, "7", 128);
            Phones phones2 = new Phones(400, 2, Brands.Samsung, "Galaxy S8", 128);
            Phones phones3 = new Phones(400, 2, Brands.BlackBerry, "Some BlackBerry", 28);
            #endregion

            #region AddingItemsComments
            //List<Product> listOFitems = new List<Product>();


            //listOFitems.Add(clothing1);
            //listOFitems.Add(clothing2);
            //listOFitems.Add(clothing3);
            //listOFitems.Add(clothing4);
            //listOFitems.Add(computer1);
            //listOFitems.Add(computer2);
            //listOFitems.Add(computer3);
            //listOFitems.Add(computer4);
            //listOFitems.Add(game1);
            //listOFitems.Add(game2);
            //listOFitems.Add(game3);
            //listOFitems.Add(game4);
            //listOFitems.Add(gamingConsole1);
            //listOFitems.Add(gamingConsole2);
            //listOFitems.Add(gamingConsole3);
            //listOFitems.Add(grocery1);
            //listOFitems.Add(grocery2);
            //listOFitems.Add(grocery3);
            //listOFitems.Add(phones1);
            //listOFitems.Add(phones2);
            //listOFitems.Add(phones3);


            //foreach (Clothing item in Clothing.IteratorList)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //foreach (Computers item in Computers.IteratorList)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //foreach (Games item in Games.IteratorList)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //foreach (GamingConsole item in GamingConsole.IteratorList)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //foreach (Grocery item in Grocery.IteratorList)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //foreach (Phones item in Phones.IteratorList)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //Clothing.ItemList.Add(c2);
            #endregion

            #region Welcoming
            Console.WriteLine(@"                ▄█     █▄     ▄████████  ▄█        ▄████████  ▄██████▄    ▄▄▄▄███▄▄▄▄      ▄████████ 
                ███     ███   ███    ███ ███       ███    ███ ███    ███ ▄██▀▀▀███▀▀▀██▄   ███    ███ 
                ███     ███   ███    █▀  ███       ███    █▀  ███    ███ ███   ███   ███   ███    █▀  
                ███     ███  ▄███▄▄▄     ███       ███        ███    ███ ███   ███   ███  ▄███▄▄▄     
                ███     ███ ▀▀███▀▀▀     ███       ███        ███    ███ ███   ███   ███ ▀▀███▀▀▀     
                ███     ███   ███    █▄  ███       ███    █▄  ███    ███ ███   ███   ███   ███    █▄  
                ███ ▄█▄ ███   ███    ███ ███▌    ▄ ███    ███ ███    ███ ███   ███   ███   ███    ███ 
                ▀███▀███▀    ██████████ █████▄▄██ ████████▀   ▀██████▀   ▀█   ███   █▀    ██████████ 
                         ▀                                                            ");
            TryAgain:
            Console.WriteLine("======================================" +
                "\nPress '1' for product menu" +
                "\n======================================" +
                "\nPress '2' for add product" +
                "\n======================================" +
                "\nPress '3' for remove product" +
                "\n======================================" +
                "\nPress '4' for sell product" +
                "\n======================================" +
                "\nPress '0' for exit" +
                "\n======================================");

            Console.Write("\n\n" +
                "\n--------------------------------------" +
                "\nYour choise: ");
            #endregion
            #region Choosing Part
            string choise = Console.ReadLine().Trim();
            switch (choise)
            {
                case "1":
                    ItemList();
                    goto TryAgain;
                case "2":
                    AddProduct();
                    goto TryAgain;
                case "3":
                    RemoveProduct();
                    goto TryAgain;
                case "4":
                    SellProduct();
                    goto TryAgain;
                case "0":
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("\n\n++++++++++++++++++++++++++++++++++++++" +
                        "\nWrong Choise! Try again!!!" +
                        "\n++++++++++++++++++++++++++++++++++++++\n\n");
                    goto TryAgain;
            }
            #endregion


            #region ggggg
            foreach (var item in Clothing.IteratorList)
            {
                
            }
            #endregion
        }

        public static void ItemList()
        {
            Console.Clear();
        MainTrying:
            Console.WriteLine("======================================" +
                "\nPress '1' for Clothing store" +
                "\n======================================" +
                "\nPress '2' for Electronic" +
                "\n======================================" +
                "\nPress '3' for Grocery store" +
                "\n======================================" +
                "\nPress '0' for go back" +
                "\n======================================");

            Console.Write("\n\n" +
                "\n--------------------------------------" +
                "\nYour choise: ");

            string choise = Console.ReadLine().Trim();
            switch (choise)
            {
                case "1":
                    Clothing.ForEachItem();
                    break;
                case "2":
                    Electronic.Classes();
                    break;
                case "3":
                    Grocery.ForEachItem();
                    break;
                case "0":
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("\n\n++++++++++++++++++++++++++++++++++++++" +
                        "\nWrong Choise! Try again!!!" +
                        "\n++++++++++++++++++++++++++++++++++++++\n\n");
                    goto MainTrying;

            }
        }

        public static void RemoveProduct()
        {
            int id = 0;
            Console.Clear();
            MainTrying:
            Console.WriteLine("======================================" +
                "\nPress '1' for Clothing store" +
                "\n======================================" +
                "\nPress '2' for Electronic" +
                "\n======================================" +
                "\nPress '3' for Grocery store" +
                "\n======================================" +
                "\nPress '0' for go back" +
                "\n======================================");

            Console.Write("\n\n" +
                "\n--------------------------------------" +
                "\nYour choise: ");

            string choise = Console.ReadLine().Trim();
            switch (choise)
            {
                case "1":
                    Clothing.Remove(id);
                    RemoveMore:
                    Console.WriteLine("Do you want to remove more?\n'Y'/'N'");
                    string answer = Console.ReadLine().ToUpper().Trim();
                    if (answer == "Y")
                    {
                        Console.Clear();
                        goto MainTrying;
                    }
                    else if (answer == "N")
                    {
                        goto case "0";
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Wrong choise!\nTry again!");
                        goto RemoveMore;
                    }
                case "2":
                    int result;
                    Electronic.Classes(out result);
                    switch (result)
                    {
                        case 1:
                            Computers.Remove(id);
                            break;
                        case 2:
                            Games.Remove(id);
                            break;
                        case 3:
                            GamingConsole.Remove(id);
                            break;
                        case 4:
                            Phones.Remove(id);
                            break;
                        case 0:
                            goto MainTrying;
                    }
                    goto RemoveMore;
                case "3":
                    Grocery.Remove(id);
                    goto RemoveMore;
                case "0":
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("\n\n++++++++++++++++++++++++++++++++++++++" +
                        "\nWrong Choise! Try again!!!" +
                        "\n++++++++++++++++++++++++++++++++++++++\n\n");
                    goto MainTrying;
            }
        }

        public static void AddProduct()
        {
            Console.Clear();
            MainTrying:
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++\n" +
                "Choose the product type\n" +
                "++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("======================================" +
                "\nPress '1' for Clothing" +
                "\n======================================" +
                "\nPress '2' for Electronic" +
                "\n======================================" +
                "\nPress '3' for Grocery" +
                "\n======================================" +
                "\nPress '0' for Go Back" +
                "\n======================================");

            Console.Write("\n\n" +
                "\n--------------------------------------" +
                "\nYour choise: ");

            string choise = Console.ReadLine().Trim();
            switch (choise)
            {
                case "1":
                    Clothing.AddItem();
                    AddMore:
                    Console.WriteLine("Do you want to add more?\n'Y'/'N'");
                    string answer = Console.ReadLine().ToUpper().Trim();
                    if (answer == "Y")
                    {
                        goto MainTrying;
                    }
                    else if (answer == "N")
                    {
                        goto case "0";
                    }
                    else
                    {
                        Console.WriteLine("Wrong choise!\nTry again!");
                        goto AddMore;
                    }
                case "2":
                    int result;
                    Electronic.Classes(out result);
                    switch (result)
                    {
                        case 1:
                            Computers.AddItem();
                            break;
                        case 2:
                            Games.AddItem();
                            break;
                        case 3:
                            GamingConsole.AddItem();
                            break;
                        case 4:
                            Phones.AddItem();
                            break;
                        case 0:
                            goto MainTrying;
                    }
                    goto AddMore;
                case "3":
                    Clothing.AddItem();
                    goto AddMore;
                case "0":
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("\n\n++++++++++++++++++++++++++++++++++++++" +
                        "\nWrong Choise! Try again!!!" +
                        "\n++++++++++++++++++++++++++++++++++++++\n\n");
                    goto MainTrying;

            }
        }

        public static void SellProduct()
        {
            Console.Clear();
            List<Product> cart = new List<Product>();
            double finalPay = 0;
            MainTrying:
            Console.WriteLine("======================================" +
                "\nPress '1' for Clothing store" +
                "\n======================================" +
                "\nPress '2' for Electronic" +
                "\n======================================" +
                "\nPress '3' for Grocery store" +
                "\n======================================" +
                "\nPress '4' for go back" +
                "\n======================================");

            Console.Write("\n\n" +
                "\n--------------------------------------" +
                "\nYour choise: ");

            string choise = Console.ReadLine().Trim();
            switch (choise)
            {
                case "1":
                    bool isGoingBack1 = false;
                    bool isAddingMore1 = false;
                    Clothing.Sell(ref isGoingBack1, ref isAddingMore1, ref finalPay, cart);
                    if (isGoingBack1 || isAddingMore1)
                    {
                        goto MainTrying;
                    }
                    break;
                case "2":
                    bool isGoingBack2 = false;
                    bool isAddingMore2 = false;
                    Electronic.SellClasses(ref isAddingMore2, ref isGoingBack2, ref isAddingMore2, ref finalPay, cart);
                    if (isGoingBack2 || isAddingMore2)
                    {
                        goto MainTrying;
                    }
                    break;
                case "3":
                    bool isGoingBack3 = false;
                    bool isAddingMore3 = false;
                    Grocery.Sell(ref isGoingBack3, ref isAddingMore3, ref finalPay, cart);
                    if (isGoingBack3 || isAddingMore3)
                    {
                        goto MainTrying;
                    }
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("\n\n++++++++++++++++++++++++++++++++++++++" +
                        "\nWrong Choise! Try again!!!" +
                        "\n++++++++++++++++++++++++++++++++++++++\n\n");
                    goto MainTrying;
            }
        }
    }
}

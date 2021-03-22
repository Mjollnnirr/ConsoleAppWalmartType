using System;
using System.Collections.Generic;
using task.Models;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> listOFitems = new List<Product>();
            Clothing clothing1 = new Clothing("clothing1", 30.5, 4, Sizes.XL);
            Clothing clothing2 = new Clothing("clothing2", 32.5, 4, Sizes.XL);
            Clothing clothing3 = new Clothing("clothing3", 33.5, 4, Sizes.XL);
            Clothing clothing4 = new Clothing("clothing4", 34.5, 4, Sizes.XL);
            Computers computer1 = new Computers(200, 1, false, CPU.CoreI9, 32, 12);
            Computers computer2 = new Computers(200, 1, false, CPU.CoreI7, 16, 2);
            Computers computer3 = new Computers(200, 1, false, CPU.CoreI3, 8, 2);
            Computers computer4 = new Computers(200, 1, false, CPU.CoreI5, 12, 4);
            Games game1 = new Games("CoD", 30, 1, Models.Models.Playstation5);
            Games game2 = new Games("Civ6", 30, 1, Models.Models.XboxSeriesX);
            Games game3 = new Games("R6", 30, 1, Models.Models.Playstation4);
            Games game4 = new Games("Zelda", 30, 1, Models.Models.NintendoSwitch);
            GamingConsole gamingConsole1 = new GamingConsole(Models.Models.Playstation5, 400, 1);
            GamingConsole gamingConsole2 = new GamingConsole(Models.Models.Playstation4, 400, 1);
            GamingConsole gamingConsole3 = new GamingConsole(Models.Models.NintendoSwitch, 400, 1);
            Grocery grocery1 = new Grocery("grocery1", 27.5, 2);
            Grocery grocery2 = new Grocery("grocery2", 27.5, 2);
            Grocery grocery3 = new Grocery("grocery3", 27.5, 2);
            Phones phones1 = new Phones(400, 2, Brands.iPhone, "7", 128);
            Phones phones2 = new Phones(400, 2, Brands.Samsung, "Galaxy S8", 128);
            Phones phones3 = new Phones(400, 2, Brands.BlackBerry, "Dont Know", 128);
            listOFitems.Add(clothing1);
            listOFitems.Add(clothing2);
            listOFitems.Add(clothing3);
            listOFitems.Add(clothing4);
            listOFitems.Add(computer1);
            listOFitems.Add(computer2);
            listOFitems.Add(computer3);
            listOFitems.Add(computer4);
            listOFitems.Add(game1);
            listOFitems.Add(game2);
            listOFitems.Add(game3);
            listOFitems.Add(game4);
            listOFitems.Add(gamingConsole1);
            listOFitems.Add(gamingConsole2);
            listOFitems.Add(gamingConsole3);
            listOFitems.Add(grocery1);
            listOFitems.Add(grocery2);
            listOFitems.Add(grocery3);
            listOFitems.Add(phones1);
            listOFitems.Add(phones2);
            listOFitems.Add(phones3);


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
                "\nPress '5' for exit" +
                "\n======================================");

            Console.Write("\n\n" +
                "\n--------------------------------------" +
                "\nYour choise: ");
            #endregion
            #region Choosing Part
            string choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    bool isGoingBack1 = false;
                    ItemList(ref isGoingBack1);
                    if (isGoingBack1 == true)
                    {
                        goto TryAgain;
                    }
                    break;
                case "2":
                    bool isGoingBack2 = false;
                    AddProduct(ref isGoingBack2);
                    if (isGoingBack2 == true)
                    {
                        goto TryAgain;
                    }
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("\n\n++++++++++++++++++++++++++++++++++++++" +
                        "\nWrong Choise! Try again!!!" +
                        "\n++++++++++++++++++++++++++++++++++++++\n\n");
                    //string aa = "--------------------------------------";
                    //Console.WriteLine(aa.Length);
                    goto TryAgain;
            }
            #endregion
        }

        public static void ItemList(ref bool goingBack)
        {
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

            string choise = Console.ReadLine();
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
                case "4":
                    goingBack = true;
                    break;
                default:
                    Console.WriteLine("\n\n++++++++++++++++++++++++++++++++++++++" +
                        "\nWrong Choise! Try again!!!" +
                        "\n++++++++++++++++++++++++++++++++++++++\n\n");
                    goto MainTrying;

            }
        }

        public static void AddProduct(ref bool goingBack)
        {
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
                "\nPress '4' for Go Back" +
                "\n======================================");

            Console.Write("\n\n" +
                "\n--------------------------------------" +
                "\nYour choise: ");

            string choise = Console.ReadLine();
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
                        goto case "4";
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
                    break;
                case "4":
                    goingBack = true;
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

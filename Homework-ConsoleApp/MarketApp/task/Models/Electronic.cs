using System;
using System.Collections.Generic;
using System.Text;

namespace task.Models
{
    abstract class Electronic : Product, IAccessibility
    {
        public override string ItemName { get; protected set; }
        public bool Availablty(int CountOfChoise)
        {
            if (ProductCount * CountOfChoise > 0)
            {
                return true;
            }
            return false;
        }
        public Electronic(double price, int productCount):base(price, productCount)
        {
            
        }
        public static void Classes()
        {
            Console.Clear();
            MainTrying:
            Console.WriteLine("======================================" +
                "\nPress '1' for Computers" +
                "\n======================================" +
                "\nPress '2' for Games" +
                "\n======================================" +
                "\nPress '3' for Gaming Console" +
                "\n======================================" +
                "\nPress '4' for Phones" +
                "\n======================================" +
                "\nPress '0' for go back" +
                "\n======================================");

            Console.Write("\n\n" +
                "\n--------------------------------------" +
                "\nYour choise: ");

            string choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    Computers.ForEachItem();
                    break;
                case "2":
                    Games.ForEachItem();
                    break;
                case "3":
                    GamingConsole.ForEachItem();
                    break;
                case "4":
                    Phones.ForEachItem();
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
        public static void Classes(int id)
        {
            Console.Clear();
            MainTrying:
            Console.WriteLine("======================================" +
                "\nPress '1' for Computers" +
                "\n======================================" +
                "\nPress '2' for Games" +
                "\n======================================" +
                "\nPress '3' for Gaming Console" +
                "\n======================================" +
                "\nPress '4' for Phones" +
                "\n======================================" +
                "\nPress '0' for go back" +
                "\n======================================");

            Console.Write("\n\n" +
                "\n--------------------------------------" +
                "\nYour choise: ");

            string choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    Computers.Remove(id);
                    break;
                case "2":
                    Games.Remove(id);
                    break;
                case "3":
                    GamingConsole.Remove(id);
                    break;
                case "4":
                    Phones.Remove(id);
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
        public static int Classes(out int result)
        {
            Console.Clear();
        MainTrying:
            Console.WriteLine("======================================" +
                "\nPress '1' for Computers" +
                "\n======================================" +
                "\nPress '2' for Games" +
                "\n======================================" +
                "\nPress '3' for Gaming Console" +
                "\n======================================" +
                "\nPress '4' for Phones" +
                "\n======================================" +
                "\nPress '0' for go back" +
                "\n======================================");

            Console.Write("\n\n" +
                "\n--------------------------------------" +
                "\nYour choise: ");

            string choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    return result = 1;
                case "2":
                    return result = 2;
                case "3":
                    return result = 3;
                case "4":
                    return result = 4;
                case "0":
                    Console.Clear();
                    return result = 0;
                default:
                    Console.Clear();
                    Console.WriteLine("\n\n++++++++++++++++++++++++++++++++++++++" +
                        "\nWrong Choise! Try again!!!" +
                        "\n++++++++++++++++++++++++++++++++++++++\n\n");
                    goto MainTrying;

            }
        }
        public static void SellClasses(ref bool isGoingBack, ref bool goingBack, ref bool isAddingMore, ref double finalPay, List<Product> cartList)
        {
        MainTrying:
            Console.WriteLine("======================================" +
                "\nPress '1' for Computers" +
                "\n======================================" +
                "\nPress '2' for Games" +
                "\n======================================" +
                "\nPress '3' for Gaming Console" +
                "\n======================================" +
                "\nPress '4' for Phones" +
                "\n======================================" +
                "\nPress '5' for go back" +
                "\n======================================");

            Console.Write("\n\n" +
                "\n--------------------------------------" +
                "\nYour choise: ");

            string choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    Computers.Sell(ref isGoingBack, ref isAddingMore, ref finalPay, cartList);
                    break;
                case "2":
                    Games.Sell(ref isGoingBack, ref isAddingMore, ref finalPay, cartList);
                    break;
                case "3":
                    GamingConsole.Sell(ref isGoingBack, ref isAddingMore, ref finalPay, cartList);
                    break;
                case "4":
                    Phones.Sell(ref isGoingBack, ref isAddingMore, ref finalPay, cartList);
                    break;
                case "5":
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

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
                case "5":
                    break;
                default:
                    Console.WriteLine("\n\n++++++++++++++++++++++++++++++++++++++" +
                        "\nWrong Choise! Try again!!!" +
                        "\n++++++++++++++++++++++++++++++++++++++\n\n");
                    goto MainTrying;

            }
        }
        public static void Classes(int id)
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
                case "5":
                    break;
                default:
                    Console.WriteLine("\n\n++++++++++++++++++++++++++++++++++++++" +
                        "\nWrong Choise! Try again!!!" +
                        "\n++++++++++++++++++++++++++++++++++++++\n\n");
                    goto MainTrying;

            }
        }
        public static int Classes(out int result)
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
                    return result = 1;
                case "2":
                    return result = 2;
                case "3":
                    return result = 3;
                case "4":
                    return result = 4;
                case "5":
                    return result = 0;
                default:
                    Console.WriteLine("\n\n++++++++++++++++++++++++++++++++++++++" +
                        "\nWrong Choise! Try again!!!" +
                        "\n++++++++++++++++++++++++++++++++++++++\n\n");
                    goto MainTrying;

            }
        }
    }
}

using System;
using System.Collections.Generic;
using task.Models;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
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
                    break;
                case "2":
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



        public static void ItemList()
        {
            
        }
    }
}

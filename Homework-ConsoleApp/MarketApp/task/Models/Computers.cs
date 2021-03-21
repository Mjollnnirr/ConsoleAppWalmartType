using System;
using System.Collections.Generic;
using System.Text;

namespace task.Models
{
    enum CPU
    {
        CoreI3 = 1,
        CoreI5,
        CoreI7,
        CoreI9
    }
    class Computers : Electronic
    {
        public static List<Computers> IteratorList { get; protected set; }
        public bool IsLabtop { get; protected set; }
        public CPU Cpu { get; set; }
        private int _ram;
        public int Ram 
        {
            get 
            {
                return _ram;
            }
            protected set 
            {
                TryAgain:
                if (value > 0)
                {
                    _ram = value;
                }
                else
                {
                    InvalidNumber:
                    Console.WriteLine("Invalid ram Input!\nTry Again!");
                    try
                    {
                        value = Convert.ToInt32(Console.ReadLine());
                        goto TryAgain;
                    }
                    catch (Exception)
                    {
                        goto InvalidNumber;
                    }
                }
            }
        }
        private int _videoRam;
        public int VideoRam 
        {
            get 
            {
                return _videoRam;
            }
            protected set 
            {
                TryAgain:
                if (value > 0)
                {
                    _videoRam = value;
                }
                else
                {
                InvalidNumber:
                    Console.WriteLine("Invalid ram Input!\nTry Again!");
                    try
                    {
                        value = Convert.ToInt32(Console.ReadLine());
                        goto TryAgain;
                    }
                    catch (Exception)
                    {
                        goto InvalidNumber;
                    }
                }
            }
        }
        static Computers()
        {
            IteratorList = new List<Computers>();
        }
        public Computers(double price, int count, bool isLabtop, CPU cpu, int ram, int videoRam):base(price, count)
        {
            IsLabtop = isLabtop;
            Cpu = cpu;
            Ram = ram;
            VideoRam = videoRam;
            IteratorList.Add(this);
        }

        public override string ToString()
        {
            if (!IsLabtop)
            {
                return $"\n++++++++++++++++++++++++\nComputer properities\n  Ram: {Ram} GB\n  VideoRam: {VideoRam} GB\n  CPU: {Cpu}\nPrice: {PricePerCount}$\n++++++++++++++++++++++++\n";
            }
            return $"\n++++++++++++++++++++++++\nLabtop properities\n  Ram: {Ram} GB\n  VideoRam: {VideoRam} GB\n  CPU: {Cpu}\nPrice: {PricePerCount}$\n++++++++++++++++++++++++\n";
        }

        public static void ForEachItem()
        {
            foreach (Computers item in IteratorList)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public static CPU ChooseCpu(ref CPU cpu)
        {
        CPU:
            Console.WriteLine("CPU: ");
            Console.WriteLine($"Press 1 for: {CPU.CoreI3}" +
                $"\nPress 2 for: {CPU.CoreI5}" +
                $"\nPress 3 for: {CPU.CoreI7}" +
                $"\nPress 4 for: {CPU.CoreI9}");
            string choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    cpu = CPU.CoreI3;
                    break;
                case "2":
                    cpu = CPU.CoreI5;
                    break;
                case "3":
                    cpu = CPU.CoreI7;
                    break;
                case "4":
                    cpu = CPU.CoreI9;
                    break;
                default:
                    Console.WriteLine("Wrong choise!\nTry again!");
                    goto CPU;
            }
            return cpu;
        }
    }
}

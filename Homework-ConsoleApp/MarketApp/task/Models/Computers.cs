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
    }
}

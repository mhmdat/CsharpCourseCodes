﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Main_Method
{
    class Program
    {
        static int Main(string[] args)
            
        {

            Console.WriteLine($"{args.Length} Command Line arguments Has Entered :");
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
            Console.ReadKey();
            return 0;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_BreakCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Hello Mhmd");
                if (i > 2)
                    continue;
                for (int j = 0; j <= 4; j++)
                {
                    Console.WriteLine("\t Hello World");
                }
                Console.WriteLine("\n");

            }
            Console.ReadKey();
        }
    }
}

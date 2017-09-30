using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution6_s.s
{
    class Program
    {
        static void Main(string[] args)
        {
            string WhatHeSaid = "Hello";
            switch(WhatHeSaid)
            {
                case "Hello":
                    Console.WriteLine("He said Hello");
                    break;
                case "Bye":
                    Console.WriteLine("He Said Bye");
                    break;
                case "Welcome":
                    Console.WriteLine("He Said Welcome");
                    break;
                default:
                    Console.WriteLine("No one");
                    break;


                  
            }
            Console.ReadKey();
        }
    }
}

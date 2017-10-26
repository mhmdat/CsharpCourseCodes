using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToUpper_Vs_ToLower_and_Trim_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString, myString2;
            Console.WriteLine("Please Enter Your String");
            //myString2 = Console.ReadLine();
            //myString = myString2.ToUpper();
            //Console.WriteLine($"{myString2}");

            //Console.WriteLine($"{myString}");
            char[] mytrimchar = { 'h', 'e', 'i', ' ' };
            myString = Console.ReadLine();
            myString = myString.ToLower();
            myString2 = myString.Trim(mytrimchar);
            Console.WriteLine($"{myString2}");
                  
            Console.ReadKey();
        }
       
    }
}

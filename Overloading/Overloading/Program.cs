using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        public static int printNumber(int mynumber)
        {
            return mynumber;
        }
        public static double printNumber(double mynumber)
        {
            return mynumber;
        }
        static void Main(string[] args)
        {
            int mynumber = 9;
            Console.Write($"{printNumber(mynumber)}");
            Console.ReadKey();
        }
    }
}

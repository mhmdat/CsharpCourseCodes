using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameters
{
    class Program
    {
        public static void printvalues(string name = "Mhmd Atiyeh", int myvalue = 7)
        {
            Console.WriteLine($"Name {name} Number {myvalue}");
        }
        static void Main(string[] args)
        {
            string name = "yusif";
            int value = 15;
            printvalues();
            printvalues(name);
            printvalues(name, value);
            printvalues(name: "Kamel", myvalue: 6);
            Console.ReadKey();
        }
    }
}

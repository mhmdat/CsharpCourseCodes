using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_Scope
{
    class Program
    {
        static string mystring;
        static void printmystring()
        {
            string mystring = "My String Inside PrintMyString Method";
            Console.WriteLine($"{mystring}");
            Console.WriteLine($"{Program.mystring}");

        }
        static void Main(string[] args)
        {
            string mystring = "My String Inside Main Method";
            Program.mystring = "Global My String Variable";
            printmystring();
            Console.WriteLine($"{mystring}");
            Console.WriteLine($"{Program.mystring}");
            Console.ReadKey();
        }
    }
}

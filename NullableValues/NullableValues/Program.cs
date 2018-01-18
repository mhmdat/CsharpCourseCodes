using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string myvariable = null;
            int? myNumber = null;
            double? myDouble = null;
            Console.WriteLine($"{myvariable}");
            Console.WriteLine($"{myNumber}");
            Console.WriteLine($"{myDouble}");
            Console.ReadKey();
        }
    }
}

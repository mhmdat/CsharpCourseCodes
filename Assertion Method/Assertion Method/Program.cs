using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Diagnostics;
namespace Assertion_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter Your Value");
            int i = Convert.ToInt32(ReadLine());
            if (i >= 100)
            {
                WriteLine($"{i}");
            }
            else
            {
                Debug.WriteLine("We Are Here");
                //Debug.Assert(i >= 100, "short", "long");
                Trace.Assert(i>=100,"short","long");
            }
            WriteLine("Done");
            ReadKey();
        }
    }
}

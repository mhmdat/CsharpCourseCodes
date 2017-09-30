using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //  int myVar = 7;

            //string myResult = (myVar < 10) ? "Less than 10" : "Greater than 10";
            //Console.WriteLine("My Variable Result is {0}", myResult);

            string myName = "Mhmd", result;
            result = (myName.Equals("Mhmd")) ? "Yes" : "No";
            Console.WriteLine("My Variable result is {0}", result);



            Console.ReadKey();


        }
    }
}

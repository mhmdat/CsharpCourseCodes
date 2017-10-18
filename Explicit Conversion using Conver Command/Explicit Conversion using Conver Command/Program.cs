using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Conversion_using_Conver_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            double mydoublevar = 2500.45D;
            string mystringvar, mysubstring;
            mystringvar = Convert.ToString(mydoublevar);
            mysubstring = mystringvar.Substring(0, 2);
            Console.WriteLine($"My Variable is {mydoublevar} \n");
            Console.WriteLine("My String Variable is {0} \n", mystringvar);
            Console.WriteLine("My String Variable is {0} \n", mysubstring);
            Console.ReadKey();
        }
    }
}

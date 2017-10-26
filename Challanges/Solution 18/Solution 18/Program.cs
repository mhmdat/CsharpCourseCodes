using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_18
{
    class Program
    {
        static void Main(string[] args)
        {
            float myfloatvar = 45.56f;
            string mystringvar, mysubstring;
            mystringvar = Convert.ToString(myfloatvar);
            mysubstring = mystringvar.Substring(3,4);
            Console.WriteLine($"My Variable is {myfloatvar} \n");
            Console.WriteLine("My String Variable is {0} \n", mystringvar);
            Console.WriteLine("My String Variable is {0} \n", mysubstring);
            Console.ReadKey();
        }
    }
}

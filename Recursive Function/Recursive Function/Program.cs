using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Function
{
    class Program
    {
        static int MyRecursiveFunction(int myvalue, ref int counter)
        {
            counter++;
            //if value = 0.
            if (myvalue == 0)
                return 0;
            //if va;ue less than 10.
            else if(myvalue < 10)
            {
                return MyRecursiveFunction(myvalue + 1, ref counter);

            }

            //if value equal or exceeds 10.
            return myvalue;
                
        }
        static void Main(string[] args)
        {
            int counter = 0, myresult;
            myresult = MyRecursiveFunction(4, ref counter);
            Console.WriteLine($"My result is {myresult} and counter value is {counter}");
            Console.ReadKey();
        }
    }
}

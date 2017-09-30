using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar1 = 15;
            int myVar2 = 10;

            int temp = myVar1 + myVar2;
            int temp2 = myVar1 - myVar2;
            int temp3 = myVar1 % myVar2;
            int temp4 = myVar1 * myVar2;

            Console.WriteLine(" The result is {0}\n The result2 is {1}\n The remaining is {2}\n The result3 is {3}", temp, temp2, temp3,temp4);
            Console.ReadKey();
                
              


            

        }
    }
}

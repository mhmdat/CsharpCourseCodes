using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar1 = 7;

            int myVar2 = 3;
            int temp = myVar1 + myVar2;

            int temp1 = myVar1 - myVar2;

            int temp2 = myVar1 / myVar2;

            int temp3 = myVar1 % myVar2;

            int temp4 = myVar1 * myVar2;

            string str = "I am";
            string str2 = " smart";
            string stri = str + str2;
            Console.WriteLine("{0}", stri);

               

            Console.WriteLine("The result is {0}\n The result2 is{1}\n The result3 is {2}\n The remaining result is {3}\n The result4 is {4}", temp, temp1, temp2, temp3, temp4);

            Console.ReadKey();

        }
    }
}

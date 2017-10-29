using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_Value_Functions
{
    class Program
    {
        static void addNumbers(int myFirstN, int mySecondN)
        {
            int temp = myFirstN + mySecondN;
            Console.WriteLine($"{temp}");
        }
        static int addNumbers2(int myFirst, int mySecond)
        {
            int temp = myFirst + mySecond;
            return temp;
           
        }
        static void Main(string[] args)
        {
            int myVar1 = 5, myVar2 = 3;
            addNumbers(myVar1, myVar2);
            Console.WriteLine($"{addNumbers2(myVar1, myVar2)}");
            Console.ReadKey();
        }
    }
}

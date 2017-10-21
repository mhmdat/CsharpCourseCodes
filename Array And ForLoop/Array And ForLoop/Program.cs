using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_And_ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            const int myArraysize = 5;
            int [] myNumbers = { 1, 5, 8, 9, 7 };
            int[] myNumbers2 = new int[5];
            int[] myNumber3 = new int [myArraysize] {1, 5, 8, 9, 7};

            for (int i = 0; i < 5; i++)
                Console.WriteLine($"My Numbers" + (i + 1) + "=" + $"{myNumbers[i]}" + "");
            Console.ReadKey();
        }
    }
}

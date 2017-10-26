using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int Max;
            const int Mysize = 6;
            int[] Mynumbers = { 1, 4, 2, 6, 9, 7};
            int[] Mynumbers2 = new int[Mysize];


            for (int i = 0; i < 6; i++) 
            Console.WriteLine($"My Numbers" + (i + 1) + "=" + $"{Mynumbers[i]} "+" ");

            Max = Mynumbers.Max();
            Console.WriteLine($"\n My Max Number {Max}");
            Console.ReadKey();
                

        }
    }
}

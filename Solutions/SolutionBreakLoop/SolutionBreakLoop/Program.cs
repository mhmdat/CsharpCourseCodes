using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionBreakLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Multiplication Table");
                if (i >= 7)
                    continue;
                for (int j = 0; j <= 7; j++)
                {
                    Console.WriteLine("\t Multiplication Table {0} * {1} = {2}", i, j, i * j);
                    
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
               
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] myNumbers = new int[3, 2, 3]
            {
                { {6, 2, 9}, {1, 4, 2 } },
                {{1, 1, 2}, {4, 6, 5} },
                {{6, 4, 1}, {4, 3, 2 } }
        };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int m = 0; m < 3; m++)
                    {
                        Console.WriteLine("{0}", $"{myNumbers[i, j, m]}" + "\t ");
                    }
                    Console.WriteLine(" \t");
                    
                }

            }
            Console.ReadKey();
        }
        
    }
   
}

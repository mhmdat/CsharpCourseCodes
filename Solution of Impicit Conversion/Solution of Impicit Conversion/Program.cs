using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_of_Impicit_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            long myVar = 1000;
            float myVar2 = myVar;
            Console.WriteLine($"{myVar2}");
            char myVar3 = 'G';
            int myIntVar = myVar3;
            Console.ReadKey();
                
        }
    }
}

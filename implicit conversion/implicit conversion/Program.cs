using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implicit_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            long myvar1 = 2000;
            float myvar2 = myvar1;
            //Console.WriteLine($"{myvar2}");
            char myvar3 = 'N';
            int myvar4 = myvar3;
            Console.WriteLine($"{myvar4}");
        
            Console.ReadKey();
        }
    }
}

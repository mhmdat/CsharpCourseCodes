using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_of_String_and_ArrayLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myFullName ={ "Mhmd", "Kamel", "Atiyeh" };
            int myArrayLength = myFullName.Length;
            for (int i = 0; i < myArrayLength; i++) 
            {
                Console.WriteLine($"{myFullName}" + "");

            }
            Console.WriteLine("\n My Array Length Is" + $"{myArrayLength}");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop_Vs_Foreach_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myFullName = { "Mhmd", "Kamel", "Atiyeh" };
            int myArrayLength = myFullName.Length;
            for (int i = 0; i < myArrayLength; i++)
            {
                myFullName[2] = "Yousif";
               Console.WriteLine($"{myFullName}" + "");

            }
            Console.WriteLine("\n My Array Length Is" +" " + $"{myArrayLength}");
            foreach (string myname in myFullName)
            {
               
                Console.WriteLine($"{myname}" + "");
            }
            Console.ReadKey();
        }
    }
}

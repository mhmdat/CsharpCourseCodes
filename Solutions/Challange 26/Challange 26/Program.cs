using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_26
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mystring = { "I", "am", "smart" };
            int myArrlength = mystring.Length;
            for (int i = 0; i < myArrlength; i++) 
            {
                mystring[0] = "He";
                mystring[1] = "is";
                Console.Write($"{mystring[i]}" + " ");
            }
            Console.ReadKey();
        }
    }
}

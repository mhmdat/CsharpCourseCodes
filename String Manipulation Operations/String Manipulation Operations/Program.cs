using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystring = "Hello My Friends";
            char[] mychararray = mystring.ToCharArray();
            Console.WriteLine($"The String Length is {mystring.Length} \n");
                foreach (char mychar in mychararray)
            {
                Console.WriteLine($"{mychar}");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringType
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystring = "Mhmd said this is a good course, and I think";
            string mystring2 = @"yes it is";
            
                
            string mystring3 = mystring + mystring2;


            Console.WriteLine("{0}", mystring3);
            Console.ReadKey();
        }
    }
}

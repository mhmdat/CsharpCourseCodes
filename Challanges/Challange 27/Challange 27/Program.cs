using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_27
{
    class Program
    {
        static void Main(string[] args)
        {
            String mystring = "Hello My Dear", mystring2;
            Console.WriteLine("What Would You Say?");

            mystring = mystring.PadRight(14, 'e');
             
            mystring = mystring.PadRight(15, 's');
            
            mystring = mystring.PadRight(16, 't');
            Console.Write($"\n\t{mystring}");
            Console.ReadKey();
        }
    }
}

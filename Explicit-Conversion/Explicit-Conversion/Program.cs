using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type1 = (Type1)Type2                                 //Casting
            byte mybytetype;
            int myint = 17;
            mybytetype = (byte)myint;
            Console.WriteLine($"My Variable int = {myint}" + "\n");
            Console.WriteLine($"My Byte Variable = {mybytetype}");
            Console.ReadKey();
            
        }
    }
}

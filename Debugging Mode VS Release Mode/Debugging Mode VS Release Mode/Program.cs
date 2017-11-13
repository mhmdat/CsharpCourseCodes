using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Diagnostics;

namespace Debugging_Mode_VS_Release_Mode
{
    class Program
    {
        public static int addfunc(int x, int y)
            {
            Debug.WriteLine("We started are here in the add function");
            int z = x + y;
            Debug.WriteLine("We are done here in the add function");
            return z;
            }
        public static int Mulfunc(int x, int y)
        {
            Debug.WriteLine("We started are here in the multiplication function");
            int z = x * y;
            Debug.WriteLine("We are done here in the multiplication function");
            return z;
        }
        public static void writefunc(int z)
        {
            Debug.WriteLine("We started are here in the write function");
            WriteLine($"{z}");
            Debug.WriteLine("We are done here in the write function");
            
        }
        static void Main(string[] args)
        {
            int myNum, myvar1 = 4, myvar2 = 7;
            myNum = addfunc(myvar1, myvar2);
            writefunc(myNum);
            myNum = Mulfunc(myvar1, myvar2);
            writefunc(myNum);
            ReadKey();
        }
    }
}

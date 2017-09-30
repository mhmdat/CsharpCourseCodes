using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementsDecrements2
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar1 = 7;
            int myVar2 = 2;

            int temp = myVar1-- / ++myVar2;
            Console.WriteLine("{0}", temp);

            int MyVar1 = myVar1--;
            int MVar2 = ++myVar2;

            Console.WriteLine("{0} {1}", MyVar1, MVar2);
            

            Console.ReadKey();


            
        }
    }
}

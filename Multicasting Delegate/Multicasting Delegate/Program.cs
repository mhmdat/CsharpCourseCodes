using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicasting_Delegate
{
    delegate int MyNewNumber(int myNumber);

    class Program
    {
        static int myXNumber = 3;
        static int addfunc(int number)
        {
            myXNumber += number;
            return myXNumber;
        }
        static int mulfunc(int number)
        {
            myXNumber *= number;
            return myXNumber;
        }
        static void Main(string[] args)
        {
            MyNewNumber n;
            MyNewNumber n1 = new MyNewNumber(addfunc);
            MyNewNumber n2 = new MyNewNumber(mulfunc);
            n1(4);
            Console.Write($"{myXNumber} \n");
            n2(5);
            Console.Write($"{myXNumber} \n");
            n = n1 + n2;
            n(5);
            Console.Write($"{myXNumber} \n");
            Console.ReadKey();

                
        }
    }
}

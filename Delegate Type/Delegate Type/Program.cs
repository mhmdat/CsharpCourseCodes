using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Type
{
    delegate int MyNewNumber(int myNumber);
    class Program
    {
        static int myXNumber = 3;
        static int addFunct(int number)
        {
            myXNumber += number;
            return myXNumber;
        }
        static int mulFunc(int number)
        {
            myXNumber *= number;
            return myXNumber;
        }
        static void Main(string[] args)
        {
            MyNewNumber n1 = new MyNewNumber(addFunct);
            MyNewNumber n2 = new MyNewNumber(mulFunc);
            n1(4);
            Console.Write($"{myXNumber} \n");
            n2(5);
            Console.Write($"{myXNumber}");
            Console.ReadKey();
        }
    }
}

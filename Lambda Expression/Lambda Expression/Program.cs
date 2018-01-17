using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Lambda_Expression
{
    delegate int MyNewNumber(int MyNumber);

    class Program
    {
        static int MyNumber = 3;
        static void Main(string[] args)
        {

            //MyNewNumber n = X => X + MyNumber;
            //MyNewNumber n1 = X => X * MyNumber;
            //Write($"MyXNumber = {n(3)}\n");
            //Write($"MyXNumber = {n1(4)}\n");
            //ReadKey();
            Func<int, bool> func = (x => x % 2 != 0);
            int[] myArray = { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < myArray.Length; i++)
                WriteLine(func.Invoke(myArray[i]));
            ReadKey();
        } 
    }
}

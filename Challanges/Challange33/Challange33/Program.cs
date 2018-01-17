using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Challange33
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> func2 = (X => X > 10);
            int[] myarray = { 2, 3, 6, 11, 5, 12, 15, 7 };
            for (int i = 0; i < myarray.Length; i++)
                WriteLine(func2.Invoke(myarray[i]));
            ReadKey();
        }
    }
}

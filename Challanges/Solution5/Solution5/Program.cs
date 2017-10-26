using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool MyResult;
            int myVar1 = 9, myVar2 = 11;
            MyResult = (myVar1 < 10) && (myVar2 <= 11);
            bool MyResult2;
            MyResult2 = (myVar1 < 10) || (myVar2 <= 11);
            Console.WriteLine("My Result is {0} MyResult2 is {1}", MyResult, MyResult2);
               
                
            Console.ReadKey();





        }
    }
}

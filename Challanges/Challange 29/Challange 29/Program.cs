using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_29
{
    class Program
    {
        static double AvarageVal(double[] myarray1)
        {
            double marks = 0.0d, avarage;
            for(int i = 0; i < myarray1.Length; i++)
            {
                marks += myarray1[i];
            }
            avarage = marks / 7;
            return avarage;
           
        }
        static void Main(string[] args)
        {
            double[] avrglst = { 89, 30, 55, 22, 66, 78, 51, };
            double avarage = AvarageVal(avrglst);
            Console.WriteLine($"The Avarage of The student is {avarage}");
            Console.ReadKey();
        }
    }
}

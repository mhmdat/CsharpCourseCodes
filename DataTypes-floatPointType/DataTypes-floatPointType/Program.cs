using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_floatPointType
{
    class Program
    {
        static void Main(string[] args)
        {
            float flMin = float.MinValue;
            float flMax = float.MaxValue;


            Console.WriteLine("Min Value = :{0} Max val = :{1}", flMin, flMax);
            

            float flVar = 1F / 3;
            double dlVar = 1d / 3;
            decimal dcVar = 1M / 3;

            Console.Write("float Value = {0}\ndouble Value = {1}\ndecimal Value = {3}", flVar, dlVar, dcVar);
            Console.Read();

                


           



        }
    }
}

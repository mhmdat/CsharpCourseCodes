using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_32
{
    class Program
    {
        public static int MinVal(int[] myarray)
        {

            int minvalue = myarray[0];
            for (int i = 1; i < myarray.Length; i++)
            {
                if (myarray[0] <= minvalue)
                    minvalue = myarray[i];
            }

            return minvalue;

        }
        public static double MinVal(double[] myarray)
        {
            double minvalue = myarray[0];
            for(int i = 1; i < myarray.Length; i++)
            {
                if (myarray[0] <= minvalue)
                    minvalue = myarray[i];
            }
            return minvalue;

        
    
            
        }
        static void Main(string[] args)
        {
            int[] myarray = {10 , 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine($"The Minimum Number is {MinVal(myarray)}");
            Console.ReadKey();
           
        }
    }
}

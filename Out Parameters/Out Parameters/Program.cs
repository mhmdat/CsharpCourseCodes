using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Parameters
{
    class Program
    {
        static int MinValue(int[] myarray2, out int myindex)
        {
            int minval = myarray2[0];
            myindex = 0;
            for (int i = 1; i < myarray2.Length; i++)
            {
                
                    if ( myarray2[i] < minval)
                { 
                    minval = myarray2[i];
                    myindex = i;
                }
            }
                return minval;              
        }
        static void Main(string[] args)
        {
            int myindex;
            int[] myArray = { 11, 10, 43, 6, 22, 8, 9, 13, 50, 22 };
            int minVal = MinValue(myArray, out myindex);
            Console.WriteLine($"The Minimum Value in My Array is {minVal} and the index is {myindex}");
            Console.ReadKey();
        }
    }
}

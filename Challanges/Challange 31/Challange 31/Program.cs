using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_31
{
    class Program
    {
        static int MinValue(int[] MyArray2, out int myindex)
        {
            int minval = MyArray2[0];
            myindex = 0;
            for (int i = 1; i < MyArray2.Length; i++)
            {
                if (MyArray2[i] < minval) ;
                {
                    minval = MyArray2[i];
                    myindex = i;
                }
            }
            return minval;
        }
        static void Main(string[] args)
        {
            int myindex;
            int[] myarray = {1, 4, 5, 9, 74, 0 };
            int minval = MinValue(myarray, out myindex);
            Console.WriteLine($"The Minimum Value In My Array is {minval} and the Index is {myindex}");
            Console.ReadKey();
        }
    }
}

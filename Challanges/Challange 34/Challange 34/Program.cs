using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_34
{
    class Program
    {
        static int MyNum(params int[] value)
        {
            Console.WriteLine("You sent me {0} Numbers", value.Length);
            int maxnum = 0;
            if (value.Length == 0)
                return maxnum;
            for (int i = 0; i < value.Length; i++)
                maxnum = value.Max();
            return maxnum;


        }

        static void Main(string[] args)
        {
            int max;
            max = MyNum ( 16, 17, 20, 25, 77, 123);
            Console.WriteLine("Max number is :{0}", max);
            Console.ReadKey();

        }
    }
}

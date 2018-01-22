using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace GoTo
{
    class Program
    {
        static int myfunction()
        {
            int counter = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j == 5)
                    {
                        goto MyLable;
                    }
                    counter++;
                }
                MyLable:
                continue;
            }
            return counter;
        }
        static void Main(string[] args)
        {
            //WriteLine(myfunction());
            int counter = 0;
            myLabel:
            if (counter < 10)
            {
                counter++;
                goto myLabel;
            }
            else WriteLine("Done");
            WriteLine(counter);
            ReadKey();

        }
    }
}

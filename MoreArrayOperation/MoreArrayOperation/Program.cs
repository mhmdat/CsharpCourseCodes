using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreArrayOperation
{
    class Program
    {
        static void SystemArrayFuctionality()
        {
            Console.WriteLine("Working with the class system.array.");
            //intialize items at startup.
            int[] mynumbers = new[] { 11, 2, 31, 14, 5 };

            //Array Rank.
            //Console.WriteLine("The rank of array = {0}", mynumbers.Rank);
            //print out numbers in declared order.


            //Console.WriteLine("Here is my array");
            //for(int i = mynumbers.GetLowerBound(0); i <= mynumbers.GetUpperBound(0); i++)
            //{
            //    //print my number.
            //    Console.WriteLine(mynumbers[i]);

            //}


            ////sort them.
            //Array.Sort(mynumbers);
            //Console.WriteLine("\n\n the sorted array = ");
            ////and print them.
            //for (int i = 0; i < mynumbers.Length; i++)
            //{
            //    //print my numbers.
            //    Console.WriteLine(mynumbers[i]);
            //}

            ////reverse them.
            //Array.Reverse(mynumbers);
            //Console.WriteLine("\n\n the reversed array = ");
            //for (int i = 0; i < mynumbers.Length; i++)
            //{
            //    Console.WriteLine(mynumbers[i] + "\n");
            //}
            //Console.WriteLine("\n");


            ////Clear out all but the final member.
            //Console.WriteLine("Cleared out all but ....");
            //Array.Clear(mynumbers, 0, mynumbers.Length);
            //for (int i = 0; i < mynumbers.Length; i++)
            //{
            //    Console.WriteLine(mynumbers[i] + "\n");
            //}
            string[] array2 = Array.ConvertAll(mynumbers, element => element.ToString());
            //write string array.
            Console.WriteLine(string.Join(";", array2));
        }
        
        static void Main(string[] args)
        {
            SystemArrayFuctionality();
            Console.ReadKey();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the array of tow elements:
            int[][] arr = new int[2][];
            //initialize the elements:
            arr[0] = new int[5] { 1, 3, 5, 7, 9 };
            arr[1] = new int[4] { 2, 4, 6, 8 };
            //Display the array elements:
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("({0}): ", i);

                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("{0}", arr[i][j] + " " );
                }
                        Console.WriteLine(" ");
                    }
                     Console.ReadKey();
                
            

        }
    }
}

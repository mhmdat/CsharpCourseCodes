﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[7] { 1, 5, 8, 9, 6, 4, 9 };
            arr[1] = new int[3] { 0, 4, 3 };
            arr[2] = new int[4] { 2, 9, 3, 10 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("({0})" + " ", i);
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("{0}", arr[i][j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();

                
        }
    }
}

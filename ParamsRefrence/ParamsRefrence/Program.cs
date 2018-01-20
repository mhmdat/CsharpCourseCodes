﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsRefrence
{
    class Program
    {
        static double CalculateAvarage(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles.", values.Length);
            double sum = 0;
            if (values.Length == 0)
                return sum;
            for (int i = 0; i < values.Length; i++)
                sum += values[i];
            return (sum / values.Length);
        }

        static void Main(string[] args)
        {
            double avarage;
            //we can pass arguments.
            avarage = CalculateAvarage(4.0, 3.2, 5.7, 64.22, 87.2);
            Console.WriteLine("avarage of data is: {0}", avarage);
            //we can pass an array of doubles.
            double[] data = { 4.0, 3.2, 5.7 };
            avarage = CalculateAvarage(data);
            Console.WriteLine("avarage of data is :{0}", avarage);
            Console.ReadKey();
        }
    }
}

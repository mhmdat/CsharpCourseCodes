﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeFunction
{
    class Program
    {
        public static bool mypalindromefunction(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;

                }
                char a = value[min];
                char b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;

            }
        }
        static void Main(string[] args)
        {
            string[] myarray = { "civic", "deified", "deleveled", "perls", "is", "not", "A", "Palindrome", "" };
            foreach (string word in myarray)
            {
                Console.WriteLine("{0}={1}", word, mypalindromefunction(word));
            }
            Console.ReadKey();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_Functions_With_String_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystring;
            char[] separator = { ' ', 'u' };
            mystring = Console.ReadLine();
            string[] mynewWords;
            mynewWords = mystring.Split(separator);
            foreach (string word in mynewWords)
            {
                Console.WriteLine($"{word}");
            }
            Console.ReadKey();
           

        }
    }
}

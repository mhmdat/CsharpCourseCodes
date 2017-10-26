using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int charMin = char.MinValue;
            int charMax = char.MaxValue;

            char myVar = 'A';
            int myVarValue = 'A';
            int myVarValue2 = Convert.ToChar(97);

            Console.WriteLine("Min Char = {0} Max Char = {1} My Character = {2} My Variable Number {3} My conversion value = {4}", charMin, charMax, myVar, myVarValue, myVarValue2);

            string mystring = " This is My character A Value";
            string mysrting = " This is My character a Value";
            Console.WriteLine("\nmy string is {0} \nmy string is {1}", mystring, mysrting);
        


            Console.WriteLine("This is my Character A Value = {65} This is my Character a Value = {97}");
        
            
            
           
            Console.ReadKey();
        }
    }
}

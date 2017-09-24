using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_CharStringBoolTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int charMin = Char.MinValue;
            int charMax = Char.MaxValue;
        

            char myVal = 'G';
            int myVarValue = 'G';
            char myVarValue2 = Convert.ToChar(75);
            Console.WriteLine("Min Char = {0} Max Char = {1} My Character = {2} my Variable number = {3} Conversion Value is= {4}", charMin, charMax, myVal, myVarValue, myVarValue2);
            string myString = "This is my variable";
            Console.WriteLine("\nMy string is {0}", myString);
            bool myBool = false;
            Console.WriteLine("my Boolean value is {0}", myBool);
            Console.ReadKey();



            
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using YB= Brothers.YoungBrother;
using OB= Brothers.OldBrothers;

namespace NameSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Those are My Family ");
            YB.MYYoungBrothers.Print();
            OB.MyOldBrothers.Print();
            ReadKey();
        }
    }
}

namespace Brothers
{
    namespace YoungBrother
    {
        class MYYoungBrothers
        {
            public static void Print()
            {
                Write("Nourhan " + "And " + "Mohammed");
                


                }
            
        }
    }
}

namespace Brothers
{
    namespace OldBrothers
    {
        class MyOldBrothers
        {
            public static void Print()
            {
                Write("\nHamoudti " + "and " + "Da3ppulti");
            }
        
        }
    }
}
            
    




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checked_Unchecked
{
    class Program
    {
        static void Main(string[] args)
        {
            byte mybytetype;
            int myint = 350;
            //mybytetype = checked((byte)myint);
            mybytetype = unchecked((byte)myint);
            Console.WriteLine($"My Variable Int = {myint}" + "\n");
            Console.WriteLine($"My byte Variable = {mybytetype}");
            Console.ReadKey();
        }
    }
}

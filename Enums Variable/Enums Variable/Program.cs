using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Variable
{
    class Program
    {
        enum humansex :sbyte
        {
            male = 1,
            female = 2
        }
        static void Main(string[] args)
        {
            sbyte humansbyte;
            string humangender;
            humansex myhumansex = humansex.male;
            Console.WriteLine($"Human Sex = {myhumansex}" + "\n");
            humansbyte = (sbyte)myhumansex;
            humangender = Convert.ToString(myhumansex);
            Console.WriteLine($"Human Gender Index = {humansbyte}" + "\n");
            Console.WriteLine($"Human Associated With This Index = {humangender}" + "\n");
            Console.ReadKey();



        }
    }
}

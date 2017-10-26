using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_21
{
    class Program
    {
        enum orientation : byte
        {
            north = 1,
            west = 2,
            south = 3,
            east = 4
        }
        struct orient
        {
            public orientation direction;
            public double distance;
        }
        
        

        static void Main(string[] args)
        {
            orient mydistance;
            int direction = -1;
            double distance;
            Console.WriteLine("1) North\n2) West\n3) South\n4) East");
            do
            {
                Console.WriteLine("Enter Your Direction");
                direction = Convert.ToInt32(Console.ReadLine());

            }
            while ((direction < 1) || (direction > 4));
            Console.WriteLine("Input The Distance :");
            distance = Convert.ToInt32(Console.ReadLine());
            mydistance.direction = (orientation)direction;
            mydistance.distance = direction;
            Console.WriteLine($"My Direction Is {mydistance.direction}");
            Console.WriteLine($"My Distance Is {distance}");
            Console.ReadKey();

        }
    }
}

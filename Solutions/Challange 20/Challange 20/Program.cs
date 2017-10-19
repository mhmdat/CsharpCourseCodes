using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_20
{
    class Program
    {
        enum orientations :sbyte
        {
            north = 2,
            south = 3,
            west = 4,
            east = 5
            
            
        }
        static void Main(string[] args)
        {
            orientations Anorth = orientations.north;
            Console.WriteLine($"The First Orientation is {Anorth}" + "\n");
            orientations Asouth = orientations.south;
            Console.WriteLine($"The Second Orientation is {Asouth}" + "\n");
            orientations Awest = orientations.west;
            Console.WriteLine($"The Third Orientation is {Awest}" + "\n");
            orientations Aeast = orientations.east;
            Console.WriteLine($"The Forth Orientation is {Aeast}" + "\n");
            Console.ReadKey();
               


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_Type
{
    class Program
    {
        enum toyota : byte
        {
            RAV = 1,
            Camery = 2,
            Tundra = 3,
            HighLand = 4
        }

        struct CarType
        {
            public toyota modelName;
            public double modelYear;
        
         
        }

        static void Main(string[] args)
        {
            CarType myCarType;
            int CarType = -1;
            double modelYear;
            Console.WriteLine($"1) Rav4\n2) Camery\n3) Tundra\n4) Highland");
            do
            {
                Console.WriteLine("Enter Your Car Type");
                CarType = Convert.ToInt32(Console.ReadLine());
            }
            while ((CarType < 1) || (CarType > 4));
            Console.WriteLine("Input a Model Year:");
            modelYear = Convert.ToDouble(Console.ReadLine());
            myCarType.modelName = (toyota)CarType;
            myCarType.modelYear = modelYear;
            Console.WriteLine($"My Car Type is {myCarType.modelName}");
            Console.ReadKey();
            

        }
    }
}

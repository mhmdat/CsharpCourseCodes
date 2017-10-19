using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_19
{
    class Program
    {
        static void Main(string[] args)
        {
           string fname, lname;
            int mysalary;
            double mytaxrate, Total = 0, Total1 = 0,Total2 = 0, taxrate = 0.07, Salary = 2000;
             Console.WriteLine($"What's Your First Name \n");
             fname = Console.ReadLine();
             Console.WriteLine($"What's Your Last Name \n");
             lname = Console.ReadLine();
             Console.WriteLine($"How Much is Your Salary \n");
             mysalary = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine($"How Much is Your TaxRate \n");
             mytaxrate = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine($"Your First Name is {fname}");
             Console.WriteLine($"Your Last Name is {lname}");
             Console.WriteLine($"Your Salary is {mysalary}");
             Console.WriteLine($"Your TaxRate is {mytaxrate}");

            mysalary *= 12;
            taxrate = (7 * mysalary / 100);
            mytaxrate = mysalary - taxrate;
            Console.WriteLine($"Welcome {fname}{lname}");
            Console.WriteLine($"Your Salary for 12 months is {mysalary} $");
            Console.WriteLine($"You Paid Tax Rate for 12 months {mytaxrate} $");
            Console.WriteLine($"GoodBye");
            Console.WriteLine($";)");




            

            Console.ReadKey();

        }  
    }
}

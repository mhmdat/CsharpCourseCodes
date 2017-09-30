using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {

         /*string myAnimal = "Cat";
            switch(myAnimal)
            {
                case "Canary":
                    Console.WriteLine("My Animal is the Canary Bird");
                    break;
                case "Cat":
                    Console.WriteLine("My Animal is the Cat");
                    break;
                case "camel":
                    Console.WriteLine("My Animal is the Camel");
                    break;
                default:
                    Console.WriteLine("No One");
                    break;

                   
            }

            Console.ReadKey();
            */
            int myVar = 15;
            switch(myVar)
            {
                case 10:
                    Console.WriteLine("My Variable is 10");
                    break;
                case 7:
                    Console.WriteLine("My Variable is 7");
                    break;
                case 4:
                    Console.WriteLine("My Variable is 4");
                    break;
                default:
                    Console.WriteLine("No One");
                    break;



                    Console.ReadKey();

            }

        } 
        
    }
}

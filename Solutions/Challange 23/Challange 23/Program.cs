using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_23
{
    class Program
    {
        static void Main(string[] args)
        {
            const int myArraysize = 15;
            int[] myNumbers = new int[myArraysize] { 100, 400, 500, 1000, 2000, 55, 66, 123, 675, 888, 120, 130, 160, 110, 115 };
            int i = 0;

            foreach (int Rep in myNumbers)
               
            {

                
                Console.WriteLine($"My Numbers" + $"{Rep}" );
                i++;
                if (i >= 14)
                    break;
                
            }    

               Console.ReadKey();






               
        }



    
    
            
        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_30
{
    class Program
    {
        static void multiply_num(ref int firstM , ref int SecondM)
        {

            firstM *= 4; SecondM *= 3;
            
            Console.WriteLine($" my Numbers = {firstM} \n");
            Console.WriteLine($" my Number ={SecondM}\n"); 

            
        
    
        
        }
        
        static void Main(string[] args)
        {
            int myNumber = 8,  mynumber2 = 2;
          
            Console.WriteLine($"My Number = {myNumber}\n ");
        Console.WriteLine($"My Number = {mynumber2}\n");
            multiply_num(ref myNumber,ref mynumber2);
           

            
            Console.WriteLine($"My Number ={myNumber}\n");
            Console.WriteLine($"My Number ={mynumber2}\n");
            Console.ReadKey();
        }
    }
}

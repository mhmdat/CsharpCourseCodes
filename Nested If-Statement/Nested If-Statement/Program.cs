using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_If_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar1 = 10;

           String myResult;
            if (myVar1 < 10)
            {
                myResult = "Less than 10";
                Console.WriteLine(myResult);

            }
            if (myVar1 > 10)
            {
                myResult = "Greater than 10";
                Console.WriteLine(myResult);
            }

            if (myVar1 == 10) ;
            {
                myResult = "Equal 10";
                Console.WriteLine(myResult);

            }
            Console.ReadKey();

        }
    }
}

            
        
        

      
        
          



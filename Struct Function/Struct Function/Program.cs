using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Function
{
    class Program
    {
        struct fullName
        {
            public string myfirstname, mylastname;
            public string printname() => myfirstname + " " + mylastname; 
        }
        static void Main(string[] args)
        {
            fullName myfullname;
            myfullname.myfirstname = "Mhmd";
            myfullname.mylastname = "Atiyeh";
            //Console.Write($"{myfullname.myfirstname} {myfullname.mylastname}");
            Console.Write($"{myfullname.printname()}");
            Console.ReadKey();
        }
    }
}

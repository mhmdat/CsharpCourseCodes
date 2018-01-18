using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DateTime_Type
{
    class Program
    {
        static void Main(string[] args)
        {

            //WriteLine(DateTime.Now.ToString("hh:mm:ss \nMM dd yyyy"));

            //DateTime time = DateTime.Now;
            //string formate = "MM dd yyyy hh:mm:ss";
            //WriteLine(time.ToString(formate));

            //DateTime time = DateTime.Now;
            //string formate = "MMM ddd d yyyy HH:mm:ss";
            //WriteLine(time.ToString(formate));

            //DateTime now = DateTime.Now;
            //WriteLine(now.ToString("d"));
            //WriteLine(now.ToString("D"));
            //WriteLine(now.ToString("f"));
            //WriteLine(now.ToString("F"));
            //WriteLine(now.ToString("g"));
            //WriteLine(now.ToString("G"));
            //WriteLine(now.ToString("d"));
            //WriteLine(now.ToString("m"));
            //WriteLine(now.ToString("M"));
            //WriteLine(now.ToString("o"));
            //WriteLine(now.ToString("O"));
            //WriteLine(now.ToString("s"));
            //WriteLine(now.ToString("t"));
            //WriteLine(now.ToString("T"));
            //WriteLine(now.ToString("u"));
            //WriteLine(now.ToString("U"));
            //WriteLine(now.ToString("y"));
            //WriteLine(now.ToString("Y"));

            //DateTime now = DateTime.Now;
            //string result = now.ToString("s ");
            //WriteLine($"{now} [s] = {result}");

            DateTime now = DateTime.Today;
            for(int i = 0; i < 7; i++)
            {
                WriteLine(now.ToString("dddd"));
                now = now.AddDays(1);
            }
            ReadKey();

        }
    }
}

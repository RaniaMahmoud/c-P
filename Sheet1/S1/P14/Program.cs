using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(ReadLine());
            WriteLine((4/3.0)*3.1416 * Math.Pow(r, 3));
            ReadKey();
        }
    }
}

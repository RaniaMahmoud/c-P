using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            int v;
            bool b1 = int.TryParse(ReadLine(), out v);
            bool b2 = int.TryParse(ReadLine(), out b);
            if (b1 && b2)
            {
                int mask = (v >> b) & 1;
                WriteLine(mask);
            }
            else
                WriteLine("Not valid");
            ReadKey();
        }
    }
}

using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool f = false;
            double x, y;
            bool Xf = double.TryParse(ReadLine(), out x);
            bool Yf = double.TryParse(ReadLine(), out y);
            if (Xf && Yf)
            {
                if ((x * x + y * y) <= 25)
                {
                    f = true;
                }
                WriteLine(f);
            }
            else
            {
                WriteLine("Not a valid ");
            }
        }
    }
}

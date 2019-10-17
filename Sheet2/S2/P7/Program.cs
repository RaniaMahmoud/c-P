using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2400, k = 2800;
            while (i<k)
            {
                if( i % 2 == 1 && i % 3 == 2 && i % 4 == 3 && i % 5 == 4 && i % 6 == 5 && i % 7 == 6 && i % 8 == 7 && i % 9 == 8 && i % 10 == 9)
                {
                    WriteLine($"The number is {i}");
                    break;
                }
                else
                    WriteLine("not");
                i++;
            }
            ReadKey();

        }
    }
}

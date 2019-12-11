using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool p = true;
            int number;
            bool b = int.TryParse(ReadLine(), out number);

            if (b)
            {
                if (number <= 100)
                {
                    for (int i = 2; i <= Math.Sqrt(number); i++)
                    {
                        if (number % i == 0)
                        {
                            p = false;
                            break;
                        }
                    }
                    WriteLine(p);
                }
                else
                    WriteLine("Not a valid ");

            }
            else
            {
                WriteLine("Not a valid ");
            }
        }
    }
}

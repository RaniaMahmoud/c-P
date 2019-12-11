using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter Number Brtween 10,20 :");
            double n = int.Parse(ReadLine());
            double cube = n * n * n;
            Write(cube+" = ");
            n = Math.Pow(n, 2) - n + 1;
            double sum = 0;
            while (sum != cube)
            {
                Write(n + " + ");
                n += 2;
                sum = sum + n;
            }
            ReadKey();
        }
    }
}

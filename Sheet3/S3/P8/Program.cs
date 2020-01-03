using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace P8
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num1 = 0;
            BigInteger num2 = 1;
            BigInteger num3 = 1;
            int count = 0;

            WriteLine(num1);

            while (count < 100)
            {
                num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
                WriteLine(num2);
                count++;
            }
            ReadKey();
        }
    }
}

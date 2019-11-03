using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P20
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int n, sN = 1;
            bool b1 = int.TryParse(ReadLine(), out n);
            if (b1)
            {
                for (int i = 2; i <= n; i++)
                {
                    sN *= i;
                }

                for (int i = 5; n / i >= 1; i *= 5)
                    count += n / i;
                WriteLine(count);
            }
            else
                WriteLine("NOT");
            ReadKey();
        }
    }
}

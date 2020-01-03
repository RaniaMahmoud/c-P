using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P19
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool b = int.TryParse(ReadLine(), out n);
            if (b)
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = i; j <= n + i - 1; j++)
                    {
                        Write(j + " ");

                    }
                    WriteLine();
                }
            }
            else
                WriteLine("NOT");
            ReadKey();
        }
    }
}

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
            int c = 0;
            int[] a = { 3, 2, 3, 4, 2, 2, 4 };
            int sames = 1, bestSames = 1, bestStart = 0, lastElement = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] + 1 == a[i + 1])
                {
                    sames++;
                    if (sames > bestSames)
                    {
                        bestSames = sames;
                        lastElement = i + 1;
                        bestStart = lastElement - bestSames + 1;
                    }
                }
                else
                    sames = 1;
            }
            WriteLine();
            for (int i = bestStart; i < bestSames + bestStart; i++)

                Write("{0} ", a[i]);

            ReadLine();
        }
    }
}


using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            int[] a = { 3, 2, 1, 10, 5, 4, 0 };
            int temp;
            int index;
            for (int i = 0; i < a.Length; i++)
            {
                index = i;
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[index] > a[j])
                    {
                        index = j;
                    }
                    temp = a[i];
                    a[i] = a[index];
                    a[index] = temp;
                }
            }
            WriteLine(string.Join(" ", a));

            ReadLine();
        }
    }
}

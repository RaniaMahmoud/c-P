using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -3, -1, 1, 2, 3, 4, 5 };
            int x = int.Parse(ReadLine());
            int l = 0, h = arr.Length - 1;
            bool b = false;
            while (l <= h)
            {
                int m = l + (h - l) / 2;

                if (arr[m] == x)
                {
                    WriteLine(m);
                    b = true;
                    break;
                }
                else if (arr[m] < x)
                    l = m + 1;

                else
                    h = m - 1;
                
            }
            if (b)
            {
                WriteLine();
            }
            else
            {
                WriteLine(-1);
            }
            ReadLine();
        }
    }
}

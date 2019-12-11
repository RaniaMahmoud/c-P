using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(ReadLine());
            int i = 2;
            while (i < n / 2)
            {
                if (n % i == 0)
                    Write(i + " ");
                i++;
            }

            ReadKey();
        }
    }
}

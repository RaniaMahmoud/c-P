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

            int n;
            bool b = int.TryParse(ReadLine(), out n);
            double sum = 0.0;
            if (b)
            {

                for (double i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        Write("-" + 1 + "/" + i + " ");
                    }
                    else
                        Write("-" + 1 + "/" + i + " ");
                }
                WriteLine((float)sum);
            }
            else
                WriteLine(" Not valid ");
            ReadKey();
        }
    }
}

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
            double sum = 1;
            if (b)
            {
                Write(1 + " ");
                for (double i = 2; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        Write("+" + 1 + "/" + i + " ");
                        sum += (1D / i);
                    }
                    else
                    {
                        sum -= (1D / i);
                        Write("-" + 1 + "/" + i + " ");
                    }
                }
                WriteLine(@"{0:F3}",sum);
            }
            else
                WriteLine(" Not valid ");
            ReadKey();
        }
    }
}

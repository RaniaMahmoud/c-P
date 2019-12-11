using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2400, k = 2800;
            bool flag = true;
            int n = 0;
            while (i<k)
            {
                flag = true;
                for (int j = 2; j < 10; j++)
                {
                    if (i % j != j - 1)
                    {
                        flag = false;
                        n = i;
                        break;
                    }

                }

                if (flag)
                {
                    n = i;
                }

                i++;
            }
            WriteLine($"The number is {i}");
            ReadKey();

        }
    }
}

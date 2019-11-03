using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16
{
    class Program
    {
        static void Main(string[] args)
        {
            //N!*K! / (K - N)! for given N and K(1 < N < K)
            int n, k, sN = 1, sK = 1,sD=1;
            bool b1 = int.TryParse(ReadLine(), out n);
            bool b2 = int.TryParse(ReadLine(), out k);
            if (b1 && b2)
            {
                if (1 < n && n < k)
                {
                    for (int i = 2; i <= n; i++)
                    {
                        sN *= i;
                    }
                    for (int i = 2; i <= k; i++)
                    {
                        sK *= i;
                    }
                    k -= n;
                    for (int i = 2; i <= k; i++)
                    {
                        sD *= i;
                    }
                    WriteLine((sN * sK) / sD);
                }
                else
                    WriteLine("NOT val");
            }
            else
                WriteLine("NOT");
            ReadKey();
        }
    }
}

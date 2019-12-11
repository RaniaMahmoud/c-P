using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k,sN=1,sK=1;
            bool b1 = int.TryParse(ReadLine(), out n);
            bool b2 = int.TryParse(ReadLine(), out k);
            //if (b1 && b2)
            //{
            //    if (1 < k && k < n)
            //    {
            //        for (int i = 2; i <= n; i++)
            //        {
            //            sN *= i;
            //        }
            //        for (int i = 2; i <= k; i++)
            //        {
            //            sK *= i;
            //        }
            //        WriteLine(sN / sK);
            //    }
            //    else
            //        WriteLine("NOT val");
            //}
            //else
            //    WriteLine("NOT");
            int sN2 = 1;
            for (int i = k + 1; i <= n; i++)
            {
                sN2 *= i;
            }
            WriteLine(sN2);
            ReadKey();
        }
    }
}

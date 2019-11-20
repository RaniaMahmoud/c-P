using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, a,r=0;
            bool b1 = int.TryParse(ReadLine(), out n1);
            bool b2 = int.TryParse(ReadLine(), out n2);
            if (b1 && b2)
            {
                r = n1 % n2;
                for (int i = 0; r > 0; i++)
                {
                    r = n1 % n2;
                    a = n1 / n2;
                    n1 = n2;
                    n2 = r;
                }
                WriteLine(n1);
            }
            else
                WriteLine("NOT");

            while (n1 != n2)
            {
                if (n1 > n2)
                    n1 = n1 - n2;
                else
                    n2 = n2 - n1;
            }

            ReadKey();
        }
    }
}

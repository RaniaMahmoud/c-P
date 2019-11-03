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
            int n1, n2, n3;
            bool b1 = int.TryParse(ReadLine(), out n1);
            bool b2 = int.TryParse(ReadLine(), out n2);
            bool b3 = int.TryParse(ReadLine(), out n3);
            if (b1 && b2 && b3)
            {
                if (n1 > n2 && n1 > n3)
                {
                    WriteLine(n1);
                }
                else if (n2 > n3 && n2 > n1)
                {
                    WriteLine(n2);
                }
                else
                {
                    WriteLine(n3);
                }
            }
            else
                WriteLine(" Not valid ");
            ReadKey();
        }
    }
}

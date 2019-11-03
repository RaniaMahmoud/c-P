using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool b = int.TryParse(ReadLine(), out num);
            int n1 =0;
            bool f = false;
            int val = 0;

            if (b)
            {

                WriteLine(((num >> 3) & 1) == 1 ? 1 : 0);

                //while (num > 0)
                //{
                //    int remainder = num % 10;
                //    n1 = (n1 * 10) + remainder;
                //    num = num / 10;
                //}

                //for (int i = 1; i <= 3; i++)
                //{
                //    val = n1 % 10;
                //    n1 /= 10;
                //    if (i == 3 && val == 0)
                //    {
                //        f = true;
                //    }
                //}
                //if (f)
                //    WriteLine("true");
                //else
                //    WriteLine("false");
            }
            else
                WriteLine("Not valid");


            ReadKey();
        }
    }
}

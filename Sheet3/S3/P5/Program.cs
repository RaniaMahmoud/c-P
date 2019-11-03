using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    class Program
    {
        static void Main(string[] args)
        {
            int p;
            int v;
            bool f = false;
            bool b1 = int.TryParse(ReadLine(), out v);
            bool b2 = int.TryParse(ReadLine(), out p);
            if (b1 && b2)
            {
                int mask = 1 << p;

                WriteLine((v & mask) != 0 ? 1 : 0);
            }
            else
                WriteLine("Not valid");

            //if ((v & mask) == mask)
            //{
            //    f = true;
            //}
            //int mask2 = 1 << p;
            //if ((v & mask2) != 0)
            //{
            //    WriteLine("TTT");
            //}
            //WriteLine(f);
            ReadKey();
        }

    }
}

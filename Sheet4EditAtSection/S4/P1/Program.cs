using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sB = new StringBuilder(ReadLine(), 20);
            if (sB.Length == 20)
            {
                WriteLine(sB);
            }
            else
            {

                for (int i = sB.Length; i < 20; i++)
                {

                    sB.Append("*");
                }
                WriteLine(sB);
            }
            ReadKey();
        }
    }
}

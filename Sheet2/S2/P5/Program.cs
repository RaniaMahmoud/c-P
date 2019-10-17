using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace P5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int a=0;
            int b=0;
            int c=0;
            while (i<=3)
            {
                string data = string.Format("Enter "+ (char)(96 + i) + " then press Enter:");
                WriteLine(data);
                if (i == 1)
                    a = int.Parse(ReadLine());
                else if (i == 2)
                    b = int.Parse(ReadLine());
                else
                {
                    c = int.Parse(ReadLine());
                }

                    i++;
            }
            double Delta = Math.Pow(b, 2) - 4 * (a * c);
            WriteLine("the dicremint is :" + Delta);
            ReadKey();
        }
    }
}

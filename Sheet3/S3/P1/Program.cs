using System;
using static System.Console;
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
            bool flag = false;
            Write("Enter the number:");
            int num;
            bool b = int.TryParse(ReadLine(), out num);
            if (b)
            {
                if ((num / 100) % 10 == 7)
                {
                    flag = true;
                }
                WriteLine("Is the third digit equal to 7?:{0}", flag);
            }
            else
            {
                WriteLine("Not a valid entry!");
            }

            bool f = false;
            int n = 0;

            if (b)
            {
                for (int i = 1; i <= 3; i++)
                {
                    n = num % 10;
                    num /= 10;
                    if (i == 3 && n == 7)
                    {
                        f = true;
                    }
                }
                if (f)
                    WriteLine("true");
                else
                    WriteLine("false");
            }
            else
                WriteLine("not valid");

            ReadKey();
        }
    }
}

using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(ReadLine());
            int x=0;
            for(int i = 1; i <= num; i++)
            {
                Write(i+" ");
                x = (i + num);
                for (int j = 1; j < num; j++)
                {
                    Write(x+" ");
                    x += num;
                }
                WriteLine();
            }
            ReadKey();
        }
    }
}

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
            //int x=0;
            //for(int i = 1; i <= num; i++)
            //{
            //    Write(i+" ");
            //    x = (i + num);
            //    for (int j = 1; j < num; j++)
            //    {
            //        Write(x+" ");
            //        x += num;
            //    }
            //    WriteLine();
            //}

            int[,] max = new int[num, num];
            for (int row = 0, count = 1; row < num; row++)
            {
                for (int col = 0; col < num; col++)
                {
                    max[col, row] = count++;
                }
            }

            //print 

            for (int row = 0; row < num; row++)
            {
                for (int col = 0; col < num; col++)
                {
                    Write("{0,4}", max[row, col]);
                }
                WriteLine();
            }
            ReadKey();
        }
    }
}

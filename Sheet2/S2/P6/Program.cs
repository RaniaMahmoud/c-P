using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 0, column = 0;
            int n = int.Parse(ReadLine());
            n = (n * 2) + 1;
            while (row < n)
            {
                column = 0;
                while (column < n)
                {
                    if ((n - 1) / 2 == row || (n - 1) / 2 == column || row + column == n - 1 || column == row)
                    {
                        if (column == (n/2) && row == (n / 2))
                            Write("O");
                        else
                            Write("*");
                    }
                    else
                        Write(" ");
                    column++;
                }
                Write("\n");
                row++;
            }
            ReadKey();
        }
    }
}

﻿using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(ReadLine());
            string seq = num + " ";
            Write(num + " ");
            while (num > 1)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                    seq += num + " ";
                }
                else
                {
                    num = (num * 3) + 1;
                    seq += num + " ";
                }
                Write(num+" ");
            }
            WriteLine();
            WriteLine(seq);
            ReadKey();
        }

    }
}

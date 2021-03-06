﻿using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7
{
    class Program
    {
        static void Main(string[] args)
        {
            long number;
            int p, q, k;
            bool b4 = long.TryParse(ReadLine(), out number);
            bool b1 = int.TryParse(ReadLine(), out p);
            bool b2 = int.TryParse(ReadLine(), out q);
            bool b3 = int.TryParse(ReadLine(), out k);

            double nD = 0;

            if (b1 && b2 && b3 && b4)
            {
                byte[] nB = new byte[32];
                for (int i = 0; i < nB.Length; i++)
                {
                    if (number == 0)
                    {
                        break;
                    }
                    nB[i] = (byte)(number % 2);
                    number = number / 2;
                }
                for (int i = nB.Length - 1; i >= 0; i--)
                {
                    Write(nB[i]);
                    if ((i + 4) % 4 == 0)
                        Write(" ");

                }
                // Making the change
                for (int i = 0; i < k; i++)
                {
                    byte temp = nB[p];
                    nB[p] = nB[q];
                    nB[q] = temp;
                    p++;
                    q++;
                }
                WriteLine();
                for (int i = nB.Length - 1; i >= 0; i--)
                {
                    Write(nB[i]);
                    nD += (Math.Pow(2, i) * nB[i]);
                }

                // Output
                WriteLine();
                WriteLine(nD);
            }
            else
            {
                WriteLine("Not a valid entry!");
            }
            ReadKey();
        }
    }
}

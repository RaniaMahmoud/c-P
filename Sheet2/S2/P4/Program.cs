using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace P4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "", b = "", c = "", d = "";
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    a+="*";
                }
                a+= Environment.NewLine;
            }
            WriteLine(a);
            for (int i = 10; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    b+=("*");
                }
                b+=Environment.NewLine;
            }
            WriteLine(b);
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10-i; j++)
                {
                    c+=(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    c+=("*");
                }

                c+=Environment.NewLine;
            }
            WriteLine(c);
            for (int i = 10; i > 0; i--)
            {
                for (int j = 0; j < 10 - i; j++)
                {
                    d+=(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    d+=("*");
                }

                d+=Environment.NewLine;
            }
            int sp, st;
            for (int i = 1; i <= 10; i++)
            {
                sp = 10 - i;
                st = i;
                d += new string(' ', sp) + new string('*', st) + Environment.NewLine;
            }

            WriteLine(d);
            ReadKey();
        }
    }
}

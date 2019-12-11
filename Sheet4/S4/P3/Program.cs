using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string s = ReadLine();
            string r = string.Empty;
            for(int i = 0; i < s.Length; i++)
            {
                r += string.Format(@"\u{0:X4}", (int)s[i]);
            }
            WriteLine(r);

            ReadKey();
        }
    }
}

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
            foreach (char c in s)
                sb.Append("\\u" + ((int) c).ToString("X4"));
            WriteLine(sb.ToString());
            ReadKey();
        }
    }
}

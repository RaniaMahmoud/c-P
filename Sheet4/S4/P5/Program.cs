using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = ReadLine();
            char[] c = s.ToCharArray();
            Array.Reverse(c);
            WriteLine(c);
            ReadKey();
        }
    }
}

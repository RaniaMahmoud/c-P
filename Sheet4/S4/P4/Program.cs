using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = ReadLine();
            string[] s = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(s);
            WriteLine(string.Join("\n", s));
            ReadKey();
        }
    }
}

using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "C# is not C++ not PHP and not Delphi!";
            char c = str[str.Length - 1];
            str=str.Remove(str.Length - 1);
            string []s = str.Split(new char [] {' '}, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(s);
            WriteLine(string.Join(" ",s)+c);           
            ReadKey();
        }
    }
}

using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = " ";
            char pad = '*';
            Console.WriteLine(s1.PadRight(1, pad));
            Console.WriteLine(s1.PadRight(2, pad));
            Console.WriteLine(s1.PadRight(3, pad));
            Console.WriteLine(s1.PadRight(4, pad));
            Console.WriteLine(s1.PadRight(5, pad));
            Console.WriteLine(s1.PadRight(6, pad));
            WriteLine(@"
                 *
                 **
                 ***
                 ****   
");
            Console.ReadKey();
        }
    }
}

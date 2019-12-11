using static System.Console;
using System;
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
            int a = Convert.ToInt32(ReadLine());
            int b = int.Parse(ReadLine());
            Console.WriteLine("Before:\na= " + a + "\n" + "b= " + b);
            int tmp = a;
            a = b;
            b = tmp;
            Console.WriteLine("After:\na= " + a + "\n" + "b= " + b);
            Console.ReadKey();
        }
    }
}

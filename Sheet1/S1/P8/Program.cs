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
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine((a + b) * 2);
            Console.WriteLine(a * b);
            Console.WriteLine(Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2))));
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("sum =" + (x + y));
            Console.WriteLine("product =" + (x * y));
            Console.WriteLine("difference =" + (x>y?x-y:y-x));
            Console.WriteLine("divition =" + (x / y));
            Console.ReadKey();
        }
    }
}

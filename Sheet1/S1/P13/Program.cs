using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13
{
    class Program
    {
        static void Main(string[] args)
        {
            //y = ax3 + 7
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow(x,3) + " a + " + "7");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 letters:");
            char c1 = char.Parse(Console.ReadLine());
            char c2 = char.Parse(Console.ReadLine());
            char c3 = char.Parse(Console.ReadLine());
            Console.WriteLine(c3+""+c2+""+c1);
            Console.ReadKey();
        }
    }
}

using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace S2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter a then press Enter:");
            int a = int.Parse(ReadLine());
            WriteLine("Enter b then press Enter:");
            int b = int.Parse(ReadLine());
            WriteLine("Enter c then press Enter:");
            int c = int.Parse(ReadLine());
            double Delta = Math.Pow(b,2) - 4 *( a * c);
            WriteLine("the dicremint is :"+ Delta);
            ReadKey();

        }
    }
}

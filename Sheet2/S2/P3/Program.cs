using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter an integer then press Enter:");
            int y = int.Parse(ReadLine());
            WriteLine("Enter an integer then press Enter:");
            int m = int.Parse(ReadLine());
            WriteLine("Enter an integer then press Enter:");
            int x = int.Parse(ReadLine());
            int b = y - (m * x);
            WriteLine($"{y}={m}x+{b}");
            ReadKey();
        }
    }
}

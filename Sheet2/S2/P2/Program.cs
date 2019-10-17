using static System.Console;
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
            WriteLine("Enter an integer then press Enter:");
            int a = int.Parse(ReadLine());
            if (a < 100)
                WriteLine("the New Value is: " + a * 10);
            else
                WriteLine(a);
            ReadKey();
        }
    }
}

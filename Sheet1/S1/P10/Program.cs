using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(ReadLine());
            int num2 = int.Parse(ReadLine());
            for (int i = num1; num2 >= i; i++)
            {
                Write((char)i+" ");
            }
            ReadKey();
        }
    }
}

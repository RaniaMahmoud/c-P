using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Write("*");
                }
                WriteLine(" ");
            }
            WriteLine(" ");
            for (int i = 10; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Write("*");
                }
                WriteLine(" ");
            }
            WriteLine(" ");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10-i; j++)
                {
                    Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Write("*");
                }

                WriteLine();
            }
            WriteLine(" ");
            for (int i = 10; i > 0; i--)
            {
                for (int j = 0; j < 10 - i; j++)
                {
                    Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Write("*");
                }

                WriteLine();
            }
            ReadKey();
        }
    }
}

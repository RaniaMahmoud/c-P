using static System.Console;
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
            int n1;
            bool b1 = int.TryParse(ReadLine(), out n1);

            if (b1)
            {
                switch (n1)
                {
                    case 1:
                    case 2:
                    case 3:
                        WriteLine(n1 * 10);
                        break;
                    case 4:
                    case 5:
                    case 6:
                        WriteLine(n1 * 100);
                        break;
                    case 7:
                    case 8:
                    case 9:
                        WriteLine(n1 * 1000);
                        break;
                    default:
                        WriteLine("Erro!!!!!!");
                        break;
                }
            }
            else
                WriteLine("NOT NUM");
            ReadKey();
        }
    }
}

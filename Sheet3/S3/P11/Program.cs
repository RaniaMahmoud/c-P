using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11
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
                        WriteLine("one");
                        break;
                    case 2:
                        WriteLine("two");
                        break;
                    case 3:
                        WriteLine("theer");
                        break;
                    case 4:
                        WriteLine("four");
                        break;
                    case 5:
                        WriteLine("five");
                        break;
                    case 6:
                        WriteLine("six");
                        break;
                    case 7:
                        WriteLine("seven");
                        break;
                    case 8:
                        WriteLine("eig");
                        break;
                    case 9:
                        WriteLine("nige");
                        break;
                    default:
                        WriteLine("NOT");
                        break;
                }
            }
            else
                WriteLine("NOT NOM");
            ReadKey();
        }
    }
}

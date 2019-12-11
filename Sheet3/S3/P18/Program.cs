using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int j = 1; j <= 4; j++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    switch (i)
                    {
                        case 1:
                            Write(" one ");
                            break;
                        case 2:
                            Write(" two ");
                            break;
                        case 3:
                            Write(" three ");
                            break;
                        case 4:
                            Write(" four ");
                            break;
                        case 5:
                            Write(" five ");
                            break;
                        case 6:
                            Write(" six ");
                            break;
                        case 7:
                            Write(" seven ");
                            break;
                        case 8:
                            Write(" eig ");
                            break;
                        case 9:
                            Write(" nige  ");
                            break;
                        case 10:
                            Write(" ten  ");
                            break;
                        default:
                            WriteLine("eroo ");
                            break;
                    }

                    switch (j)
                    {
                        case 1:
                            Write("  Diamonds \n");
                            break;
                        case 2:
                            Write("  Hearts  \n ");
                            break;
                        case 3:
                            Write("  Spades  \n ");
                            break;
                        case 4:
                            Write("  Clubs  \n  ");
                            break;
                        default:
                            WriteLine("eroo ");
                            break;
                    }

                }
                WriteLine();
            }
            ReadKey();
        }
    }
}

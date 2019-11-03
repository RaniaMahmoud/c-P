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
                switch (j)
                {
                    case 1:
                        WriteLine("Diamonds :");
                        break;
                    case 2:
                        WriteLine("Hearts :");
                        break;
                    case 3:
                        WriteLine("Spades :");
                        break;
                    case 4:
                        WriteLine("Clubs :");
                        break;
                }
                for (int i = 1; i <= 10; i++)
                {
                    switch (i)
                    {
                        case 1:
                            Write("one ,");
                            break;
                        case 2:
                            Write("two ,");
                            break;
                        case 3:
                            Write("three ,");
                            break;
                        case 4:
                            Write("four ,");
                            break;
                        case 5:
                            Write("five ,");
                            break;
                        case 6:
                            Write("six ,");
                            break;
                        case 7:
                            Write("seven ,");
                            break;
                        case 8:
                            Write("eig ,");
                            break;
                        case 9:
                            Write("nige ,");
                            break;
                        default:
                            WriteLine("ten ");
                            break;
                    }
                }
            }
            ReadKey();
        }
    }
}

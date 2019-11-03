using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5;
            bool b1 = int.TryParse(ReadLine(), out n1);
            bool b2 = int.TryParse(ReadLine(), out n2);
            bool b3 = int.TryParse(ReadLine(), out n3);
            bool b4 = int.TryParse(ReadLine(), out n4);
            bool b5 = int.TryParse(ReadLine(), out n5);
            if (b1 && b2 && b3 && b4 && b5)
            {
                if (n1 + n2 == 0)
                {
                    WriteLine("n1 - n2");
                }
                else if (n1 + n2 + n3 == 0)
                {
                    WriteLine("n1 - n2 - n3");
                }
                else if (n1 + n2 + n3 + n4 == 0)
                {
                    WriteLine("n1 - n2 - n3 - n4");
                }
                else if (n2 + n3 == 0)
                {
                    WriteLine("n2 - n3 ");
                }
                else if (n2 + n3 + n4 == 0)
                {
                    WriteLine("n2 - n3 -n4");
                }
                else if (n2 + n3 + n4 + n5 == 0)
                {
                    WriteLine("n2 - n3 - n4 -n5");
                }
                else if (n3 + n4 == 0)
                {
                    WriteLine("n3 - n4");
                }
                else if (n3 + n4 + n5 == 0)
                {
                    WriteLine("n3 - n4 - n5");
                }
                else if (n3 + n1 == 0)
                {
                    WriteLine("n3 - n1");
                }
                else if (n4 + n5 == 0)
                {
                    WriteLine("n4 - n5");
                }
                else if (n4 + n1 == 0)
                {
                    WriteLine("n4 - n1");
                }
                else if (n5 + n1 == 0)
                {
                    WriteLine("n5 - n1");
                }
                else
                    WriteLine("NO");
            }
            else
                WriteLine(" Not valid ");
            ReadKey();
        }
    }
}

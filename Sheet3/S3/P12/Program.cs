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

            int[] number = { 3, -2, 1, 1, 8 };
            long subsets = (long)(Math.Pow(2, number.Length) - 1);

            for (int i = 1; i <= subsets; i++)
            {
                List<int> currentSum = new List<int>();
                for (int j = 0; j < number.Length; j++)
                {
                    if ((i >> j & 1) == 1)
                    {
                        currentSum.Add(number[j]);
                    }
                }
                if (currentSum.Sum() == 0)
                {
                    Write("Zero Sum: ");

                    for (int j = 0; j < currentSum.Count; j++)
                    {
                        Write(j > 0 ? (currentSum[j] > 0 ? " + " + currentSum[j] + "" : " - " + Math.Abs(currentSum[j]) + "")
                                      : currentSum[j].ToString());
                    }

                    WriteLine(" = 0\n");
                    break;
                }
            }

            ReadKey();
        }
        ( x, y) =>
            {

            }
}
}


//int n1, n2, n3, n4, n5;
//bool b1 = int.TryParse(ReadLine(), out n1);
//bool b2 = int.TryParse(ReadLine(), out n2);
//bool b3 = int.TryParse(ReadLine(), out n3);
//bool b4 = int.TryParse(ReadLine(), out n4);
//bool b5 = int.TryParse(ReadLine(), out n5);
//            if (b1 && b2 && b3 && b4 && b5)
//            {
//                if (n1 + n2 == 0)
//                {
//                    WriteLine("n1 - n2");
//                }
//                else if (n1 + n2 + n3 == 0)
//                {
//                    WriteLine("n1 - n2 - n3");
//                }
//                else if (n1 + n2 + n3 + n4 == 0)
//                {
//                    WriteLine("n1 - n2 - n3 - n4");
//                }
//                else if (n2 + n3 == 0)
//                {
//                    WriteLine("n2 - n3 ");
//                }
//                else if (n2 + n3 + n4 == 0)
//                {
//                    WriteLine("n2 - n3 -n4");
//                }
//                else if (n2 + n3 + n4 + n5 == 0)
//                {
//                    WriteLine("n2 - n3 - n4 -n5");
//                }
//                else if (n3 + n4 == 0)
//                {
//                    WriteLine("n3 - n4");
//                }
//                else if (n3 + n4 + n5 == 0)
//                {
//                    WriteLine("n3 - n4 - n5");
//                }
//                else if (n3 + n1 == 0)
//                {
//                    WriteLine("n3 - n1");
//                }
//                else if (n4 + n5 == 0)
//                {
//                    WriteLine("n4 - n5");
//                }
//                else if (n4 + n1 == 0)
//                {
//                    WriteLine("n4 - n1");
//                }
//                else if (n5 + n1 == 0)
//                {
//                    WriteLine("n5 - n1");
//                }
//                else
//                    WriteLine("NO");
//            }
//            else
//                WriteLine(" Not valid ");

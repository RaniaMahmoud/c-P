using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int n=0;
            string s="";
            int temp = num;
            do
            {
                n = num % 16;
                num = num / 16;

                switch (n)
                {
                    case 10:
                        s = s + "A";
                        break;
                    case 11:
                        s = s + "B";
                        break;
                    case 12:
                        s = s + "C";
                        break;
                    case 13:
                        s = s + "D";
                        break;
                    case 14:
                        s = s + "E";
                        break;
                    case 15:
                        s = s + "F";
                        break;
                    default:
                      s = s + n.ToString();
                        break;
                }
            }
            while (num >= 16 || num == 1);
                char[] arr1 = s.ToCharArray();

            Array.Reverse(arr1);
            Array.ForEach(arr1, Write);
            WriteLine();

            s = "";
            num = temp;
            while (num != 0)
            {
                n = num % 2;
                s = s + n.ToString();
                num = num / 2;
            }
            char[] arr2 = s.ToCharArray();
            Array.Reverse(arr2);
            Array.ForEach(arr2, Write);

            WriteLine((Convert.ToString(num, 2)).ToUpper());
            WriteLine(Convert.ToString(num, 16));
            ReadKey();
        }
    }
}

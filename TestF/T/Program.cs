using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "22";
            //int y = 1;
            int [] a= { 1, 2, 5 };
            //st(a);
            //WriteLine(s+" "+y);
            //switch (s)
            //{
            //    case "ds":
            //        WriteLine("sfd");
            //        break;
            //}

            //int x = 10;
            //int y = 15;
            //// semicolon missed 
            //WriteLine(x + " " + y);
            //WriteLine(a[0]);

            //int[][] ragged_2d_array = new int[10][];
            //WriteLine("ragged_2d_array has rank: " + ragged_2d_array.Rank);
            //WriteLine("ragged_2d_array has type: " + ragged_2d_array.GetType());
            //WriteLine("Total number of elements: " + ragged_2d_array.Length);
            //WriteLine();
            //for (int i = 0; i < ragged_2d_array.GetLength(0); i++)
            //{
            //    ragged_2d_array[i] = new int[i + 1];
            //}
            //for (int i = 0; i < ragged_2d_array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < ragged_2d_array[i].GetLength(0); j++)
            //        ragged_2d_array[i][j] = 3;
            //}
            //for (int i = 0; i < ragged_2d_array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < ragged_2d_array[i].GetLength(0); j++)
            //        Write(ragged_2d_array[i][j] + " ");
            //    WriteLine();
            //}

            //int[] int_array = { 100, 45, 9, 1, 34, 22, 6, 4, 3, 2, 99, 66 };
            //WriteLine(string.Join(string.Empty, int_array));
            //Array.Sort(int_array);
            //WriteLine(string.Join(",", int_array));

            //for (int i = 0; i < ragged_2d_array.GetLength(0); i++)
            //{
            //    //for (int j = 0; j < ragged_2d_array[i].GetLength(0); j++)
            //    //    Write(ragged_2d_array[i][j] + " ");
            //    //WriteLine();
            //    string asd = string.Join(" ", ragged_2d_array[i]);
            //    WriteLine(asd);
            //}

            int[,] ar = new int[,] { {6,2 }, {10,6 }, {7,8 } };
            int[] ad = new int[3];
            for(int row = 0; row < 3; row++)
            {
                int max = ar[row, 0];
                for (int col = 0; col < 2; col++)
                {
                    if (max < ar[row, col])
                    {
                        max = ar[row, col];
                        ad[row] = max;
                    }
                    else
                        ad[row] = max;
                }
            }

            WriteLine(String.Join(" ", ad));


            ReadLine();
        }

        public static void st(out int x)
        {
            x = 0;
        }
        public static int st( int y)
        {
            return y = 5;
        }
    }
}

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
        static int binS(int []a,int v,int f,int e)
        {
            if (!a.Contains(v))
                return -1;
            int mid = (f + e) / 2;
            if (a[mid] == v)
                return mid;
            else if (a[mid] > v)
                return binS(a, v, 0, mid - 1);
            else
                return binS(a, v, mid + 1, a.Length - 1);

        }
        static void Main(string[] args)
        {
            int[] arr = { -3, -1, 1, 2, 3, 4, 5 };

            WriteLine(binS(arr, 3, 0, arr.Length));

            //int x = int.Parse(ReadLine());
            //int l = 0, h = arr.Length - 1;
            //bool b = false;
            //while (l <= h)
            //{
            //    int m = l + (h - l) / 2;

            //    if (arr[m] == x)
            //    {
            //        WriteLine(m);
            //        b = true;
            //        break;
            //    }
            //    else if (arr[m] < x)
            //        l = m + 1;

            //    else
            //        h = m - 1;
                
            //}
            //if (b)
            //{
            //    WriteLine();
            //}
            //else
            //{
            //    WriteLine(-1);
            //}
            ReadLine();
        }
    }
}

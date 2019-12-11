using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10
{
    class Program
    {
        static void di(int[] a)
        {
            Dictionary<int, int> fre = new Dictionary<int, int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (!fre.ContainsKey(a[i]))
                {
                    fre.Add(a[i], 1);
                }
                else
                    fre[a[i]]++;
            }
            var max = fre.Aggregate((l, r) => (l.Value) > (r.Value) ? l : r);
            WriteLine("{0} => {1} ", max.Key, max.Value);
        }
        static void Main(string[] args)
        {
            int[] a = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            // int c = 0;
            // int[] aC = new int[a.Length];
            // for (int i = 0; i < a.Length; i++)
            // {
            //     for(int j = 0; j < a.Length; j++)
            //     {
            //         if (a[i] == a[j])
            //         {
            //             c++;
            //         }
            //     }
            //     aC[i] = c;
            //     c = 0;
            // }
            // int large = aC[0];
            // int x = 0;
            // for (int i = 0; i < aC.Length; i++)
            // {
            //     if (large < aC[i])
            //     {
            //         large = aC[i];
            //         x = i;
            //     }
            // }

            // Array.Sort(a);
            // int counter = 0, tempCounter = 1, foundNumber = 0;
            //// int[] a = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            // for (int i = 0; i < a.Length - 1; i++)
            // {
            //     if (a[i] == a[i + 1])
            //         tempCounter++;
            //     else
            //         tempCounter = 1;

            //     if (tempCounter > counter)
            //     {
            //         counter = tempCounter;
            //         foundNumber = a[i];
            //     }
            // }

            // WriteLine(aC.Max());

            // WriteLine(foundNumber + " -> "+ counter);


            di(a);


            ReadLine();
        }
    }
}

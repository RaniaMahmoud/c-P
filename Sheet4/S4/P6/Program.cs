using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = ReadLine();
            string key = "cipher";
            int[] x = new int[str.Length];
            StringBuilder s = new StringBuilder();
            for(int i = 0; i < str.Length; i++)
            {
                s.Append((char)(str[i] ^ key[i % key.Length]));
            }
            WriteLine(s.ToString());
            //for(int i = 0, j=0 ; i < str.Length; i++,j++)
            //{
            //    if (j == 5)
            //    {
            //        x[i] = str[i] ^ key[j];
            //        j = -1;
            //    }
            //    else
            //    {
            //        x[i] = str[i] ^ key[j];
            //    }
            //}
            ReadKey();
        }
    }
}

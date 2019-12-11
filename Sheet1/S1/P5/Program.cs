using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = ReadLine();
            bool val = true;
            WriteLine(s1.ToLower().Equals("true") ? "Yes" : "No");
            float[] nums = { Single.MaxValue, -193.0012f, 20e-15f, 0f, 10551e-10f, 100.3398f, Single.MaxValue };
            foreach(var num in nums)
            {
                WriteLine($"{num} ---> {val} ", num, Convert.ToBoolean(num));
            }
            ReadKey();
        }
    }
}

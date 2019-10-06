using System;
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
            string s1 = "True";
            string s2 = "False";

            Console.WriteLine(Convert.ToBoolean(s1) ? "Yes":"No" + "\n");
            Console.WriteLine(Convert.ToBoolean(s2) ? "Yes" : "No" + "\n");
            Console.ReadKey();
        }
    }
}

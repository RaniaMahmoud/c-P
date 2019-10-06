using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "0xFE";
            int n1 = Convert.ToInt32(s1, 16);
            string s2 = "0x37";
            int n2 = Convert.ToInt32(s2, 16);
            string s3 = "0x10";
            int n3 = Convert.ToInt32(s3, 16);
            Console.WriteLine(s1 + "\n" + n1 + "\n"+s2 + "\n" + n2 + "\n"+ s3 + "\n" + n3 + "\n");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int i = 1; i <= 4; i++)
            //{
            //    for(int j = 1; j <= 4; j++)
            //    {
            //        if(i==1|| i == 4|| j == 1 || j == 4)
            //            Console.Write("*");
            //        else
            //            Console.Write(" ");

            //    }
            //    Console.WriteLine();
            //}

            for (int i2 = 1; i2 <= 4; i2++)
            {
                for (int j2 = 1; j2 <= 3; j2++)
                {
                    Console.Write((i2 == 1 || i2 == 4 || j2 == 1 ? "*" : " ")+(j2 == 3?"*\n":""));
                }
            }
            Console.ReadKey();
        }
    }
}

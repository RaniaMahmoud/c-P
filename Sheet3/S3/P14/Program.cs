using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] sN;
            int min = int.MaxValue;
            int max = int.MinValue;
            bool b=true;
            Write("numbers delimited with \",\":");
            sN = (ReadLine()).Split(',');
            int [] num = new int [sN.Length];
            for(int i=0;i< sN.Length; i++)
            {
                b= int.TryParse(sN[i], out num[i]);
                if (b == false)
                {
                    break;
                }
            }
            if (b)
            {
                for (int i = 0; i < num.Length; i++)
                {
                    if (num[i] < min)
                        min = num[i];
                    if (num[i] > max)
                        max = num[i];
                }
                WriteLine("min= {0} \n max= {1}", min, max);
            }
            else


            ReadKey();
        }
    }
}

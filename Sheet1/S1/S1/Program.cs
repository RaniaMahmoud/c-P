using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte s1 = -100;
            byte s2 = 128;
            short s3 = -3540;
            ushort s4 = 64876;
            uint s5 = 2147483648;
            int s6 = -1141583228;
            long s7 = -1223372036854775808;

            WriteLine(s1 +"\n"+s2 + "\n"+s3 + "\n"+s4 + "\n"+s5 + "\n"+s6 + "\n"+s7);
            ReadKey();
        }
    }
}

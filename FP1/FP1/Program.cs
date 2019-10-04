using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace FP1
{
    class Program
    {
        //static void Main(string[] args)
        //{

        //    //WriteLine("Hey!!!");

        //    //string s = ReadLine();
        //    //WriteLine(int.Parse(s)+10);
        //    //int s1 = 10;
        //    //WriteLine(s1.ToString() + 10);

        //    Process p = new Process();
        //    p.StartInfo.FileName = "d.txt";
        //    p.StartInfo.Arguments = "param1 param2";
        //    p.Start();
        //    p.WaitForExit();
        //    WriteLine(args[0]);
        //    ReadKey();
        //}
        static void Main()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("ArgsEcho.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
          
            startInfo.Arguments = "adsdfgh";
            Process.Start(startInfo);

        }
    }
}

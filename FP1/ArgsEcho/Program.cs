using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgsEcho
{
    class ArgsEcho
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Received the following arguments:\n");
            //Console.WriteLine(args[0]);

            for (var i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"[{i}] = {args[i]}");
            }

            Console.WriteLine("\nPress any key to exit");
            Console.ReadLine();
        }
    }
}

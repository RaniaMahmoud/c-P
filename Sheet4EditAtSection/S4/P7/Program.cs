using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace P7
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = ReadLine();
            char[] brac = new char[s.Length];
            brac = s.ToCharArray();
            Stack ArrStack = new Stack();
            bool flag = true;
            for (int i = 0; i < s.Length; i++)
            {
                string item = brac[i].ToString();
                if (item == "(")
                {
                    ArrStack.Push(brac[i]);
                }
                else if (ArrStack.Count > 0)
                {
                    if (item == ")")
                    {
                        if (ArrStack.Peek().ToString() == "(")
                        {
                            ArrStack.Pop();
                        }
                        else
                            flag = false;
                    }
                }
                else
                    flag = false;

            }
            WriteLine(flag ? "tepical" : "NOT");
            ReadKey();
        }
    }
}

using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P11
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = ReadLine();
            int k = 0;
            string st=null;
            int l = s.Length;
            bool b = false;
            int i=0;
            while (k < l / 2)
            {
                if (s[k] == s[l-k-1])
                {
                    k++;
                    b = true;
                }
                else
                {
                    b = false;
                    WriteLine(" NOT ");
                    break;
                }
            }

            if (b)
            {
                WriteLine(" YES ");
                i = 1;
                while (i <= l)
                {
                    int j = 1;
                    while (j <= l)
                    {
                        if (i == 1 || i == l || j == 1 || j == l)
                        {
                            if (i - j > j - i)
                                st += s[i - j];
                            else
                                st += s[j - i];
                        }
                        else
                            st +=" ";
                        j++;
                    }
                    i++;
                    st+=Environment.NewLine;
                }
                MessageBox.Show(st);
            }
            ReadKey();
        }
    }
}

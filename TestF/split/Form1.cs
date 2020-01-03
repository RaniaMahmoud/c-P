using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace split
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string exp = textBox1.Text;
            SimpleExp ex = new SimpleExp(exp);
            int []a = ex.ExtactNum(exp);
            string[] s = ex.ExtactOp(exp);
            for(int i = 0; i < a.Length; i++)
            {
                listBox1.Items.Add(a[i].ToString());
            }
            for (int i = 0; i < s.Length; i++)
            {
                listBox2.Items.Add(s[i].ToString());
            }
            textBox2.Text = ex.Calc(a.Length,s.Length).ToString();
        }
    }

    public class SimpleExp
    {
        private int[] num;
        private string[] exp;
        string s;
        int x = 0;
        public SimpleExp(string s)
        {
            this.s = s;
            ExtactNum(s);
            ExtactOp(s);
        }

        public int [] ExtactNum(string e)
        {
            string[] n = e.Split(new char[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);
            num = new int[n.Length];
            for (int i = 0; i < n.Length; i++)
            {
                num[i] = int.Parse(n[i]);
            }
            x = e.Length - n.Length;
            return num;
        }
        public string [] ExtactOp(string  e)
        {
            exp = new string[x];
            int z = 0;
            for(int i = 0; i < e.Length; i++)
            {
                if(e[i]=='+'||e[i]=='/' || e[i] == '*' || e[i] == '-')
                {
                    exp[z++] = e[i].ToString();
                }
            }
            return exp;
        }
        public int Calc(int x,int y)
        {
            int s = x;
            int i = 0;
            int t = y;
            //int z = exp.Length;


            for(int k = 0; i < t; i++)
            {
                switch (exp[k])
                {
                    case "+":
                        num[i + 1] = num[i] + num[i + 1];
                        break;
                    case "-":
                        num[i + 1] = num[i] - num[i + 1];
                        break;
                    case "*":
                        num[i + 1] = num[i] * num[i + 1];
                        break;
                    case "/":
                        num[i + 1] = num[i] / num[i + 1];
                        break;
                }
                ++i;
            }

            return num[x - 1];
        }
    }
}

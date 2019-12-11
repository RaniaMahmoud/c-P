using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int num;
            bool b;
            string s = "";
            b = int.TryParse(textBox1.Text, out num);
            if (b) { 
            if (radioButton1.Checked)
            {
                    check c = new check();
                    c.Mod(num, out s);
                    textBox2.Text = s;

            }

            if (radioButton2.Checked)
            {
                    check c = new check();
                    c.Bitw(num, out s);
                    textBox2.Text = s;
                }

            if (radioButton3.Checked)
            {
                    check c = new check();
                    c.Div(num, out s);
                    textBox2.Text = s;
                }

            if (radioButton4.Checked)
            {
                    check c = new check();
                    c.Shift(num, out s);
                    textBox2.Text = s;
                }

            if (radioButton5.Checked)
            {
                    check c = new check();
                    c.LastD(num, out s);
                    textBox2.Text = s;
                }
          }
        }
    }

    public class check
    {
        public void Mod(int num, out string typ)
        {
            if (num % 2 == 0)
                typ = "Even";
            else
                typ = "Odd";
        }
        public void LastD(int num, out string typ)
        {
            string s = num.ToString();
            if (s[s.Length - 1] == 2 || s[s.Length - 1] == 4 || s[s.Length - 1] == 6 || s[s.Length - 1] == 8)
                typ = "Even";
            else
                typ = "Odd";
        }
        public void Div(int num, out string typ)
        {
            if ((num / 2) * 2 == num)
                typ = "Even";
            else
                typ = "Odd";
        }
        public void Bitw(int num, out string typ)
        {
            if ((num & 1) == 0)
                typ = "Even";
            else
                typ = "Odd";
        }
        public void Shift(int num, out string typ)
        {
            if ((num >> 1) << 1 == num)
                typ = "Even";
            else
                typ = "Odd";
        }
    }

}

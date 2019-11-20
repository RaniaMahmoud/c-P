using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1
{
    public partial class Form1 : Form
    {
        string num = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
            num += button1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += button11.Text;
            num += button11.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
            num += button9.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
            num += button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
            num += button10.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
            num += button8.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
            num += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
            num += button6.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
            num += button3.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
            num += button7.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
            num += button2.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += button17.Text;
            num += button17.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += button16.Text;
            num += button16.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string n = null;
            int indx=0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].ToString() != "+" || s[i].ToString() != "-" || s[i].ToString() != "x" || s[i].ToString() != "/")
                {
                    n += s[i].ToString();
                }
                else if (s[i].ToString() == "+" || s[i].ToString() == "-" || s[i].ToString() == "x" || s[i].ToString() == "/")
                {
                    string op = s[i].ToString();
                     indx = i;
                }
            }
                    if (s[indx].ToString() == "+")
                    {
                        textBox1.Text = (int.Parse(n[indx - 1].ToString()) + int.Parse(n[indx + 1].ToString())).ToString();
                    }
                    else if (s[indx].ToString() == "-")
                    {
                        textBox1.Text = (int.Parse(n[indx - 1].ToString()) - int.Parse(n[indx + 1].ToString())).ToString();

                    }
                    else if (s[indx].ToString() == "x")
                    {
                        textBox1.Text = (int.Parse(n[indx - 1].ToString()) * int.Parse(n[indx + 1].ToString())).ToString();

                    }
                    else if (s[indx].ToString() == "/")
                    {
                        textBox1.Text = (int.Parse(n[indx-1].ToString()) / int.Parse(n[indx + 1].ToString())).ToString();

                    }
                    else
                        n += s[indx].ToString();
                }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += button14.Text;
            num += button14.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += button13.Text;
            num += button13.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += button12.Text;
            num += button12.Text;
        }

    }
}

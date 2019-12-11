using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string s = "";
                pol p = new pol();
                p.add(textBox1.Lines, textBox2.Lines, out s);
                textBox3.Text = s;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                string s = "";
                pol p = new pol();
                p.sub(textBox1.Lines, textBox2.Lines, out s);
                textBox3.Text = s;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                string s = "";
                pol p = new pol();
                p.Mult(textBox1.Lines, textBox2.Lines, out s);
                textBox3.Text = s;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    public class pol
    {
        public void add(string []a1,string []a2,out string reslt)
        {
            reslt = "";
            int[] inta1 = new int [a1.Length];
            int[] inta2 = new int[a2.Length];

            for (int i = 0; i < a1.Length; i++)
            {
                inta1[i] = int.Parse(a1[i]);
            }
            for (int i = 0; i < a2.Length; i++)
            {
                inta2[i] = int.Parse(a2[i]);
            }

            if (a1.Length >= a2.Length)
            {
                
                for (int i = 0; i < inta2.Length; i++)
                {
                    inta1[i] = inta1[i] + inta2[i];
                }

            }
            else
            {
                
                for (int i = 0; i < inta1.Length; i++)
                {
                    inta2[i] = inta1[i] + inta2[i];
                }
            }
            if (a1.Length >= a2.Length)
            {
                reslt = inta1[0].ToString();
                for (int i = 1; i < inta1.Length; i++)
                {
                    reslt += $"+{inta1[i]}X^{i}";
                }
            }
            else
            {
                reslt = inta2[0].ToString();
                for (int i = 1; i < inta2.Length; i++)
                {
                    reslt += $"+{inta2[i]}X^{i}";
                }
            }
        }

        public void sub(string[] a1, string[] a2, out string reslt)
        {
            reslt = "";
            int[] inta1 = new int[a1.Length];
            int[] inta2 = new int[a2.Length];

            for (int i = 0; i < a1.Length; i++)
            {
                inta1[i] = int.Parse(a1[i]);
            }
            for (int i = 0; i < a2.Length; i++)
            {
                inta2[i] = int.Parse(a2[i]);
            }

            if (a1.Length >= a2.Length)
            {

                for (int i = 0; i < inta2.Length; i++)
                {
                    inta1[i] = inta1[i] - inta2[i];
                }

            }
            else
            {

                for (int i = 0; i < inta1.Length; i++)
                {
                    inta2[i] = inta1[i] - inta2[i];
                }
            }
            if (a1.Length >= a2.Length)
            {
                reslt = inta1[0].ToString();
                for (int i = 1; i < inta1.Length; i++)
                {
                    reslt += $"+{inta1[i]}X^{i}";
                }
            }
            else
            {
                reslt = inta2[0].ToString();
                for (int i = 1; i < inta2.Length; i++)
                {
                    reslt += $"+{inta2[i]}X^{i}";
                }
            }
        }

        public void Mult(string[] a1, string[] a2, out string reslt)
        {
            reslt = "";
            int[] inta1 = new int[a1.Length];
            int[] inta2 = new int[a2.Length];

            for (int i = 0; i < a1.Length; i++)
            {
                inta1[i] = int.Parse(a1[i]);
            }
            for (int i = 0; i < a2.Length; i++)
            {
                inta2[i] = int.Parse(a2[i]);
            }

            if (a1.Length >= a2.Length)
            {

                for (int i = 0; i < inta2.Length; i++)
                {
                    inta1[i] = inta1[i] * inta2[i];
                }

            }
            else
            {

                for (int i = 0; i < inta1.Length; i++)
                {
                    inta2[i] = inta1[i] * inta2[i];
                }
            }
            if (a1.Length >= a2.Length)
            {
                reslt = inta1[0].ToString();
                for (int i = 1; i < inta1.Length; i++)
                {
                    reslt += $"+{inta1[i]}X^{i}";
                }
            }
            else
            {
                reslt = inta2[0].ToString();
                for (int i = 1; i < inta2.Length; i++)
                {
                    reslt += $"+{inta2[i]}X^{i}";
                }
            }
        }

        public void EVl(string[] a1, string[] a2, out string reslt)
        {
            reslt = "";
            int[] inta1 = new int[a1.Length];
            int[] inta2 = new int[a2.Length];

            for (int i = 0; i < a1.Length; i++)
            {
                inta1[i] = int.Parse(a1[i]);
            }
            for (int i = 0; i < a2.Length; i++)
            {
                inta2[i] = int.Parse(a2[i]);
            }

            if (a1.Length >= a2.Length)
            {

                for (int i = 0; i < inta2.Length; i++)
                {
                    inta1[i] = inta1[i] + inta2[i];
                }

            }
            else
            {

                for (int i = 0; i < inta1.Length; i++)
                {
                    inta2[i] = inta1[i] + inta2[i];
                }
            }
            if (a1.Length >= a2.Length)
            {
                reslt = inta1[0].ToString();
                for (int i = 1; i < inta1.Length; i++)
                {
                    reslt += $"+{inta1[i]}X^{i}";
                }
            }
            else
            {
                reslt = inta2[0].ToString();
                for (int i = 1; i < inta2.Length; i++)
                {
                    reslt += $"+{inta2[i]}X^{i}";
                }
            }
        }
    }

}

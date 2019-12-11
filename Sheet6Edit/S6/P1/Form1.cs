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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int .Parse(textBox2.Text);
            int i, j, k, cont = 1, s;
            string sho="";
            s = n - 1;
            while (s != 0)
            {
                sho += " ";
                s--;
            }
            sho += cont;
            sho += Environment.NewLine;
            s = n - 2;
            for (i = 1; i < n; i++)
            {
                cont = 1;
                for (k = 1; k <= s; k++)
                {
                    sho += " ";
                }
                for (j = 0; j <= i * 2; j++)
                {
                    if (j < i)
                    {
                        sho += cont;
                        cont++;
                    }
                    else
                    {
                        sho += cont;
                        cont--;
                    }
                }
                sho += Environment.NewLine;
                s--;
            }

            sho += Environment.NewLine;
            sho += Environment.NewLine;
            sho += Environment.NewLine;

            for (i = n - 1; i >= 1; i--)
            {
                cont = 1;
                for (k = 1; k <= s; k++)
                {
                    sho += " ";
                }
                for (j = 0; j <= i * 2; j++)
                {
                    if (j < i)
                    {
                        sho += cont;
                        cont++;
                    }
                    else
                    {
                        sho += cont;
                        cont--;
                    }
                }
                sho += Environment.NewLine;
                s--;
            }
            s = n - 9;
            while (s != 0)
            {
                sho += " ";
                s--;
            }
            sho += 1;

            textBox3.Text = sho;
        }
    }
}

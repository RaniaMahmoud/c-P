using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string str = string.Empty;
            int n = 4;
            int[,] a = new int[n, n];
            int c1 = 0;
            int c2 = n;
            int i = 0;
            int j = 0;
            int k = 0;
            int l = 0;
            while (i < n * n)
            {
                for (i = c1; i <= c2; i++)
                {
                    a[c1, i] = i;
                }
                for (j = c1; j <= c2; j++)
                {
                    a[j, c2] = j;
                }
                for (k = c1; k < c2; k++)
                {

                }
                for (l = c1; l < c2; l++)
                {

                }
                c1++;
                c2--;
            }
        }
    }
}

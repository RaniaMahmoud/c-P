using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 5;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            label1.Text = s[0].ToString();
            label3.Text = s[1].ToString();
            label6.Text = s[2].ToString();
            label7.Text = s[3].ToString();
            label5.Text = s[4].ToString();

        }
    }
}

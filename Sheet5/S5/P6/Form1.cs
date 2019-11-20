using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(textBox1.Text) - int.Parse(textBox2.Text)).ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(textBox1.Text) * int.Parse(textBox2.Text)).ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(textBox1.Text) / int.Parse(textBox2.Text)).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "0";
        }
    }
}

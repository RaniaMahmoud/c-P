﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = ((int.Parse(textBox3.Text) + 7) % 10).ToString();
            label7.Text = ((int.Parse(textBox4.Text) + 7) % 10).ToString();
            label8.Text = ((int.Parse(textBox1.Text) + 7) % 10).ToString();
            label9.Text = ((int.Parse(textBox2.Text) + 7) % 10).ToString();
        }
    }
}

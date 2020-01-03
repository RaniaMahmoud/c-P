using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            op.Filter = "txt files (*.txt)|*.txt";
            op.Multiselect = true;
            textBox1.Text = System.IO.File.ReadAllText(op.FileName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog op = new SaveFileDialog();
            op.ShowDialog();
            op.Filter = "txt files (*.txt)|*.txt";
            System.IO.File.WriteAllText(op.FileName, textBox1.Text);
        }
    }
}

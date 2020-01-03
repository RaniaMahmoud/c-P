using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pic
{
    public partial class Form1 : Form
    {
        int c = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Multiselect = true;
            if (op.ShowDialog() == DialogResult.OK)
            {
                foreach (var item in op.FileNames)
                    listBox1.Items.Add(item);
            }

            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(listBox1.SelectedItem.ToString());
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(listBox1.Items[trackBar1.Value].ToString());
            label1.Text = Path.GetFileName(listBox1.Items[trackBar1.Value].ToString());

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                timer2.Interval = 5000;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            pictureBox1.ImageLocation = listBox1.Items[c++].ToString();
            label1.Text = Path.GetFileName(listBox1.Items[c++].ToString());
            if (c >= listBox1.Items.Count)
            {
                c = 0;
            }
        }
    }
}

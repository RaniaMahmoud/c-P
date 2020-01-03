using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ffff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!radioButton1.Checked)
            {
                pictureBox1.Image = Image.FromFile(listBox1.Items[listBox1.SelectedIndex] + "");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                listBox1.Items.AddRange(openFileDialog1.FileNames);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                timer1.Interval = 1000;
                this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
                timer1.Start();
            }
        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(listBox1.Items[count % listBox1.Items.Count] + "");

            string picPath = listBox1.Items[count % listBox1.Items.Count] + "";
            string[] p = picPath.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);

            label1.Text = p[p.Length - 1];
            count++;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) Application.Exit();
        }
    }
}
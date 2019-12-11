using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string b=Microsoft.VisualBasic.Interaction.InputBox("New document name", "New document", "Document 1");
            if (b != null)
            {
                MessageBox.Show("ok");
            }
            else
                MessageBox.Show("Error");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}

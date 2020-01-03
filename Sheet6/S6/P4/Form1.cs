using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace P4
{
    public partial class Form1 : Form
    {
        string text;
        public string Res
        {
            get
            {
                return Res;
            }
            private set
            {
                Res = value;
            }
        }
        public Form1(string t, string l, string te)
        {
            this.Text = t;
            this.lblInput.Text = l;
            this.txtInput.Text = te;
                InitializeComponent();
        }

        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

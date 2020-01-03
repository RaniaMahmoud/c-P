using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2
{
    public partial class Form1 : Form
    {
        Timer t = new Timer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            string s = "";
            if (hh < 10)
            {
                s += "0" + hh;
            }
            else
                s += hh;
            s += ":";
            if (mm < 10)
            {
                s += "0" + mm;
            }
            else
                s += mm;
            s += ":";
            if (ss < 10)
            {
                s += "0" + ss;
            }
            else
                s += ss;
            label2.Text = s;
        }
    }
}

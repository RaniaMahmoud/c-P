using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }

    public class MyTime
    {
        int hh;
        int mm;
        int sec;
        
        public MyTime()
        {
            hh = 0;
            mm = 0;
            sec = 0;
        }

          
    }
}

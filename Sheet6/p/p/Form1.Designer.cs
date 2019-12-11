using System;
using System.Windows.Forms;
using System.Drawing;
namespace p
{
    partial class Form1
    {
        private void InitializeComponent()
        {
            Button b = new Button();
            b.Location = new Point(100, 100);
            b.Size = new Size(50, 50);
            b.Text = "Click";
            b.Click += new EventHandler(b_Click);
            Controls.Add(b);
        }
    }
}
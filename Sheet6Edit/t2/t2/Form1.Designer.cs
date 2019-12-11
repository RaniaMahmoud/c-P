using System;
using System.Drawing;
using System.Windows.Forms;
namespace t2
{
    partial class Form1
    {
        TextBox tex1;
        Button but1;
        Label lb1;
        private void InitializeComponent()
        {
            
            Size = new Size(300, 300);
            Name = "Form1";
            Text = "Add";

            //textBox
            tex1 = new TextBox();
            tex1.Size = new Size(100, 50);
            tex1.Location=new Point(75, 50);
            tex1.Name = "t1";
            tex1.Multiline = true;
            tex1.ScrollBars = ScrollBars.Both;
            tex1.TextChanged += new EventHandler(tex1_TextChanged);
             
            //button
            but1 = new Button();
            but1.Size = new Size(60, 30);
            but1.Location = new Point(100, 100);
            but1.Name = "b1";
            but1.Text = "Click";
            but1.Click += new EventHandler(but1_Click);

            //lable
            lb1 = new Label();
            lb1.Size = new Size(10, 100);
            lb1.Name = "l1";
            lb1.Text = "0";
            lb1.Location = new Point(120, 200);


            Controls.Add(tex1);
            Controls.Add(but1);
            Controls.Add(lb1);

        }
      
    }
}


using System;
using System.Drawing;
using System.Windows.Forms;

namespace P1
{
    partial class Form1
    {
        TrackBar t1;
        TrackBar t2;
        Label l1, l2, l3;
        Button b1, b2, b3;
        Timer tim1;
        ProgressBar p1;
        ImageList im1;
        CheckBox c1, c2, c3;
        TextBox tb1;
        OpenFileDialog op1;
        SaveFileDialog sf1;
        OpenFileDialog pf1;
        PictureBox ph1;
        int k = 1;
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.TrackBar();
            this.t2 = new System.Windows.Forms.TrackBar();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.tim1 = new System.Windows.Forms.Timer(this.components);
            this.p1 = new System.Windows.Forms.ProgressBar();
            this.im1 = new System.Windows.Forms.ImageList(this.components);
            this.c1 = new System.Windows.Forms.CheckBox();
            this.c2 = new System.Windows.Forms.CheckBox();
            this.c3 = new System.Windows.Forms.CheckBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.op1 = new System.Windows.Forms.OpenFileDialog();
            this.sf1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ph1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.t1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ph1)).BeginInit();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.Location = new System.Drawing.Point(104, 150);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(50, 20);
            this.l1.TabIndex = 0;
            // 
            // l2
            // 
            this.l2.Location = new System.Drawing.Point(10, 10);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(50, 20);
            this.l2.TabIndex = 0;
            // 
            // l3
            // 
            this.l3.Location = new System.Drawing.Point(10, 80);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(50, 20);
            this.l3.TabIndex = 0;
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(104, 100);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(100, 56);
            this.t1.TabIndex = 1;
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(104, 50);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(100, 56);
            this.t2.TabIndex = 2;
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.Black;
            this.b1.Location = new System.Drawing.Point(40, 0);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(40, 23);
            this.b1.TabIndex = 0;
            this.b1.UseVisualStyleBackColor = false;
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(10, 10);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(50, 30);
            this.b2.TabIndex = 14;
            this.b2.Text = "open";
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(50, 50);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(50, 30);
            this.b3.TabIndex = 15;
            this.b3.Text = "Save";
            // 
            // tim1
            // 
            //this.tim1.Interval = 500;
            this.tim1.Tick += new System.EventHandler(this.tim1_Tick_1);
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(104, 100);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(100, 30);
            this.p1.TabIndex = 6;
            // 
            // im1
            // 
            this.im1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("im1.ImageStream")));
            this.im1.TransparentColor = System.Drawing.Color.Transparent;
            this.im1.Images.SetKeyName(0, "500_F_107662666_zMxONsgMZY1rm8eshfCGMsSfmRPbMuTB.jpg");
            this.im1.Images.SetKeyName(1, "800px_COLOURBOX4188984.jpg");
            this.im1.Images.SetKeyName(2, "800px_COLOURBOX17944853.jpg");
            this.im1.Images.SetKeyName(3, "800px_COLOURBOX18756101.jpg");
            // 
            // c1
            // 
            this.c1.ImageIndex = 0;
            this.c1.ImageList = this.im1;
            this.c1.Location = new System.Drawing.Point(104, 100);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(20, 20);
            this.c1.TabIndex = 7;
            // 
            // c2
            // 
            this.c2.ImageIndex = 1;
            this.c2.ImageList = this.im1;
            this.c2.Location = new System.Drawing.Point(104, 150);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(20, 20);
            this.c2.TabIndex = 8;
            // 
            // c3
            // 
            this.c3.ImageIndex = 2;
            this.c3.ImageList = this.im1;
            this.c3.Location = new System.Drawing.Point(104, 200);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(20, 20);
            this.c3.TabIndex = 9;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(104, 100);
            this.tb1.Multiline = true;
            this.tb1.Name = "tb1";
            this.tb1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb1.Size = new System.Drawing.Size(100, 100);
            this.tb1.TabIndex = 10;
            // 
            // op1
            // 
            this.op1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            // 
            // sf1
            // 
            this.sf1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ph1
            // 
            this.ph1.Location = new System.Drawing.Point(128, 10);
            this.ph1.Name = "ph1";
            this.ph1.Size = new System.Drawing.Size(200, 100);
            this.ph1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ph1.TabIndex = 1;
            this.ph1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(2, 10);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 148);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(214, 146);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(214, 182);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(98, 21);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(396, 157);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 21);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(396, 195);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 21);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(281, 274);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(17, 309);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 84);
            this.listBox2.TabIndex = 12;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(28, 421);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(167, 309);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "00:00:00";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(573, 551);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ph1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ph1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private System.ComponentModel.IContainer components;
        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button3;
        private ListBox listBox2;
        private Button button4;
        private ComboBox comboBox1;
        private Label label2;
    }
}


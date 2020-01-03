using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1
{
    public partial class Form1 : Form
    {
        static int x, y, z;
        public Form1()
        {
            InitializeComponent();
            List<phone> p = new List<phone>
            {
                new phone {id=0,name="asd",year=1999 },
                new phone {id=1,name="gfd",year=200 },
                new phone {id=2,name="sad",year=54446 }
            };
            listBox2.DataSource = p;
            listBox2.DisplayMember = "name";
            listBox2.ValueMember = "id";
            DateTime d = new DateTime();
             x = d.Hour;
             y = d.Minute;
             z = d.Second;

        }
        private void ClickEvent(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            //pf1 = new OpenFileDialog();
            //Initof();
            
            tim1.Interval = 1000;
            tim1.Start();
        }

        private void Initof()
        {
            pf1.Multiselect = true;
            pf1.Title = "pf";
        }

        private void t1_Scroll(object sender, System.EventArgs e)
        {
            l1.Text = (t1.Value + t2.Value).ToString();
        }
        private void t2_Scroll(object sender, EventArgs e)
        {
            l1.Text = (t1.Value + t2.Value).ToString();

        }

        private void Tim1_Tick(object sender, EventArgs e)
        {
            //if (b1.Left == Width - b1.Width - 10)
            //    k = -1;
            //else if (b1.Left == 0)
            //    k = 1;

            //b1.Left += 10 * k;

            p1.PerformStep();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (tim1.Enabled)
                tim1.Stop();
            else
                tim1.Start();
        }

        private void b2_Click(object sender,EventArgs e)
        {
            if (op1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = op1.FileName;
            string filetext = System.IO.File.ReadAllText(filename);
            tb1.Text = filetext;
            MessageBox.Show("File Open");
        }

        private void b3_Click(object sender,EventArgs e)
        {
            if (sf1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = sf1.FileName;
            System.IO.File.WriteAllText(filename, tb1.Text);
            MessageBox.Show("Save Open");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d = pf1.ShowDialog();
            if(d==DialogResult.OK)
                foreach(string fn in pf1.FileNames)
                {
                    listBox1.Items.Add(fn);
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ph1.Image = Image.FromFile(listBox1.SelectedItem.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //textBox1.AppendText("sad");
            //string[] l = textBox1.Lines;
            //string s = "";
            //for(int i = 0; i < l.Length; i++)
            //{
            //    s += l[i]+ Environment.NewLine;

            //}
            //MessageBox.Show(s);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { e.Handled = true; }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("ghg");
            }
            else
                label1.Text = "k";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("ghg");
            }
            else
                label1.Text = "k";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int i = (int)listBox2.SelectedValue;
            //phone pe = (phone)listBox2.SelectedItem;
            //MessageBox.Show(i.ToString() + "." + pe.name);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] s = { "dsf", "dfs" };
            comboBox1.Items.AddRange(new string[] { "1", "2" });
            comboBox1.Items[1]="sda";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            string[] s = { "dsf", "dfs" };
            listBox2.Items.AddRange(new string[] { "1", "2" });
            listBox2.SetSelected(0, true);
            listBox2.Items[0] = comboBox1.SelectedItem;
        }

        private void tim1_Tick_1(object sender, EventArgs e)
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
                s += "0" + hh;
            }
            else
                s += hh;
            s += ":";
            if (ss < 10)
            {
                s += "0" + hh;
            }
            else
                s += hh;
            label2.Text = s;
        }
    }
    class phone
    {
        public int id { set; get; }
        public string name { set; get; }
        public int year { set; get; }
    }
}

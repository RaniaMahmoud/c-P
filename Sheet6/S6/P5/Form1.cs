using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] s1;
            string[] s2;
            double r = 0.0;
            s1 = textBox1.Lines[0].Split(new char[] {'/'}, StringSplitOptions.RemoveEmptyEntries);
            Fraction f1 = new Fraction(int.Parse(s1[0]), int.Parse(s1[1]));
            s2 = textBox1.Lines[2].Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            Fraction f2 = new Fraction(int.Parse(s2[0]), int.Parse(s2[1]));
            if (textBox1.Lines[1] == "+")
                f1.add(f2, out r);
            else if(textBox1.Lines[1] == "-")
                f1.sub(f2, out r);
            else if(textBox1.Lines[1] == "/")
                f1.Div(f2, out r);
            else if(textBox1.Lines[1] == "*")
                f1.Mult(f2, out r);
            else
                MessageBox.Show("Error!!");

            MessageBox.Show(r.ToString());
        }
    }

    public class Fraction
    {
        private int nom;
        private int dnom;
        public Fraction(int nom, int dnom)
        {
            this.nom = nom;
            this.dnom = dnom;
        }
        public void setNom(int nom)
        {
            this.nom = nom;
        }
        public void setDnom(int dnom)
        {
            this.dnom = dnom;
        }

        public void add( Fraction f2, out double r)
        {
            r = ((double)((nom*f2.dnom)+ (f2.nom * dnom)))/(dnom*f2.dnom);
        }
        public void sub(Fraction f2, out double r)
        {
            r = ((double)((nom * f2.dnom) - (f2.nom * dnom))) / (dnom * f2.dnom);

        }
        public void Div(Fraction f2, out double r)
        {
            r = ((double)(nom * f2.dnom)) / (dnom * f2.nom);
        }
        public void Mult(Fraction f2, out double r)
        {
            r = ((double)(nom * f2.nom)) / (dnom * f2.dnom);

        }
    }
}

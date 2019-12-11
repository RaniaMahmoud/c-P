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
        public Form1()
        {
            InitializeComponent();
            string[] countries = {"+","/","-","*","--","++"};
            listBox1.Items.AddRange(countries);
            listBox1.SetSelected(0, true);
            comboBox1.Items.AddRange(new string[] { "div", "sub", "mult", "sum" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] s1;
            string[] s2;
            string[] s3;
            double r = 0.0;
            Fraction newFr;

            s1 = textBox1.Lines[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Fraction f1 = new Fraction(int.Parse(s1[0]), 1);

            s2 = s1[1].Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            Fraction f2 = new Fraction(int.Parse(s2[0]), int.Parse(s2[1]));

            f1.CalcWhole(f2, out newFr);

            s3 = textBox1.Lines[1].Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            Fraction f3 = new Fraction(int.Parse(s3[0]), int.Parse(s3[1]));
            string selectItem = listBox1.SelectedItem.ToString();
            if (selectItem == "+")
                r = newFr + f3;
            else if (selectItem == "-")
                r = newFr - f3;
            else if (selectItem == "/")
                r = newFr / f3;
            else if (selectItem == "*")
                r = newFr * f3;
            else
                MessageBox.Show("Error!!");

            string s = f1.ToString1() + " ";
            s+= f2.ToString() + "   "+ Environment.NewLine;
            s += f3.ToString() + Environment.NewLine;
            MessageBox.Show(s);
            MessageBox.Show(r.ToString());
        }
    }

    public class Fraction
    {
        private long nom;
        private long dnom;
        public Fraction()
        {
            nom = 0;
            dnom = 1;
        }

        public Fraction(long nom, long dnom)
        {
            this.nom = nom;
            this.dnom = dnom;
        }

        //public void setNom(int nom)
        //{
        //    this.nom = nom;
        //}
        //public void setDnom(int dnom)
        //{
        //    this.dnom = dnom;
        //}

        public void CalcWhole(Fraction f2, out Fraction newFr)
        {
            newFr = new Fraction();
            newFr.nom = (nom * f2.dnom) + (f2.nom * dnom);
            newFr.dnom = (dnom * f2.dnom);
        }
        public static double operator + (Fraction f2, Fraction f1)
        {
            double r = ((double)((f1.nom * f2.dnom) + (f2.nom * f1.dnom))) / (f1.dnom * f2.dnom);
            return r;
        }
        public static double operator -(Fraction f2, Fraction f1)
        {
            double r = ((double)((f1.nom * f2.dnom) - (f2.nom * f1.dnom))) / (f1.dnom * f2.dnom);
            return r;
        }
        public static double operator /(Fraction f2, Fraction f1)
        {
            double r = ((double)(f1.nom * f2.dnom)) / (f1.dnom * f2.nom);
            return r;
        }
        public static double operator *(Fraction f2, Fraction f1)
        {
            double r = ((double)(f1.nom * f2.nom)) / (f1.dnom * f2.dnom);
            return r;
        }
        public override string ToString()
        {
            return nom + "/" + dnom;
        }
        public string ToString1()
        {
            string s = string.Format(nom+" ");
            return s;
        }
    }
}

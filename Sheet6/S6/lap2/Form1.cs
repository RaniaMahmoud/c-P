using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lap2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y, z;
            Frection f1, f2, f3, f5, f6, f7,f11,f22,f111,f222,f1111,f2222,fd;

            string []s1 = (textBox1.Text).Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            string[] s2 = (textBox2.Text).Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            string[] s3 = (textBox3.Text).Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            f1 = new Frection(int.Parse(s1[0]), int.Parse(s1[1]));
            f2 = new Frection(int.Parse(s2[0]), int.Parse(s2[1]));
            f11 = new Frection(int.Parse(s1[0]), int.Parse(s1[1]));
            f22 = new Frection(int.Parse(s2[0]), int.Parse(s2[1]));
            f111 = new Frection(int.Parse(s1[0]), int.Parse(s1[1]));
            f222 = new Frection(int.Parse(s2[0]), int.Parse(s2[1]));
            f1111 = new Frection(int.Parse(s1[0]), int.Parse(s1[1]));
            f2222 = new Frection(int.Parse(s2[0]), int.Parse(s2[1]));
            fd = int.Parse(s3[0]);
            f1 = f1 + f2;
            textBox4.Text = ((f1.num).ToString()) + "/" + ((f1.dom).ToString());
            f3 = f11 - f22;
            textBox5.Text = ((f3.num).ToString()) + "/" + ((f3.dom).ToString());
            f7 = f111 * f222;
            textBox6.Text = ((f7.num).ToString()) + "/" + ((f7.dom).ToString());
            f5 = f1111 / f2222;
            textBox7.Text = ((f5.num).ToString()) + "/" + ((f5.dom).ToString());
            textBox8.Text = ((fd.num).ToString()) + "/" + ((fd.dom).ToString());
            double q = (double)fd;
            textBox9.Text = (q.ToString());
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
    class Frection
    {
        public int num;
        public int dom;
        public Frection(int n,int d=1)
        {
            num = n;
            dom = d;
        }
        public Frection( int d = 1)
        {
            dom = d;
        }


        public static Frection operator +(Frection f1, Frection f2)
        {
            Frection r = new Frection((f1.num * f2.dom) + (f1.dom * f2.num), (f1.dom * f2.dom));
            int x = gcd(r.num, r.dom);
            return new Frection(r.num / x, r.dom / x);
        }
        public static Frection operator -(Frection f1, Frection f2)
        {
            Frection r = new Frection(((f1.num * f2.dom) - (f1.dom * f2.num)), (f1.dom * f2.dom));
            int x = gcd(r.num, r.dom);
            MessageBox.Show(x.ToString());
            return new Frection(r.num / x, r.dom / x);
        }
        public static Frection operator *(Frection f1, Frection f2)
        {
            Frection r = new Frection((f1.num * f2.num), (f1.dom * f2.dom));
            int x = gcd(r.num, r.dom);
            return new Frection(r.num / x, r.dom / x);
        }
        public static Frection operator /(Frection f1, Frection f2)
        {
            Frection r = new Frection((f1.num * f2.dom), (f1.dom * f2.num));
            int c = gcd(r.num, r.dom);
            return new Frection(r.num/c, r.dom/c);
        }
        public static explicit operator double(Frection f1)
        {
            double x = (double)f1.num;
            return (x / f1.dom);
        }
        public static int gcd(int n1,int n2)
        {
            int min, i;
            n1 = Math.Abs(n1);
            n2 = Math.Abs(n2);
            if (n1 < n2)
            {
                 min = n1;
            }
            else
                min = n2;
            for( i = min; i >= 1; i--)
            {
                if (n1 % i == 0 && n2 % i == 0)
                {
                    break;
                }
            }
            return i;
        }

        public static implicit operator Frection(int x)
        {
            return new Frection(x, 1);
        }
    }
}

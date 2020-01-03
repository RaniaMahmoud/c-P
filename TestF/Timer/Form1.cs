using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timerd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Timer timer1;
            InitializeComponent();
            timer1 = new Timer();
            this.timer1.Enabled = true;
            timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            timer1.Start();

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
        private void label1_Click(object sender, EventArgs e)
        {

             //h = int.Parse(textBox1.Lines[0]);
             //m = int.Parse(textBox1.Lines[1]);
             //sec = int.Parse(textBox1.Lines[2]);

            //MyTime time = new MyTime(h, m, sec);

            //string s = "";
            //if (time.getH() < 10)
            //{
            //    s += "0" + time.getH();
            //}
            //else
            //    s += time.getH();
            //s += ":";
            //if (time.getM() < 10)
            //{
            //    s += "0" + time.getM();
            //}
            //else
            //    s += time.getM();
            //s += ":";
            //if (time.getS() < 10)
            //{
            //    s += "0" + time.getS();
            //}
            //else
            //    s += time.getS();

            //label1.Text = s;

        //label1.Text = (time.getH()).ToString() + ":" + (time.getM()).ToString() + ":" + (time.getS()).ToString();
    }
        MyTime t = new MyTime();

        private void timer1_Tick(object sender, EventArgs e)
        {
            t = t++;
            label1.Text = t.Display();

        }
    }

    //public class MyTime
    //{
    //    int hh;
    //    int mm;
    //    int sec;
    //    public readonly int total;
    //    public int getH()
    //    {

    //        return hh;
    //    }
    //    public int getM()
    //    {
    //        return mm;

    //    }
    //    public int getS()
    //    {
    //        return sec;

    //    }
    //    public MyTime(int h, int m, int s)
    //    {
    //        total = (h * 3600) + (m * 60) + s;
    //        total %= 86400;
    //        int t = total;
    //        hh = t / 3600;
    //        t %= 3600;
    //        mm = t / 60;
    //        t %= 60;
    //        sec = t;
    //    }
    //    public static implicit operator MyTime(int x)
    //    {
    //        x = x % 86400;
    //        int h = x / 3600;
    //        x %= 3600;
    //        int m = x / 60;
    //        x %= 60;
    //        int s = x;
    //        return new MyTime(h, m, s);
    //    }
    //    public static bool operator !=(MyTime t1, MyTime t2)
    //    {
    //        return t1.total != t2.total;
    //    }
    //    public static bool operator ==(MyTime t1, MyTime t2)
    //    {
    //        return t1.total == t2.total;
    //    }
    //    public static bool operator >(MyTime t1, MyTime t2)
    //    {
    //        return t1.total > t2.total;
    //    }
    //    public static bool operator <(MyTime t1, MyTime t2)
    //    {
    //        return t1.total < t2.total;
    //    }
    //    public static MyTime operator ++(MyTime a)
    //    {
    //        a.sec++;
    //        return new MyTime(a.hh, a.mm, a.sec);

    //    }
    //}

    class MyTime
    {
        private int hour;
        private int minuit;
        private int second;
        readonly int totalSecond;
        public MyTime()
        {
            hour = 0;
            second = 0;
            minuit = 0;

        }
        private MyTime(int hour, int minuit, int second)
        {
            this.hour = hour;
            this.minuit = minuit;
            this.minuit = second;
        }
        public string Display()
        {
            if (hour == 23 && second == 59 && minuit == 59)
            {
                hour = 0;
                minuit = 0;
                second = 0;
            }
            calcSecod();
            return hour + " : " + minuit + " : " + second;
        }
        public static bool operator <(MyTime t, MyTime t2) { return t.calcSecod() < t2.calcSecod(); }
        public static bool operator >(MyTime t, MyTime t2) { return t.calcSecod() < t2.calcSecod(); }
        public static bool operator ==(MyTime t, MyTime t2) { return t.calcSecod() == t2.calcSecod(); }
        public static bool operator !=(MyTime t, MyTime t2) { return t.calcSecod() != t2.calcSecod(); }
        public static MyTime operator ++(MyTime t)
        {
            t.second++;
            if (t.second == 60)
            {
                t.minuit++;
                t.second = 0;
            }
            if (t.minuit == 60)
            {
                t.minuit = 0;
                t.hour++;
            }
            return new MyTime(t.hour, t.minuit, t.second);

        }
        public static MyTime operator --(MyTime t)
        {
            t.second--;
            if (t.second == -1)
            {
                t.minuit--;
                t.second = 59;
            }
            if (t.minuit == -1)
            {
                t.minuit = 59;
                t.hour--;
            }
            return new MyTime(t.hour, t.minuit, t.second);
        }

        public static explicit operator MyTime(int t)
        {
            int hour = t % 3600;
            t = t / 3600;
            int minuit = t % 60;
            t = t / 60;
            int second = t;
            return new MyTime(hour, minuit, second);
        }

        private int calcSecod()
        {
            return hour * 3600 + minuit * 60 + second;
        }
    }
}
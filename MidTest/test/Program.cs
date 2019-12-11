using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
namespace test { 
    enum emp :byte
    {
        ma,
        gr,
        co
    }
    struct point
    {
        public int x;
        public int y;
        public point(int xj,int yj)
        {
            x = xj;
            y = yj;
        }
        public void inc()
        {
            x++;
            y++;
        }
        public void dis()
        {
            WriteLine(x + "  " + y);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            //emp e = emp.ma;
            //ty(e);
            //        Ev(e);
            // WriteLine(e.ToString()+" "+(byte)e);
            //point p = new point(1,3);

            //p.dis();
            //p.inc();
            //p.dis();

            //person p = new person("eee", 4);
            //p.dis();
            //sendp(ref p);
            //p.dis();

            //freq f = new freq();
            //f.run();

            //int[][] array = new int[10][];
            //WriteLine("ragged_2d_array has rank: " + array.Rank);
            //WriteLine("ragged_2d_array has type: " + array.GetType());
            //WriteLine("Total number of elements: " + array.GetLength(0));
            //WriteLine();

            //for (int i=0; i < array.GetLength(0); i++)
            //{
            //    array[i] = new int[i + 1];
            //}
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array[i].GetLength(0); j++)
            //        array[i][j] = 3;
            //}
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    string As = string.Join(" ", array[i]);
            //    WriteLine(As);
            //}
            // int i, j, k, a = 1, n = 9, s;
            //string sho = "";
            //s = n - 1;
            //while (s != 0)
            //{
            //    sho += " ";
            //    s--;
            //}
            //sho += a;
            //sho += Environment.NewLine;
            //s = n - 2;
            //for (i = 1; i < n; i++)
            //{
            //    a = 1;
            //    for (k = 1; k <= s; k++)
            //    {
            //        sho += " ";
            //    }
            //    for (j = 0; j <= i * 2; j++)
            //    {
            //        if (j < i)
            //        {
            //            sho += a;
            //            a++;
            //        }
            //        else
            //        {
            //            sho += a;
            //            a--;
            //        }
            //    }
            //    sho += Environment.NewLine;
            //    s--;
            //}

            //for (i = n; i >= 1; i--)
            //{
            //    s = n - i;
            //    while (s != 0)
            //    {
            //        sho += " ";
            //        s--;
            //    }
            //    for (j = 1; j < i * 2; j++)
            //    {
            //        sho += "*";
            //    }
            //    sho += "\n";
            //}

            //WriteLine(sho);

            //string reslt = "";
            //int[] inta1 = new int[4];
            //int[] inta2 = new int[3];
            //string []a1 = { "1", "2", "3", "4" };
            //string[] a2 = { "1", "2", "3" };
            //for (int i = 0; i < a1.Length; i++)
            //{
            //    inta1[i] = int.Parse(a1[i]);
            //}
            //for (int i = 0; i < a2.Length; i++)
            //{
            //    inta2[i] = int.Parse(a2[i]);
            //}

            //if (a1.Length >= a2.Length)
            //{

            //    for (int i = 0; i < inta2.Length; i++)
            //    {
            //        inta1[i] = inta1[i] + inta2[i];
            //    }

            //}
            //else
            //{

            //    for (int i = 0; i < inta1.Length; i++)
            //    {
            //        inta2[i] = inta1[i] + inta2[i];
            //    }
            //}
            //if (a1.Length >= a2.Length)
            //{
            //    reslt = inta1[0].ToString();
            //    for (int i = 1; i < a1.Length; i++)
            //    {
            //        reslt += $"+{inta1[i]}X^{i}";
            //    }
            //}
            //else
            //{
            //    reslt = inta2[0].ToString();
            //    for (int i = 1; i < a2.Length; i++)
            //    {
            //        reslt += $"+{inta2[i]}X^{i}";
            //    }
            //}
            //WriteLine(reslt);


            //string[] s1;
            string[] s2;
            double r = 0.0;
            string s = "1/8";
            string[] s1 = s.Split(new char[] {'/'}, StringSplitOptions.RemoveEmptyEntries);
            //Fraction f1 = new Fraction(int.Parse(s1[0]), int.Parse(s1[1]));
            //s2 = textBox1.Lines[2].Split(new char['/'], StringSplitOptions.RemoveEmptyEntries);
            //Fraction f2 = new Fraction(int.Parse(s2[0]), int.Parse(s2[1]));
            //if (textBox1.Lines[1] == "+")
            //{
            //    f1.add(f2, out r);
            //}
            WriteLine(s1[0]);

            ReadKey();
        }

        static void sendp(ref person p)
        {
            p.age = 9;
            p = new person("sa", 87);
        }
        static void Ev(Enum e)
        {
            WriteLine(e.GetType().Name);
            WriteLine(Enum.GetUnderlyingType(e.GetType()));
            Array n = Enum.GetValues(e.GetType());
            WriteLine(n.Length);
            for(int i=0; i< n.Length; i++)
            {
                WriteLine(n.GetValue(i));
            }
        }

        //static void js()
        //{

        //}
        //static void js(int y)
        //{

        //}
        //static int js(double k)
        //{
        //    return 4;
        //}
        //static double js(float k)
        //{
        //    return 4;
        //}

        static void ty(emp e)
        {
            switch (e)
            {
                case emp.ma:
                    WriteLine("dfd");
                    break;
                case emp.co:
                    WriteLine("rt");
                    break;
                case emp.gr:
                    WriteLine("kl");
                    break;
            }
        }
        static void name(int tc,int bg,string mess)
        {

        }
        static void da(int n,string s = "sss",int y = 7)
        {
            WriteLine(n + "\n" + s);
        }
        static double av(params int[] n)
        {
            int s = 0;
            if (n.Length == 0)
            {
                return 0;
            }
            for (int i = 0; i < n.Length; i++)
            {
                s += n[i];
            }
            return (s / n.Length);
        }
        static void st(int []s)
        {
            for(int i = 0; i < s.Length; i++)
            {
                s[i] = i;
            }
            //return s;
        }
        static void Add(int x, out int y, out int a)
        {
            y = 1;
            a = x + y;
        }
        static void swap(ref int x, ref int y)
        {
            int t = x;
            x = y;
            y = t;
        }
        static void a(int x, int y, out int a)
        {
            a = 5;
            WriteLine("df");
        }
        static void simA()
        {
            int[] a;
            a = new int[3] { 1, 2, 5 };
            a[2] = 5;
            bool[] b = { true, false };
            int[] ad = new int[] { 1, 4, 7 };
            var c = new[] { 1, 4.5 };
            for(int i = 0; i < c.Length; i++)
            {
                Write(c[i]);
            }
            //WriteLine(c.ToString());
        }
        static void aO()
        {
            object[] a;
            a = new object[4] { 1, "dsf", false, new DateTime(1999, 3, 3) };
            for (int i = 0; i < a.Length; i++)
            {
                WriteLine(a[i].GetType());
            }
            //WriteLine(c.ToString());
        }
        static void aM()
        {
            //int[,] a;
            //a = new int[3,4] { { 1,2,3,4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //        Write((a[i, j] = (i * j)) +" ");
            //    WriteLine();
            //}

            int[][] a2 = new int[3][];
            for (int i = 0; i < a2.Length; i++)
            {
                a2[i] = new int[i + 3];
            }
            for (int i = 0; i < a2.Length; i++)
            {
                for (int j = 0; j < a2[i].Length; j++)
                    Write((a2[i][j] = (i * j)) + " ");
                WriteLine();
            }
        }
        static int cha(int num, byte v, byte p)
        {
            int bit =(byte) (num >> p & 1) ^ v;
            return num ^ (bit << v);
        }
        static int exc(int num)
        {
            byte f = (byte)((num >> 3) & 7);
            byte s =(byte)((num >> 24) & 7);
            byte n =(byte) (f ^ s);
            num = (int)(num ^ (n << 3));
            num = (int)(num ^ (n << 24));
            return num;
        }
        static void cha(ref string s)
        {
            s = null;
        }
    }
    class person
    {
        public int age;
        public string name;
        public person()
        {

        }
        public person(string nam,int ag)
        {
            name = nam;
            age = ag;
        }
        public void dis()
        {
            WriteLine(age + "  " + name);
        }
    }

    class freq
    {
        int[] LA = new int[26];
        const  int A = 0, B = 1, C = 2, D = 3, E = 4, F = 5, G = 6,
            H = 7, I = 8, J = 9, K = 10, L = 11, M = 12, N = 13,
            O = 14, P = 15, Q = 16, R = 17, S = 18, T = 19, U = 20,
            V = 21, W = 22, X = 23, Y = 24, Z = 25;

        private string entstr()
        {
            string s = ReadLine().ToUpper();
            return s;
        }
        void conLett(string s)
        {
            if (s != null)
            {
                for (int i=0; i < s.Length; i++)
                {
                    switch (s[i])
                    {
                        case 'A':
                            LA[A]++;
                            break;
                        case 'B':
                            LA[B]++;
                            break;
                        case 'C':
                            LA[C]++;
                            break;
                        case 'D':
                            LA[D]++;
                            break;
                        case 'E':
                            LA[E]++;
                            break;
                        case 'F':
                            LA[F]++;
                            break;
                        case 'G':
                            LA[G]++;
                            break;
                        case 'H':
                            LA[H]++;
                            break;
                        case 'I':
                            LA[I]++;
                            break;
                        case 'J':
                            LA[J]++;
                            break;
                        case 'K':
                            LA[K]++;
                            break;
                        case 'L':
                            LA[L]++;
                            break;
                        case 'M':
                            LA[M]++;
                            break;
                        case 'N':
                            LA[N]++;
                            break;
                        case 'O':
                            LA[O]++;
                            break;
                        case 'P':
                            LA[P]++;
                            break;
                        case 'Q':
                            LA[Q]++;
                            break;
                        case 'R':
                            LA[R]++;
                            break;
                        case 'S':
                            LA[S]++;
                            break;
                        case 'T':
                            LA[T]++;
                            break;
                        case 'U':
                            LA[U]++;
                            break;
                        case 'V':
                            LA[V]++;
                            break;
                        case 'W':
                            LA[W]++;
                            break;
                        case 'X':
                            LA[X]++;
                            break;
                        case 'Y':
                            LA[Y]++;
                            break;
                        case 'Z':
                            LA[Z]++;
                            break;
                        default:
                            break;
                    }
                }
             }
        }
        public void run()
        {
            conLett(entstr());
            for(int i = 0; i < LA.Length; i++)
            {
                Write((char)(i + 65) + ":");
                for (int j = 0; j < LA[i]; j++)
                {
                    Write("*");
                }
                WriteLine();
            }
        }

    }

}

//enum day { sat = 'k', th, wen };
////double d = 18.3;
////int x = (int) d;
////char c = (char)4;
////char c2 = '\t';
////string s2 = "sad";
////WriteLine(s2.Substring(1));
////const int x2 = 54;
////WriteLine(x2);
////WriteLine(c='5');
////string s = string.Format($"asd ss {d}");
////WriteLine(s);
////WriteLine("{0,-5}", 4)
////char c;
////day ds = day.th;
////c = (char)day.th;
////            char x = Convert.ToChar(ReadLine());
////            int z = 5 * 1;
////            string s = z.ToString();
////            WriteLine(x);
////            WriteLine($@"Testing \n 1 2 {5 - 2}	
////New line");
////WriteLine( $"{ 8 == 8} ? Yes : NO");
////int dss = Convert.ToInt32("5");
////var str = @"I don't think so, he said.";
////WriteLine(str);

//string s = "hi";

//            cha(ref s);
//            WriteLine(s);

//int num = 13;
//byte p = 3;
//byte v = 1;
////WriteLine(cha(num, v, p));
////WriteLine(Convert.ToString(num, 2).PadLeft(32,'0'));
////num = exc(num);
////WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
////int n1 = int.Parse(ReadLine());
////int n2 = int.Parse(ReadLine());
////char op = (char)(Read());
////switch (op)
////{
////    case '+':
////        WriteLine(n1 + n2);
////        break;
////    case '-':
////        WriteLine(n1 - n2);
////        break;
////    case '/':
////        WriteLine(n1 / n2);
////        break;
////}

////string[] car = { "df", "dfdf", "fgf" };
////foreach(var c in car)
////{
////    WriteLine(c);
////}
////int[] numb = { 10, 20, 30 };
////var subset = from i in numb where i < 10 select i;
////foreach (var i in subset)
////{
////    WriteLine(i);
////}

//string str1 = "HHHHHH";
////string[] sd= str.Split(new char['/'], StringSplitOptions.RemoveEmptyEntries);
//string str2 = "HHHHHH";
//            //WriteLine(str.Length);
//            WriteLine(String.Concat(str1, str2));
//            WriteLine(str1.Equals(str2));
//            StringBuilder sb = new StringBuilder();
//sb.AppendLine("ds"+"2");

//            Write(sb);
//int x = 4, y = 5, a;
//        WriteLine(Add( x, y));
//Add(x, out y,out a);
// swap(ref x, ref y);
//WriteLine(a);
//WriteLine(x + " " + " " + y);
//int[] s = { 1, 3 };
//string[] d = { "ds1", "ds3" };
//Array.Reverse(d);
//Array.Clear(d, 1, 1);
//for (int i = 0; i < d.Length; i++)
//{
//    WriteLine(d[i]);
//}
//WriteLine(av(2,4,8));
//da(5, "dsd", 7);
// name(2, bg: 5, mess: "sadss");

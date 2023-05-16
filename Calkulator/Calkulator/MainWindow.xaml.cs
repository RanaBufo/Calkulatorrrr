using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace Calkulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        const int n1 = 10, n2 = 6;
        int k1 = 1, point = 0, ch = 1, op = 0, ii = 0, m1 = 1, m2 = 1;
        string s = "0", s3="";
        double x1 = 1, x2 = 1;
        public static readonly string doubleSchoolFormat = "0." + new string('#', 324);


        private void Ln(object sender, RoutedEventArgs e)
        {
            if (ch > n1)
            {
                t1.Text = "0";
                s = "0";
                point = 0; m1 = 1;
                ch = 1;
                op = 0;
                x1 = 1;
                x2 = 1;
                t1.FontSize = 130;
            }
            else
            if (Double.Parse(t1.Text) > 0)
            {
                s3 = "ln(" + t1.Text + ")=";
                x1 = Math.Round(Math.Log(Double.Parse(t1.Text)), 6);
                s = x1.ToString(doubleSchoolFormat);
                t1.Text = s;
                if (s.Contains(','))
                {
                    ii = s.IndexOf(',');
                    ch = s.Substring(0, ii).Length;
                    if (s.Contains("-"))
                    {
                        m1 = -1;
                    }
                    else { m1 = 1; }
                    if (ch <= n1)
                    {
                        point = 1;
                        ch = s.Substring(ii + 1).Length;
                    }
                }
                else
                {
                    ch = s.Length; point = 0; if (s.Contains("-"))
                    {
                        m1 = -1;
                    }
                    else { m1 = 1; }
                }
                s3 += t1.Text;
                if (t2.Text != "")
                {
                    t2.Text = s3 + "\n" + t2.Text;
                }
                else
                {
                    t2.Text = s3;
                }
            }
            else
            {
                t1.Text = "Нельзя вычислить логорифм";
                ch = 2 * n1;
            }
            if (t1.Text.Length + 1 > 9)
            {
                t1.FontSize = 52;
            }
            else t1.FontSize = 130;
            if (t1.Text == "-0")
            {
                x1 = 0;
                s = "0";
                op = 0;
                point = 0;
                ch = 1;
                t1.Text = s;
                ii = 0;
                m1 = 1;
            }

        }

        private void Fuctorial(object sender, RoutedEventArgs e)
        {
            if (ch > n1)
            {
                t1.Text = "0";
                s = "0";
                point = 0;
                ch = 1;
                op = 0;
                x1 = 1; m1 = 1;
                x2 = 1;
                t1.FontSize = 130;
            }
            else if (op == 0)
            {
                s3 = t1.Text + "!=";
                x1 = 1;
                if (Math.Round(Double.Parse(t1.Text)).ToString() == t1.Text) {
                    ii = Convert.ToInt32(t1.Text);
                    for (int i = 1; i <= ii; i++) x1 *= i;
                    s = x1.ToString();
                    t1.Text = s;
                    if (s.Contains(','))
                    {
                        ii = s.IndexOf(',');
                        ch = s.Substring(0, ii).Length;
                        if (s.Contains("-"))
                        {
                            m1 = -1;
                        }
                        else { m1 = 1; }
                        if (ch <= n1)
                        {
                            point = 1;
                            ch = s.Substring(ii + 1).Length;
                        }
                    }
                    else
                    {
                        ch = s.Length; point = 0; if (s.Contains("-"))
                        {
                            m1 = -1;
                        }
                        else { m1 = 1; }
                    }
                    s3 += t1.Text;
                    if (t2.Text != "")
                    {
                        t2.Text = s3 + "\n" + t2.Text;
                    }
                    else
                    {
                        t2.Text = s3;
                    }
                }
                else
                {
                    t1.Text = "Факториал вычислить нельзя";
                    ch = n1 * 2;
                }

            }
            if (t1.Text.Length + 1 > 9)
            {
                t1.FontSize = 52;
            }
            else t1.FontSize = 130;
            if (t1.Text == "-0")
            {
                x1 = 0;
                s = "0";
                op = 0;
                point = 0;
                ch = 1;
                t1.Text = s;
                ii = 0;
                m1 = 1;
            }


        }

        private void COs(object sender, RoutedEventArgs e)
        {
            if (ch > n1)
            {
                t1.Text = "0" + "1";
                s = "0";
                point = 0; m1 = 1;
                ch = 1;
                op = 0;
                x1 = 1;
                x2 = 1;
                t1.FontSize = 130;
            }
            else if (op == 0)
            {
                s3 = "cos(" + t1.Text + ")=";
                if (rad.IsChecked == true)
                {

                    x1 = Math.Round(Math.Cos(Double.Parse(t1.Text)), 6);
                    s = x1.ToString(doubleSchoolFormat);
                    t1.Text = s;
                    if (s.Contains(','))
                    {
                        ii = s.IndexOf(',');
                        ch = s.Substring(0, ii).Length;
                        if (s.Contains("-"))
                        {
                            m1 = -1;
                        }
                        else { m1 = 1; }
                        if (ch <= n1)
                        {
                            point = 1;
                            ch = s.Substring(ii + 1).Length;
                        }
                    }
                    else
                    {
                        ch = s.Length; point = 0; if (s.Contains("-"))
                        {
                            m1 = -1;
                        }
                        else { m1 = 1; }
                    }
                }
                else
                {
                    x1 = Math.Round(Math.Cos((Double.Parse(t1.Text) / 180) * Math.PI), 6);
                    s = x1.ToString(doubleSchoolFormat);
                    t1.Text = s;
                    if (s.Contains(','))
                    {
                        ii = s.IndexOf(',');
                        ch = s.Substring(0, ii).Length;
                        if (s.Contains("-"))
                        {
                            m1 = -1;
                        }
                        else { m1 = 1; }
                        if (ch <= n1)
                        {
                            point = 1;
                            ch = s.Substring(ii + 1).Length;
                        }
                    }
                    else
                    {
                        ch = s.Length; point = 0; if (s.Contains("-"))
                        {
                            m1 = -1;
                        }
                        else { m1 = 1; }
                    }
                }
                s3 += t1.Text;
                if (t2.Text != "")
                {
                    t2.Text = s3 + "\n" + t2.Text;
                }
                else
                {
                    t2.Text = s3;
                }
            }
            if (t1.Text.Length + 1 > 9)
            {
                t1.FontSize = 52;
            }
            else t1.FontSize = 130;
            if (t1.Text == "-0")
            {
                x1 = 0;
                s = "0";
                op = 0;
                point = 0;
                ch = 1;
                t1.Text = s;
                ii = 0;
                m1 = 1;
            }
        }

        private void TG(object sender, RoutedEventArgs e)
        {
            if (ch > n1)
            {
                t1.Text = "0" + "1";
                s = "0";
                point = 0;
                ch = 1;
                op = 0;
                x1 = 1;
                x2 = 1;
                t1.FontSize = 130;
            }
            else if (op == 0)
            {
                s3 = "tg(" + t1.Text + ")=";
                if (rad.IsChecked == true)
                {
                    if (Double.Parse(t1.Text) % Math.Round((Math.PI / 2), 6) != 0 & Math.Round(Math.Sin(Double.Parse(t1.Text)), 6) != -1 & Math.Round(Math.Sin(Double.Parse(t1.Text)), 6) != 1 & Math.Round(Math.Cos(Double.Parse(t1.Text)), 6) != 0)
                    {
                        //x1 = Math.Round(Math.Tan(Double.Parse(t1.Text)), 6);
                        x1 = Math.Round(Math.Sin(Double.Parse(t1.Text)), 6);
                        s = x1.ToString(doubleSchoolFormat);
                        t1.Text = s;
                        if (s.Contains(','))
                        {
                            ii = s.IndexOf(',');
                            ch = s.Substring(0, ii).Length;
                            if (s.Contains("-"))
                            {
                                m1 = -1;
                            }
                            else { m1 = 1; }
                            if (ch <= n1)
                            {
                                point = 1;
                                ch = s.Substring(ii + 1).Length;
                            }
                        }
                        else { ch = s.Length; point = 0; if (s.Contains("-"))
                            {
                                m1 = -1;
                            }
                            else { m1 = 1; }
                        }
                    }
                    else
                    {
                        s = "Данный тангенс не существет";
                        t1.Text = s;
                        ch = n1 * 2;
                        point = 0;

                    }
                }
                else if (Double.Parse(t1.Text) % 90 != 0)
                {
                    x1 = Math.Round(Math.Tan((Double.Parse(t1.Text) / 180) * Math.PI), 6);
                    s = x1.ToString(doubleSchoolFormat);
                    t1.Text = s;
                    if (s.Contains(','))
                    {
                        ii = s.IndexOf(',');
                        ch = s.Substring(0, ii).Length;
                        if (ch <= n1)
                        {
                            point = 1;
                            ch = s.Substring(ii + 1).Length;
                        }
                    }
                    else { ch = s.Length; point = 0; }
                }
                else
                {
                    s = "Данный тангенс не существет";
                    t1.Text = s;
                    ch = n1 * 2;
                    point = 0;

                }
                s3 += t1.Text;
                if (t2.Text != "")
                {
                    t2.Text = s3 + "\n" + t2.Text;
                }
                else
                {
                    t2.Text = s3;
                }
            }
            if (t1.Text.Length + 1 > 9)
            {
                t1.FontSize = 52;
            }
            else t1.FontSize = 130;
            if (t1.Text == "-0")
            {
                x1 = 0;
                s = "0";
                op = 0;
                point = 0;
                ch = 1;
                t1.Text = s;
                ii = 0;
                m1 = 1;
            }
        }

        private void Bin(object sender, RoutedEventArgs e)
        {
            if (ch > n1)
            {
                t1.Text = "0" + "1";
                s = "0";
                point = 0;
                ch = 1; m1 = 1;
                op = 0;
                x1 = 1;
                x2 = 1;
                t1.FontSize = 130;
            }
            else if (op == 0 & ch != 0)
            {
                s3 = "bin(" + t1.Text + ")=";
                m2 = 0;
                if (s.Contains(","))
                {
                    m2 = s.IndexOf(",");
                    ii = int.Parse(s.Substring(0, m2));
                    string s2;
                    x1 = Double.Parse(s) - ii;
                    s = Convert.ToString(ii, 2) + ",";
                    while (x1 < 1)
                    {
                        x1 *= 2;
                        s += x1.ToString().Substring(0, 1);
                        if (x1.ToString().Contains(","))
                        {
                            s2 = "0" + x1.ToString().Substring(1);
                            x1 = Double.Parse(s2);
                        }

                    }


                }
                else
                {
                    ii = int.Parse(t1.Text);
                    s = Convert.ToString(ii, 2);
                }

                t1.Text = s;
                if (s.Contains(','))
                {
                    ii = s.IndexOf(',');
                    ch = s.Substring(0, ii).Length;
                    if (s.Contains("-"))
                    {
                        m1 = -1;
                    }
                    else { m1 = 1; }
                    if (ch <= n1)
                    {
                        point = 1;
                        ch = s.Substring(ii + 1).Length;
                    }
                }
                else
                {
                    ch = s.Length; point = 0; if (s.Contains("-"))
                    {
                        m1 = -1;
                    }
                    else { m1 = 1; }
                }
                s3 += t1.Text;
                if (t2.Text != "")
                {
                    t2.Text = s3 + "\n" + t2.Text;
                }
                else
                {
                    t2.Text = s3;
                }
            }
            if (t1.Text == "-0")
            {
                x1 = 0;
                s = "0";
                op = 0;
                point = 0;
                ch = 1;
                t1.Text = s;
                ii = 0;
                m1 = 1;
            }

        }

        private void Oct(object sender, RoutedEventArgs e)
        {
            if (ch > n1)
            {
                t1.Text = "0" + "1";
                s = "0";
                point = 0;
                ch = 1; m1 = 1;
                op = 0;
                x1 = 1;
                x2 = 1;
                t1.FontSize = 130;
            }
            else if (op == 0 & ch != 0)
            {
                s3 = "oct(" + t1.Text + ")=";
                m2 = 0;
                if (s.Contains(","))
                {
                    m2 = s.IndexOf(",");
                    ii = int.Parse(s.Substring(0, m2));
                    string s2;
                    x1 = Double.Parse(s) - ii;
                    s = Convert.ToString(ii, 8) + ",";
                    while (x1 < 1)
                    {
                        x1 *= 8;
                        s += x1.ToString().Substring(0, 1);
                        if (x1.ToString().Contains(",")) {
                            s2 = "0" + x1.ToString().Substring(1);
                            x1 = Double.Parse(s2);
                        }


                    }


                }
                else
                {
                    ii = int.Parse(t1.Text);
                    s = Convert.ToString(ii, 8);
                }

                t1.Text = s;
                if (s.Contains(','))
                {
                    ii = s.IndexOf(',');
                    ch = s.Substring(0, ii).Length;
                    if (s.Contains("-"))
                    {
                        m1 = -1;
                    }
                    else { m1 = 1; }
                    if (ch <= n1)
                    {
                        point = 1;
                        ch = s.Substring(ii + 1).Length;
                    }
                }
                else
                {
                    ch = s.Length; point = 0; if (s.Contains("-"))
                    {
                        m1 = -1;
                    }
                    else { m1 = 1; }
                }
                s3 += t1.Text;
                if (t2.Text != "")
                {
                    t2.Text = s3 + "\n" + t2.Text;
                }
                else
                {
                    t2.Text = s3;
                }
            }
            if (t1.Text == "-0")
            {
                x1 = 0;
                s = "0";
                op = 0;
                point = 0;
                ch = 1;
                t1.Text = s;
                ii = 0;
                m1 = 1;
            }
        }

        private void Hex(object sender, RoutedEventArgs e)
        {
            if (ch > n1)
            {
                t1.Text = "0" + "1";
                s = "0";
                point = 0;
                ch = 1; m1 = 1;
                op = 0;
                x1 = 1;
                x2 = 1;
                t1.FontSize = 130;
            }
            else if (op == 0 & ch != 0)
            {
                s3 = "hex(" + t1.Text + ")=";
                m2 = 0;
                if (s.Contains(","))
                {
                    m2 = s.IndexOf(",");
                    ii = int.Parse(s.Substring(0, m2));
                    string s2;
                    x1 = Double.Parse(s) - ii;
                    s = Convert.ToString(ii, 16) + ",";
                    while (x1 < 1)
                    {
                        x1 *= 16;
                        if (x1.ToString().Contains(",")) { s2 = x1.ToString().Substring(0, x1.ToString().IndexOf(",")); }
                        else s2 = x1.ToString();
                        if (s2 == "10")
                        {
                            s += "A";
                        }
                        else if (s2 == "11") {
                            s += "B";
                        }
                        else if (s2 == "12")
                        {
                            s += "C";
                        }
                        else if (s2 == "13")
                        {
                            s += "D";
                        }
                        else if (s2 == "14")
                        {
                            s += "E";
                        }
                        else if (s2 == "15")
                        {
                            s += "F";
                        } else s += s2;
                        if (x1.ToString().Contains(","))
                        {
                            s2 = "0" + x1.ToString().Substring(x1.ToString().IndexOf(","));
                            x1 = Double.Parse(s2);
                        }


                    }


                }
                else
                {
                    ii = int.Parse(t1.Text);
                    s = Convert.ToString(ii, 16);
                }

                t1.Text = s;
                if (s.Contains(','))
                {
                    ii = s.IndexOf(',');
                    ch = s.Substring(0, ii).Length;
                    if (s.Contains("-"))
                    {
                        m1 = -1;
                    }
                    else { m1 = 1; }
                    if (ch <= n1)
                    {
                        point = 1;
                        ch = s.Substring(ii + 1).Length;
                    }
                }
                else
                {
                    ch = s.Length; point = 0; if (s.Contains("-"))
                    {
                        m1 = -1;
                    }
                    else { m1 = 1; }
                }
                s3 += t1.Text;
                if (t2.Text != "")
                {
                    t2.Text = s3 + "\n" + t2.Text;
                }
                else
                {
                    t2.Text = s3;
                }
            }
            ch = n1 * 2;
            if (t1.Text == "-0")
            {
                x1 = 0;
                s = "0";
                op = 0;
                point = 0;
                ch = 1;
                t1.Text = s;
                ii = 0;
                m1 = 1;
            }
            if (t1.Text == "-0")
            {
                x1 = 0;
                s = "0";
                op = 0;
                point = 0;
                ch = 1;
                t1.Text = s;
                ii = 0;
                m1 = 1;
            }
        }

        private void SQRTN(object sender, RoutedEventArgs e)
        {
            
                if (ch > n1)
                {
                    t1.Text = "0";
                    s = "0";
                    point = 0;
                    ch = 1;
                    op = 0; m1 = 1;
                    x1 = 1;
                    x2 = 1;
                    t1.FontSize = 130;
                }
                else
                {
                    if (ch > 0 & op == 4)
                    {
                        {
                            x1 = Math.Abs(x1);
                            x2 = Math.Abs(Double.Parse(s.Substring(ii + 1)));
                            if ((x2 % 2 == 0 & x1 > 0) | x2 % 2 != 0)
                            {
                            s3 = x1.ToString() + "^(1/" + x2.ToString() + ")=";
                                x1 = Math.Round(Math.Pow(x1,1/x2),6);
                                s = x1.ToString();
                                t1.Text = s;
                                x2 = 1;
                                x1 = 1;
                                op = 0;
                                if (s.Contains(','))
                                {
                                    ii = s.IndexOf(',');
                                    ch = s.Substring(0, ii).Length;
                                    if (s.Contains("-"))
                                    {
                                        m1 = -1;
                                    }
                                    else { m1 = 1; }
                                    if (ch <= n1)
                                    {
                                        point = 1;
                                        ch = s.Substring(ii + 1).Length;
                                    }
                                }
                                else
                                {
                                    ch = s.Length; point = 0; if (s.Contains("-"))
                                    {
                                        m1 = -1;
                                    }
                                    else { m1 = 1; }
                                }
                            s3 += t1.Text;
                            if (t2.Text != "")
                            {
                                t2.Text = s3 + "\n" + t2.Text;
                            }
                            else
                            {
                                t2.Text = s3;
                            }
                        }
                            else
                            {
                                s = "Корень вычислить нельзя";
                                t1.Text = s;
                                ch = n1 * 2;
                            }


                        }
                        if (t1.Text.Length + 1 > 9)
                        {
                            t1.FontSize = 52;
                        }
                        else t1.FontSize = 130;
                    }
                }
            if (t1.Text == "-0")
            {
                x1 = 0;
                s = "0";
                op = 0;
                point = 0;
                ch = 1;
                t1.Text = s;
                ii = 0;
                m1 = 1;
            }
        }

        private void HISTOR(object sender, RoutedEventArgs e)
        {

        }

        private void GGG(object sender, DragEventArgs e)
        {

        }

        private void ARCCOs(object sender, RoutedEventArgs e)
        {
            if (ch > n1)
            {
                t1.Text = "0" + "1";
                s = "0";
                point = 0; m1 = 1;
                ch = 1;
                op = 0;
                x1 = 1;
                x2 = 1;
                t1.FontSize = 130;
            }
            else if (op == 0)
            {
                s3 = "arccos(" + t1.Text + ")=";
                if (Double.Parse(t1.Text) >= -1 & Double.Parse(t1.Text) <= 1)
                {
                    {
                        if (rad.IsChecked == true)
                        {

                            x1 = Math.Round(Math.Acos(Double.Parse(t1.Text)), 6);
                            s = x1.ToString(doubleSchoolFormat);
                            t1.Text = s;
                            if (s.Contains(','))
                            {
                                ii = s.IndexOf(',');
                                ch = s.Substring(0, ii).Length;
                                if (s.Contains("-"))
                                {
                                    m1 = -1;
                                }
                                else { m1 = 1; }
                                if (ch <= n1)
                                {
                                    point = 1;
                                    ch = s.Substring(ii + 1).Length;
                                }
                            }
                            else
                            {
                                ch = s.Length; point = 0; if (s.Contains("-"))
                                {
                                    m1 = -1;
                                }
                                else { m1 = 1; }
                            }
                        }
                        else
                        {
                            x1 = Math.Round(Math.Acos(Double.Parse(t1.Text)), 6);
                            x1 = Math.Round(x1 * 180 / Math.Round(Math.PI,6),6);
                            s = x1.ToString(doubleSchoolFormat);
                            t1.Text = s;
                            if (s.Contains(','))
                            {
                                ii = s.IndexOf(',');
                                ch = s.Substring(0, ii).Length;
                                if (s.Contains("-"))
                                {
                                    m1 = -1;
                                }
                                else { m1 = 1; }
                                if (ch <= n1)
                                {
                                    point = 1;
                                    ch = s.Substring(ii + 1).Length;
                                }
                            }
                            else
                            {
                                ch = s.Length; point = 0; if (s.Contains("-"))
                                {
                                    m1 = -1;
                                }
                                else { m1 = 1; }
                            }
                        }
                    }
                }
                else
                {
                    s = "Такого Аркосинуса не существует";
                    t1.Text = s;
                    ch = n1 * 2;
                }
                s3 += t1.Text;
                if (t2.Text != "")
                {
                    t2.Text = s3 + "\n" + t2.Text;
                }
                else
                {
                    t2.Text = s3;
                }
            }
            if (t1.Text.Length + 1 > 9)
            {
                t1.FontSize = 52;
            }
            else t1.FontSize = 130;
            if (t1.Text == "-0")
            {
                x1 = 0;
                s = "0";
                op = 0;
                point = 0;
                ch = 1;
                t1.Text = s;
                ii = 0;
                m1 = 1;
            }
        }

        private void ARCSIN(object sender, RoutedEventArgs e)
        {
            if (ch > n1)
            {
                t1.Text = "0";
                s = "0";
                point = 0; m1 = 1;
                ch = 1;
                op = 0;
                x1 = 1;
                x2 = 1;
                t1.FontSize = 130;
            }
            else if (op == 0)
            {
                if (Double.Parse(t1.Text) >= -1 & Double.Parse(t1.Text) <= 1)
                {
                    {
                        s3 = "arcsin(" + t1.Text + ")=";
                        if (rad.IsChecked == true)
                        {
                            
                            x1 = Math.Round(Math.Asin(Double.Parse(t1.Text)), 6);
                            s = x1.ToString(doubleSchoolFormat);
                            t1.Text = s;
                            if (s.Contains(','))
                            {
                                ii = s.IndexOf(',');
                                ch = s.Substring(0, ii).Length;
                                if (s.Contains("-"))
                                {
                                    m1 = -1;
                                }
                                else { m1 = 1; }
                                if (ch <= n1)
                                {
                                    point = 1;
                                    ch = s.Substring(ii + 1).Length;
                                }
                            }
                            else
                            {
                                ch = s.Length; point = 0; if (s.Contains("-"))
                                {
                                    m1 = -1;
                                }
                                else { m1 = 1; }
                            }
                        }
                        else
                        {
                            x1 = Math.Round(Math.Asin((Double.Parse(t1.Text))), 6);
                            x1 = Math.Round(x1 * 180 / Math.Round(Math.PI, 6), 6);
                            s = x1.ToString(doubleSchoolFormat);
                            t1.Text = s;
                            if (s.Contains(','))
                            {
                                ii = s.IndexOf(',');
                                ch = s.Substring(0, ii).Length;
                                if (s.Contains("-"))
                                {
                                    m1 = -1;
                                }
                                else { m1 = 1; }
                                if (ch <= n1)
                                {
                                    point = 1;
                                    ch = s.Substring(ii + 1).Length;
                                }
                            }
                            else
                            {
                                ch = s.Length; point = 0; if (s.Contains("-"))
                                {
                                    m1 = -1;
                                }
                                else { m1 = 1; }
                            }
                        }
                        s3 += t1.Text;
                        if (t2.Text != "")
                        {
                            t2.Text = s3 + "\n" + t2.Text;
                        }
                        else
                        {
                            t2.Text = s3;
                        }
                    }
                }
                else
                {
                    s = "Такого Арксинуса не существует";
                    t1.Text = s;
                    ch = n1 * 2;
                }
            }
            if (t1.Text.Length + 1 > 9)
            {
                t1.FontSize = 52;
            }
            else t1.FontSize = 130;
            if (t1.Text == "-0")
            {
                x1 = 0;
                s = "0";
                op = 0;
                point = 0;
                ch = 1;
                t1.Text = s;
                ii = 0;
                m1 = 1;
            }
        }

        private void ARCtg(object sender, RoutedEventArgs e)
        {
            if (ch > n1)
            {
                t1.Text = "0";
                s = "0";
                point = 0; m1 = 1;
                ch = 1;
                op = 0;
                x1 = 1;
                x2 = 1;
                t1.FontSize = 130;
            }
            else if (op == 0)
            {
                
                
                    {
                        if (rad.IsChecked == true)
                        {
                            s3 = "arctg(" + t1.Text + ")=";
                            x1 = Math.Round(Math.Atan(Double.Parse(t1.Text)), 6);
                            s = x1.ToString(doubleSchoolFormat);
                            t1.Text = s;
                            if (s.Contains(','))
                            {
                                ii = s.IndexOf(',');
                                ch = s.Substring(0, ii).Length;
                                if (s.Contains("-"))
                                {
                                    m1 = -1;
                                }
                                else { m1 = 1; }
                                if (ch <= n1)
                                {
                                    point = 1;
                                    ch = s.Substring(ii + 1).Length;
                                }
                            }
                            else
                            {
                                ch = s.Length; point = 0; if (s.Contains("-"))
                                {
                                    m1 = -1;
                                }
                                else { m1 = 1; }
                            }
                        s3 += t1.Text;
                        if (t2.Text != "")
                        {
                            t2.Text = s3 + "\n" + t2.Text;
                        }
                        else
                        {
                            t2.Text = s3;
                        }
                    }
                        else
                        {
                        s3 = "arctd(" + t1.Text + ")=";
                            x1 = Math.Round(Math.Atan((Double.Parse(t1.Text))), 6);
                            x1 = Math.Round(x1 * 180 / Math.Round(Math.PI, 6), 6);
                            s = x1.ToString(doubleSchoolFormat);
                            t1.Text = s;
                            if (s.Contains(','))
                            {
                                ii = s.IndexOf(',');
                                ch = s.Substring(0, ii).Length;
                                if (s.Contains("-"))
                                {
                                    m1 = -1;
                                }
                                else { m1 = 1; }
                                if (ch <= n1)
                                {
                                    point = 1;
                                    ch = s.Substring(ii + 1).Length;
                                }
                            }
                            else
                            {
                                ch = s.Length; point = 0; if (s.Contains("-"))
                                {
                                    m1 = -1;
                                }
                                else { m1 = 1; }
                            }
                        s3 += t1.Text;
                        if (t2.Text != "")
                        {
                            t2.Text = s3 + "\n" + t2.Text;
                        }
                        else
                        {
                            t2.Text = s3;
                        }
                    }
                    }
                }
                else
                {
                    s = "Такого Арксинуса не существует";
                    t1.Text = s;
                    ch = n1 * 2;
                }
            
            if (t1.Text.Length + 1 > 9)
            {
                t1.FontSize = 52;
            }
            else t1.FontSize = 130;
            if (t1.Text == "-0")
            {
                x1 = 0;
                s = "0";
                op = 0;
                point = 0;
                ch = 1;
                t1.Text = s;
                ii = 0;
                m1 = 1;
            }
            if (t1.Text == "-0")
            {
                x1 = 0;
                s = "0";
                op = 0;
                point = 0;
                ch = 1;
                t1.Text = s;
                ii = 0;
                m1 = 1;
            }
        }

        private void Arcos(object sender, RoutedEventArgs e)
        {
            if (ch > n1)
            {
                t1.Text = "0" + "1";
                s = "0";
                point = 0; m1 = 1;
                ch = 1;
                op = 0;
                x1 = 1;
                x2 = 1;
                t1.FontSize = 130;
            }
            else if (op == 0)
            {
                if (Double.Parse(t1.Text) >= -1 & Double.Parse(t1.Text) <= 1)
                {
                    {
                        if (rad.IsChecked == true)
                        {
                            s3 = "arccos(" + t1.Text + ")=";
                            x1 = Math.Round(Math.Acos(Double.Parse(t1.Text)), 6);
                            s = x1.ToString(doubleSchoolFormat);
                            t1.Text = s;
                            if (s.Contains(','))
                            {
                                ii = s.IndexOf(',');
                                ch = s.Substring(0, ii).Length;
                                if (s.Contains("-"))
                                {
                                    m1 = -1;
                                }
                                else { m1 = 1; }
                                if (ch <= n1)
                                {
                                    point = 1;
                                    ch = s.Substring(ii + 1).Length;
                                }
                            }
                            else
                            {
                                ch = s.Length; point = 0; if (s.Contains("-"))
                                {
                                    m1 = -1;
                                }
                                else { m1 = 1; }
                            }
                            s3 += t1.Text;
                            if (t2.Text != "")
                            {
                                t2.Text = s3 + "\n" + t2.Text;
                            }
                            else
                            {
                                t2.Text = s3;
                            }
                        }
                        else
                        {
                            if (t1.Text == "1")
                            {
                                s3 = "arccos(" + t1.Text + ")=";
                                s = "0";
                                t1.Text = s;
                                s3 += t1.Text;
                                if (t2.Text != "")
                                {
                                    t2.Text = s3 + "\n" + t2.Text;
                                }
                                else
                                {
                                    t2.Text = s3;
                                }
                            }
                            else if (t1.Text == "-1")
                            {
                                s3 = "arccos(" + t1.Text + ")=";
                                s = "180";
                                t1.Text = s;
                                s3 += t1.Text;
                                if (t2.Text != "")
                                {
                                    t2.Text = s3 + "\n" + t2.Text;
                                }
                                else
                                {
                                    t2.Text = s3;
                                }
                            }
                            else
                            {
                                s3 = "arccos(" + t1.Text + ")=";
                                x1 = Math.Round(Math.Acos(Double.Parse(t1.Text)), 6);
                                x1 = Math.Round(x1 * 180 / Math.Round(Math.PI, 6), 6);
                                s = x1.ToString(doubleSchoolFormat);
                                t1.Text = s;
                                if (s.Contains(','))
                                {
                                    ii = s.IndexOf(',');
                                    ch = s.Substring(0, ii).Length;
                                    if (s.Contains("-"))
                                    {
                                        m1 = -1;
                                    }
                                    else { m1 = 1; }
                                    if (ch <= n1)
                                    {
                                        point = 1;
                                        ch = s.Substring(ii + 1).Length;
                                    }
                                }
                                else
                                {
                                    ch = s.Length; point = 0; if (s.Contains("-"))
                                    {
                                        m1 = -1;
                                    }
                                    else { m1 = 1; }
                                }
                                s3 += t1.Text;
                                if (t2.Text != "")
                                {
                                    t2.Text = s3 + "\n" + t2.Text;
                                }
                                else
                                {
                                    t2.Text = s3;
                                }
                                s3 += t1.Text;
                                if (t2.Text != "")
                                {
                                    t2.Text = s3 + "\n" + t2.Text;
                                }
                                else
                                {
                                    t2.Text = s3;
                                }
                            }
                        }
                    }
                }
                else
                {
                    s = "Такого Аркосинуса не существует";
                    t1.Text = s;
                    ch = n1 * 2;
                }
            }
            if (t1.Text.Length + 1 > 9)
            {
                t1.FontSize = 52;
            }
            else t1.FontSize = 130;
            if (t1.Text == "-0")
            {
                x1 = 0;
                s = "0";
                op = 0;
                point = 0;
                ch = 1;
                t1.Text = s;
                ii = 0;
                m1 = 1;
            }
        }

        private void Arsin(object sender, RoutedEventArgs e)
        {
            if (ch > n1)
            {
                t1.Text = "0";
                s = "0";
                point = 0; m1 = 1;
                ch = 1;
                op = 0;
                x1 = 1;
                x2 = 1;
                t1.FontSize = 130;
            }
            else if (op == 0)
            {
                if (Double.Parse(t1.Text) >= -1 & Double.Parse(t1.Text) <= 1)
                {
                    {
                        if (rad.IsChecked == true)
                        {
                            s3 = "arcsin(+" + t1.Text + ")=";
                            x1 = Math.Round(Math.Asin(Double.Parse(t1.Text)), 6);
                            s = x1.ToString(doubleSchoolFormat);
                            t1.Text = s;
                            if (s.Contains(','))
                            {
                                ii = s.IndexOf(',');
                                ch = s.Substring(0, ii).Length;
                                if (s.Contains("-"))
                                {
                                    m1 = -1;
                                }
                                else { m1 = 1; }
                                if (ch <= n1)
                                {
                                    point = 1;
                                    ch = s.Substring(ii + 1).Length;
                                }
                            }
                            else
                            {
                                ch = s.Length; point = 0; if (s.Contains("-"))
                                {
                                    m1 = -1;
                                }
                                else { m1 = 1; }
                            }
                            s3 += t1.Text;
                            if (t2.Text != "")
                            {
                                t2.Text = s3 + "\n" + t2.Text;
                            }
                            else
                            {
                                t2.Text = s3;
                            }
                        }
                        else
                        {
                            if (t1.Text == "1")
                            {
                                s3 = "arcsin(" + t1.Text + ")=";
                                s = "90";
                                t1.Text = s;
                                s3 += t1.Text;
                                if (t2.Text != "")
                                {
                                    t2.Text = s3 + "\n" + t2.Text;
                                }
                                else
                                {
                                    t2.Text = s3;
                                }
                            }
                            else if (t1.Text == "-1")
                            {
                                s3 = "arcsin(" + t1.Text + ")=";
                                s = "270";
                                t1.Text = s;
                                s3 += t1.Text;
                                if (t2.Text != "")
                                {
                                    t2.Text = s3 + "\n" + t2.Text;
                                }
                                else
                                {
                                    t2.Text = s3;
                                }
                            }
                            else
                            {
                                s3 = "arcsin(" + t1.Text + ")=";
                                x1 = Math.Round(Math.Asin((Double.Parse(t1.Text))), 6);
                                x1 = Math.Round(x1 * 180 / Math.Round(Math.PI, 6), 6);
                                s = x1.ToString(doubleSchoolFormat);
                                t1.Text = s;
                                if (s.Contains(','))
                                {
                                    ii = s.IndexOf(',');
                                    ch = s.Substring(0, ii).Length;
                                    if (s.Contains("-"))
                                    {
                                        m1 = -1;
                                    }
                                    else { m1 = 1; }
                                    if (ch <= n1)
                                    {
                                        point = 1;
                                        ch = s.Substring(ii + 1).Length;
                                    }
                                }
                                else
                                {
                                    ch = s.Length; point = 0; if (s.Contains("-"))
                                    {
                                        m1 = -1;
                                    }
                                    else { m1 = 1; }
                                }
                                s3 += t1.Text;
                                if (t2.Text != "")
                                {
                                    t2.Text = s3 + "\n" + t2.Text;
                                }
                                else
                                {
                                    t2.Text = s3;
                                }
                            }
                        }
                    }
                }
                else
                {
                    s = "Такого Арксинуса не существует";
                    t1.Text = s;
                    ch = n1 * 2;
                }
            }
            if (t1.Text.Length + 1 > 9)
            {
                t1.FontSize = 52;
            }
            else t1.FontSize = 130;
            if (t1.Text == "-0")
            {
                x1 = 0;
                s = "0";
                op = 0;
                point = 0;
                ch = 1;
                t1.Text = s;
                ii = 0;
                m1 = 1;
            }
        }

        private void Arcctg(object sender, RoutedEventArgs e)
        {
            if (ch > n1)
            {
                t1.Text = "0";
                s = "0";
                point = 0; m1 = 1;
                ch = 1;
                op = 0;
                x1 = 1;
                x2 = 1;
                t1.FontSize = 130;
            }
            else if (op == 0)
            {


                {
                    if (rad.IsChecked == true)
                    {
                        s3 = "arcctg(" + t1.Text + ")=";
                        x1 = Math.Round(Math.PI / 2 - Math.Atan((Double.Parse(t1.Text))), 6);
                        s = x1.ToString(doubleSchoolFormat);
                        t1.Text = s;
                        if (s.Contains(','))
                        {
                            ii = s.IndexOf(',');
                            ch = s.Substring(0, ii).Length;
                            if (s.Contains("-"))
                            {
                                m1 = -1;
                            }
                            else { m1 = 1; }
                            if (ch <= n1)
                            {
                                point = 1;
                                ch = s.Substring(ii + 1).Length;
                            }
                        }
                        else
                        {
                            ch = s.Length; point = 0; if (s.Contains("-"))
                            {
                                m1 = -1;
                            }
                            else { m1 = 1; }
                        }
                        s3 += t1.Text;
                        if (t2.Text != "")
                        {
                            t2.Text = s3 + "\n" + t2.Text;
                        }
                        else
                        {
                            t2.Text = s3;
                        }
                    }
                    else if(t1.Text == "0")
                    {
                        s3 = "arcctg(" + t1.Text + ")=";
                        s = "90";
                        t1.Text = s;
                        s3 += t1.Text;
                        if (t2.Text != "")
                        {
                            t2.Text = s3 + "\n" + t2.Text;
                        }
                        else
                        {
                            t2.Text = s3;
                        }
                    } else
                    {
                        s3 = "arctg(" + t1.Text + ")=";
                        x1 = Math.Round(Math.PI / 2 - Math.Atan((Double.Parse(t1.Text))), 6);
                        x1 = Math.Round(x1 * 180 / Math.Round(Math.PI, 6), 6);
                        s = x1.ToString(doubleSchoolFormat);
                        t1.Text = s;
                        if (s.Contains(','))
                        {
                            ii = s.IndexOf(',');
                            ch = s.Substring(0, ii).Length;
                            if (s.Contains("-"))
                            {
                                m1 = -1;
                            }
                            else { m1 = 1; }
                            if (ch <= n1)
                            {
                                point = 1;
                                ch = s.Substring(ii + 1).Length;
                            }
                        }
                        else
                        {
                            ch = s.Length; point = 0; if (s.Contains("-"))
                            {
                                m1 = -1;
                            }
                            else { m1 = 1; }
                        }
                        s3 += t1.Text;
                        if (t2.Text != "")
                        {
                            t2.Text = s3 + "\n" + t2.Text;
                        }
                        else
                        {
                            t2.Text = s3;
                        }
                    }
                }
            }
            else
            {
                s = "Такого Арксинуса не существует";
                t1.Text = s;
                ch = n1 * 2;
            }

            if (t1.Text.Length + 1 > 9)
            {
                t1.FontSize = 52;
            }
            else t1.FontSize = 130;
            if (t1.Text == "-0")
            {
                x1 = 0;
                s = "0";
                op = 0;
                point = 0;
                ch = 1;
                t1.Text = s;
                ii = 0;
                m1 = 1;
            }
        }

        private void CE(object sender, RoutedEventArgs e)
        {
            if(op == 0)
            {
                x1 = 0;
                s = "0";
                op = 0;
                point = 0;
                ch = 1;
                t1.Text = s;
                ii = 0;
                m1 = 1;
            } else if(op != 0 & ch != 0)
            {
                s = s.Substring(0, ii+1);
                t1.Text = s;
                ch = 0;
                point = 0;
            }else if(op == 1 | op == 2 | op == 3 | op == 4 | op == 5)
            {
                s = s.Substring(0,ii);
                t1.Text = s;
                op = 0;
                if(s.Contains("-")) { m1 = -1; } else { m1 = 1; };
                if (s.Contains(','))
                {
                    ii = s.IndexOf(',');
                    ch = s.Substring(0, ii).Length;
                    if (s.Contains("-"))
                    {
                        m1 = -1;
                    }
                    else { m1 = 1; }
                    if (ch <= n1)
                    {
                        point = 1;
                        ch = s.Substring(ii + 1).Length;
                    }
                }
                else
                {
                    ch = s.Length; point = 0; if (s.Contains("-"))
                    {
                        m1 = -1;
                    }
                    else { m1 = 1; }
                }
            } else if (op == 6 & ch != 0)
            {
                s = s.Substring(0, ii + 1);
                t1.Text = s;
                ch = 0;
            }
            else if (op == 6 & ch == 0)
            {   
                s = s.Substring(0, s.Length-1);
                s = s.Substring(4);
                if (s.Contains("-")) { m1 = -1; } else { m1 = 1; }
                t1.Text = s;
                if (s.Contains(','))
                {
                    ii = s.IndexOf(',');
                    ch = s.Substring(0, ii).Length;
                    if (s.Contains("-"))
                    {
                        m1 = -1;
                    }
                    else { m1 = 1; }
                    if (ch <= n1)
                    {
                        point = 1;
                        ch = s.Substring(ii + 1).Length;
                    }
                }
                else
                {
                    ch = s.Length; point = 0; if (s.Contains("-"))
                    {
                        m1 = -1;
                    }
                    else { m1 = 1; }
                }
            }
            if (t1.Text == "-0")
            {
                x1 = 0;
                s = "0";
                op = 0;
                point = 0;
                ch = 1;
                t1.Text = s;
                ii = 0;
                m1 = 1;
            }
        }

        private void ALLHIS(object sender, RoutedEventArgs e)
        {
            t2.Text = "";
        }

        private void HisDel(object sender, RoutedEventArgs e)
        {
            int ir;
            if (t2.Text != "" & t2.Text.Contains("\n"))
            {
                ir = t2.Text.IndexOf("\n");
                t2.Text = t2.Text.Substring(ir + 1);
            }
            else if (t2.Text != "")
            {
                t2.Text = "";
            }
        }

        private void DEKS(object sender, RoutedEventArgs e)
        {
        }

        private void VVV(object sender, RoutedEventArgs e)
        {
            t1.Text = "0";
            s = "0";
            point = 0;
            ch = 1; m1 = 1;
            op = 0;
            x1 = 1;
            t1.FontSize = 130;
            x2 = 1;
        }

        private void kk(object sender, RoutedEventArgs e)
        {
            if (his.IsChecked == true)
            {
                this.Width += 555;
            }
            else
            {
                this.Width -= 555;
            }
        }

        private void CG(object sender, RoutedEventArgs e)
        {
            if (ch > n1)
            {
                t1.Text = "0" + "1";
                s = "0";
                point = 0;
                ch = 1; m1 = 1;
                op = 0;
                x1 = 1;
                x2 = 1;
                t1.FontSize = 130;
            }
            else if (op == 0)
            {
                if (rad.IsChecked == true )
                { if (Double.Parse(t1.Text) % Math.Round(Math.PI, 6) != 0 & Math.Round(Math.Sin(Double.Parse(t1.Text)),6) != 0 & Math.Round(Math.Cos(Double.Parse(t1.Text)),6) != - 1 & Math.Round(Math.Cos(Double.Parse(t1.Text)),6) != 1)
                    {
                        s3 = "ctg(" + t1.Text + ")=";
                        x1 = Math.Round(Math.Cos((Double.Parse(t1.Text))) / Math.Sin((Double.Parse(t1.Text))), 6);
                        
                        s = x1.ToString(doubleSchoolFormat);
                        t1.Text = s;
                        if (s.Contains(','))
                        {
                            ii = s.IndexOf(',');
                            ch = s.Substring(0, ii).Length;
                            if (s.Contains("-"))
                            {
                                m1 = -1;
                            }
                            else { m1 = 1; }
                            if (ch <= n1)
                            {
                                point = 1;
                                ch = s.Substring(ii + 1).Length;
                            }
                        }
                        else
                        {
                            ch = s.Length; point = 0; if (s.Contains("-"))
                            {
                                m1 = -1;
                            }
                            else { m1 = 1; }
                        }
                    }
                    else
                    {
                        s = "Данный котангенс не существет";
                        t1.Text = s;
                        ch = n1 * 2;
                        point = 0;

                    }
                    s3 += t1.Text;
                    if (t2.Text != "")
                    {
                        t2.Text = s3 + "\n" + t2.Text;
                    }
                    else
                    {
                        t2.Text = s3;
                    }
                }
                else if((Double.Parse(t1.Text)) % 180 != 0)
                {
                    s3 = "ctg(" + t1.Text + ")=";
                    x1 = Math.Round(Math.Cos((Double.Parse(t1.Text)/180 * Math.PI)) / Math.Sin((Double.Parse(t1.Text) / 180 * Math.PI)), 6);
                    s = x1.ToString(doubleSchoolFormat);
                    t1.Text = s;
                    if (s.Contains(','))
                    {
                        ii = s.IndexOf(',');
                        ch = s.Substring(0, ii).Length;
                        if (s.Contains("-"))
                        {
                            m1 = -1;
                        }
                        else { m1 = 1; }
                        if (ch <= n1)
                        {
                            point = 1;
                            ch = s.Substring(ii + 1).Length;
                        }
                    }
                    else
                    {
                        ch = s.Length; point = 0; if (s.Contains("-"))
                        {
                            m1 = -1;
                        }
                        else { m1 = 1; }
                    }
                    s3 += t1.Text;
                    if (t2.Text != "")
                    {
                        t2.Text = s3 + "\n" + t2.Text;
                    }
                    else
                    {
                        t2.Text = s3;
                    }
                }
                else
                {
                    s = "Данный котангенс не существет";
                    t1.Text = s;
                    ch = n1 * 2;
                    point = 0;

                }
            }
            if (t1.Text.Length + 1 > 9)
            {
                t1.FontSize = 52;
            }
            else t1.FontSize = 130;
            if (t1.Text == "-0")
            {
                x1 = 0;
                s = "0";
                op = 0;
                point = 0;
                ch = 1;
                t1.Text = s;
                ii = 0;
                m1 = 1;
            }
        }

        private void Sin(object sender, RoutedEventArgs e)
        {
            if (ch > n1)
            {
                t1.Text = "0";
                s = "0";
                point = 0;
                ch = 1; m1 = 1;
                op = 0;
                x1 = 1;
                x2 = 1;
                t1.FontSize = 130;
            }
            else if (op == 0)
            {
                if (rad.IsChecked == true)
                {
                    s3 = "sin(" + t1.Text + ")=";
                    x1 = Math.Round(Math.Sin(Double.Parse(t1.Text)), 6);
                    s = x1.ToString(doubleSchoolFormat);
                    t1.Text = s;
                    if (s.Contains(','))
                    {
                        ii = s.IndexOf(',');
                        ch = s.Substring(0, ii).Length;
                        if (s.Contains("-"))
                        {
                            m1 = -1;
                        }
                        else { m1 = 1; }
                        if (ch <= n1)
                        {
                            point = 1;
                            ch = s.Substring(ii + 1).Length;
                        }
                    }
                    else
                    {
                        ch = s.Length; point = 0; if (s.Contains("-"))
                        {
                            m1 = -1;
                        }
                        else { m1 = 1; }
                    }
                    s3 += t1.Text;
                    if (t2.Text != "")
                    {
                        t2.Text = s3 + "\n" + t2.Text;
                    }
                    else
                    {
                        t2.Text = s3;
                    }
                }
                else
                {
                    s3 = "sin(" + t1.Text + ")=";
                    x1 = Math.Round(Math.Sin((Double.Parse(t1.Text) / 180) * Math.PI), 6);
                    s = x1.ToString(doubleSchoolFormat);
                    t1.Text = s;
                    if (s.Contains(','))
                    {
                        ii = s.IndexOf(',');
                        ch = s.Substring(0, ii).Length;
                        if (s.Contains("-"))
                        {
                            m1 = -1;
                        }
                        else { m1 = 1; }
                        if (ch <= n1)
                        {
                            point = 1;
                            ch = s.Substring(ii + 1).Length;
                        }
                    }
                    else
                    {
                        ch = s.Length; point = 0; if (s.Contains("-"))
                        {
                            m1 = -1;
                        }
                        else { m1 = 1; }
                    }
                    s3 += t1.Text;
                    if (t2.Text != "")
                    {
                        t2.Text = s3 + "\n" + t2.Text;
                    }
                    else
                    {
                        t2.Text = s3;
                    }
                }
            }
            if (t1.Text.Length + 1 > 9)
            {
                t1.FontSize = 52;
            }
            else t1.FontSize = 130;
            if (t1.Text == "-0")
            {
                x1 = 0;
                s = "0";
                op = 0;
                point = 0;
                ch = 1;
                t1.Text = s;
                ii = 0;
                m1 = 1;
            }
        }

        private void Bsqrt(object sender, RoutedEventArgs e)
        { if (ch > n1)
            {
                t1.Text = "0";
                s = "0";
                point = 0;
                ch = 1;
                op = 0; m1 = 1;
                x1 = 1;
                x2 = 1;
                t1.FontSize = 130;
            }
            else
            if (ch > n1)
            {
                t1.Text = "0";
                s = "0";
                point = 0;
                ch = 1;
                op = 0;
                x1 = 1; m1 = 1;
                x2 = 1;
                t1.FontSize = 130;
            }
            else
            if(t1.Text == "0")
            {
                s = "0";
                t1.Text = s;
            } else
            if (op == 0 & !t1.Text.Contains('-'))
            {
                s3 = t1.Text + "^(1/2)=";
                x1 = Math.Round(Math.Sqrt(float.Parse(t1.Text)),6);
                s = x1.ToString(doubleSchoolFormat);
                t1.Text = s;
                if (s.Contains(','))
                {
                    ii = s.IndexOf(',');
                    ch = s.Substring(0, ii).Length;
                    if (s.Contains("-"))
                    {
                        m1 = -1;
                    }
                    else { m1 = 1; }
                    if (ch <= n1)
                    {
                        point = 1;
                        ch = s.Substring(ii + 1).Length;
                    }
                }
                else
                {
                    ch = s.Length; point = 0; if (s.Contains("-"))
                    {
                        m1 = -1;
                    }
                    else { m1 = 1; }
                }
                s3 += t1.Text;
                if (t2.Text != "")
                {
                    t2.Text = s3 + "\n" + t2.Text;
                }
                else
                {
                    t2.Text = s3;
                }
            } else
            {
                t1.Text = "Нельзя вычислить корень";
                ch = 2 * n1;
            }
            if (t1.Text.Length + 1 > 9)
            {
                t1.FontSize = 52;
            }
            else t1.FontSize = 130;
            if (t1.Text == "-0")
            {
                x1 = 0;
                s = "0";
                op = 0;
                point = 0;
                ch = 1;
                t1.Text = s;
                ii = 0;
                m1 = 1;
            }
        }



        private void percent(object sender, RoutedEventArgs e)
        {
            
            if (ch > n1)
            {
                t1.Text = "0";
                s = "0";
                point = 0;
                ch = 1;
                op = 0;
                x1 = 1; m1 = 1;
                x2 = 1;
                t1.FontSize = 130;
            }
            else if (op == 4 & ch > 0)
                {
                s3 = t1.Text.Substring(0, ii) + "%" + t1.Text.Substring(ii + 1) + "=";
                    x1 = Math.Abs(x1);
                    x2 = Math.Abs(Double.Parse(s.Substring(ii + 1)));
                    x1 = Math.Round(x1 / 100 * x2, 6);
                    s = x1.ToString();
                    t1.Text = s;
                    x2 = 1;
                    x1 = 1;
                    op = 0;
                if (s.Contains(','))
                {
                    ii = s.IndexOf(',');
                    ch = s.Substring(0, ii).Length;
                    if (s.Contains("-"))
                    {
                        m1 = -1;
                    }
                    else { m1 = 1; }
                    if (ch <= n1)
                    {
                        point = 1;
                        ch = s.Substring(ii + 1).Length;
                    }
                }
                else
                {
                    ch = s.Length; point = 0; if (s.Contains("-"))
                    {
                        m1 = -1;
                    }
                    else { m1 = 1; }
                }
                s3 += t1.Text;
                if (t2.Text != "")
                {
                    t2.Text = s3 + "\n" + t2.Text;
                }
                else
                {
                    t2.Text = s3;
                }


            }
            if (t1.Text.Length + 1 > 9)
            {
                t1.FontSize = 52;
            }
            else t1.FontSize = 130;
            if (t1.Text == "-0")
            {
                x1 = 0;
                s = "0";
                op = 0;
                point = 0;
                ch = 1;
                t1.Text = s;
                ii = 0;
                m1 = 1;
            }
        }


        
        private void schet(object sender, RoutedEventArgs e)
        {
           
            if (ch > n1)
            {
                t1.Text = "0";
                s = "0";
                point = 0;
                ch = 1; m1 = 1;
                op = 0;
                x1 = 1;
                t1.FontSize = 130;
                x2 = 1;
            } else
            {
                Button b = (Button)sender;
                if (op != 0 & ch != 0)
                {
                    if (op == 1 & ch != 0)
                    {
                        s3 = t1.Text + "=";
                        x2 = Double.Parse(s.Substring(ii + 1));
                        x1 = Math.Round(x1 + x2, 6);
                        s = x1.ToString();
                        t1.Text = s;
                        op = 0;
                        x2 = 1;
                        if (s.Contains(','))
                        {
                            ii = s.IndexOf(',');
                            ch = s.Substring(0, ii).Length;
                            if (s.Contains("-"))
                            {
                                m1 = -1;
                            }
                            else { m1 = 1; }
                            if (ch <= n1)
                            {
                                point = 1;
                                ch = s.Substring(ii + 1).Length;
                            }
                        }
                        else
                        {
                            ch = s.Length; point = 0; if (s.Contains("-"))
                            {
                                m1 = -1;
                            }
                            else { m1 = 1; }
                        }
                        s3 += t1.Text;
                        if (t2.Text != "")
                        {
                            t2.Text = s3 + "\n" + t2.Text;
                        }
                        else
                        {
                            t2.Text = s3;
                        }
                    }

                    else if (op == 2 & ch != 0)
                    {
                        s3 = t1.Text + "=";
                        x2 = Double.Parse(s.Substring(ii + 1));
                        x1 = Math.Round(x1 - x2, 6);
                        s = x1.ToString();
                        t1.Text = s;
                        op = 0;
                        x2 = 1;
                        point = 0;
                        if (s.Contains(','))
                        {
                            ii = s.IndexOf(',');
                            ch = s.Substring(0, ii).Length;
                            if (s.Contains("-"))
                            {
                                m1 = -1;
                            }
                            else { m1 = 1; }
                            if (ch <= n1)
                            {
                                point = 1;
                                ch = s.Substring(ii + 1).Length;
                            }
                        }
                        else
                        {
                            ch = s.Length; point = 0; if (s.Contains("-"))
                            {
                                m1 = -1;
                            }
                            else { m1 = 1; }
                        }
                        s3 += t1.Text;
                        if (t2.Text != "")
                        {
                            t2.Text = s3 + "\n" + t2.Text;
                        }
                        else
                        {
                            t2.Text = s3;
                        }
                    }
                    else if (op == 3 & ch != 0)
                    {
                        s3 = t1.Text + "=";
                        x2 = Double.Parse(s.Substring(ii + 1));
                        if (x2 == 0)
                        {
                            t1.Text = "На ноль делить нельзя";
                            ch = n1 + 2;

                        }
                        else
                        {
                            x1 = Math.Round(x1 / x2, 6);
                            s = x1.ToString(doubleSchoolFormat);
                            t1.Text = s;
                            op = 0;
                            x2 = 1;
                            point = 0;
                           if (s.Contains(','))
                        {
                            ii = s.IndexOf(',');
                            ch = s.Substring(0, ii).Length;
                            if (s.Contains("-"))
                            {
                                m1 = -1;
                            }
                            else { m1 = 1; }
                            if (ch <= n1)
                            {
                                point = 1;
                                ch = s.Substring(ii + 1).Length;
                            }
                        }
                        else { ch = s.Length; point = 0; if (s.Contains("-"))
                            {
                                m1 = -1;
                            }
                            else { m1 = 1; }
                        }
                            s3 += t1.Text;
                            if (t2.Text != "")
                            {
                                t2.Text = s3 + "\n" + t2.Text;
                            }
                            else
                            {
                                t2.Text = s3;
                            }
                        }

                    }
                    else if (op == 4 & ch != 0)
                    {
                        s3 = t1.Text + "=";
                        x2 = Double.Parse(s.Substring(ii + 1));
                        x1 = Math.Round(x1 * x2, 6);
                        s = x1.ToString(doubleSchoolFormat);
                        t1.Text = s;
                        op = 0;
                        x2 = 1;
                        point = 0;
                        if (s.Contains(','))
                        {
                            ii = s.IndexOf(',');
                            ch = s.Substring(0, ii).Length;
                            if (s.Contains("-"))
                            {
                                m1 = -1;
                            }
                            else { m1 = 1; }
                            if (ch <= n1)
                            {
                                point = 1;
                                ch = s.Substring(ii + 1).Length;
                            }
                        }
                        else
                        {
                            ch = s.Length; point = 0; if (s.Contains("-"))
                            {
                                m1 = -1;
                            }
                            else { m1 = 1; }
                        }
                        s3 += t1.Text;
                        if (t2.Text != "")
                        {
                            t2.Text = s3 + "\n" + t2.Text;
                        }
                        else
                        {
                            t2.Text = s3;
                        }
                    }
                    else if (op == 5 & ch != 0)
                    {
                        s3 = t1.Text + "=";
                        x2 = Double.Parse(s.Substring(ii + 1));
                        x1 = Math.Round(Math.Pow(x1, x2), 6);
                        s = x1.ToString(doubleSchoolFormat);
                        t1.Text = s;
                        op = 0;
                        x2 = 1;
                        point = 0;
                        if (s.Contains(','))
                        {
                            ii = s.IndexOf(',');
                            ch = s.Substring(0, ii).Length;
                            if (s.Contains("-"))
                            {
                                m1 = -1;
                            }
                            else { m1 = 1; }
                            if (ch <= n1)
                            {
                                point = 1;
                                ch = s.Substring(ii + 1).Length;
                            }
                        }
                        else
                        {
                            ch = s.Length; point = 0; if (s.Contains("-"))
                            {
                                m1 = -1;
                            }
                            else { m1 = 1; }
                        }
                        s3 += t1.Text;
                        if (t2.Text != "")
                        {
                            t2.Text = s3 + "\n" + t2.Text;
                        }
                        else
                        {
                            t2.Text = s3;
                        }
                    }
                    else if(op == 6 & ch != 0)
                    {
                        s3 = t1.Text + ")=";
                        x2 = Double.Parse(t1.Text.Substring(ii+1));
                        x1 = Math.Round(Math.Log(x1,x2), 6);
                        s =x1.ToString();
                        t1.Text = s;
                        op = 0;
                        x2 = 1;
                        point = 0;
                        if (s.Contains(','))
                        {
                            ii = s.IndexOf(',');
                            ch = s.Substring(0, ii).Length;
                            if (s.Contains("-"))
                            {
                                m1 = -1;
                            }
                            else { m1 = 1; }
                            if (ch <= n1)
                            {
                                point = 1;
                                ch = s.Substring(ii + 1).Length;
                            }
                            s3 += t1.Text;
                            if (t2.Text != "")
                            {
                                t2.Text = s3 + "\n" + t2.Text;
                            }
                            else
                            {
                                t2.Text = s3;
                            }
                        }
                        else
                        {
                            ch = s.Length; point = 0; if (s.Contains("-"))
                            {
                                m1 = -1;
                            }
                            else { m1 = 1; }
                        }
                        ii = -365;
                        
                    }
                    
                    
                    if (t1.Text.Length + 1 > 9)
                    {
                        t1.FontSize = 52;
                    }
                    else t1.FontSize = 130;
                }
                if (op == 0 & x2 == 1 & b.Content.ToString() != "=" & ch <= n1 & ii != -365)
                {
                    x1 = Double.Parse(t1.Text);
                    if (b.Content.ToString() == "+")
                    {
                        op = 1;
                        s += b.Content.ToString();
                        ii = s.Length - 1;
                        t1.Text = s;
                        ch = 0;
                        point = 0;
                    }
                    else if (b.Content.ToString() == "-")
                    {
                        op = 2;
                        s += b.Content.ToString();
                        ii = s.Length - 1;
                        t1.Text = s;
                        ch = 0;
                        point = 0;
                    }
                    else if (b.Content.ToString() == "/")
                    {
                        op = 3;
                        s += b.Content.ToString();
                        ii = s.Length - 1;
                        t1.Text = s;
                        ch = 0;
                        point = 0;
                    }
                    else if (b.Content.ToString() == "X")
                    {
                        op = 4;
                        s += "x";
                        ii = s.Length - 1;
                        t1.Text = s;
                        ch = 0;
                        point = 0;
                    }
                    else if (b.Content.ToString() == "log")
                    {
                        op = 6;
                        
                        if (x1 > 0)
                        {
                            s = "log(" + s + ",";
                            ii = s.Length - 1;
                            ch = 0;
                            point = 0;
                            
                            t1.Text = s;
                            ch = 0;
                            point = 0;
                        }
                        else { t1.Text = "Нельзя вычислить логорифм"; ch = n1 * 2; t1.FontSize = 50; }
                    }
                    else
                    {
                        op = 5;
                        s += "^";
                        ii = s.Length - 1;
                        t1.Text = s;
                        ch = 0;
                        point = 0;
                    }
                    
                }
                else if (op != 0 & ch == 0 & b.Content.ToString() != "=" & ch <= n1 & op != 6 & ii != -365)
                {
                    s = s.Substring(0, s.Length - 1);
                    if (b.Content.ToString() == "+")
                    {
                        op = 1;
                        s += b.Content.ToString();
                        ii = s.Length - 1;
                    }
                    else if (b.Content.ToString() == "-")
                    {
                        op = 2;
                        s += b.Content.ToString();
                        ii = s.Length - 1;
                    }
                    else if (b.Content.ToString() == "/")
                    {
                        op = 3;
                        s += b.Content.ToString();
                        ii = s.Length - 1;
                    }
                    else if (b.Content.ToString() == "X")
                    {
                        op = 4;
                        s += "x";
                        ii = s.Length - 1;
                    }
                    else
                    {
                        op = 5;
                        s += "^";
                        ii = s.Length - 1;
                    }
                    t1.Text = s;
                    ch = 0;
                    point = 0;
                }
            }
            if(t1.Text == "-0")
            {
                x1 = 0;
                s = "0";
                op = 0;
                point = 0;
                ch = 1;
                t1.Text = s;
                ii = 0;
                m1 = 1;
            }
            if (t1.Text == "-0")
            {
                x1 = 0;
                s = "0";
                op = 0;
                point = 0;
                ch = 1;
                t1.Text = s;
                ii = 0;
                m1 = 1;
            }
            if (ii == -365) { ii = 0; }
        }

        private void MinusOrPlus(object sender, RoutedEventArgs e)
        {
            if (t1.Text.Length + 1 > 9)
            {
                t1.FontSize = 52;
            }
            else t1.FontSize = 130;
            if (ch > n1)
            {
                t1.Text = "0";
                s = "0";
                point = 0;
                ch = 1;
                op = 0;
                x1 = 1; m1 = 1;
                x2 = 1;
                t1.FontSize = 130;
            }
            {
                if (op == 0)
                {
                    m1 *= -1;
                    if (t1.Text == "0")
                    {
                        s = "-";
                        t1.Text = s;
                    }
                    else if (t1.Text == "-")
                    {
                        s = "0";
                        t1.Text = s;
                    }
                    else
                    {
                        x1 = Math.Abs(Double.Parse(s)) * m1;
                        s = x1.ToString();
                        x1 = 1;
                        t1.Text = s;

                    }
                }
                else if (op == 1)
                {
                    op = 2;
                    if (s.Length + 1 != ii)
                    {
                        s = s.Substring(0, ii) + "-" + s.Substring(ii + 1);
                    }
                    else s = s.Substring(0, ii) + "-";
                    t1.Text = s;
                }
                else if (op == 2)
                {
                    op = 1;
                    if (s.Length + 1 != ii)
                    {
                        s = s.Substring(0, ii) + "+" + s.Substring(ii + 1);
                    }
                    else s = s.Substring(0, ii) + "+";
                    t1.Text = s;
                }
                else if (op == 3 || op == 4)
                {
                    if (m1 > 0)
                    {
                        s = "-" + s;
                        x1 *= (-1);
                        t1.Text = s;
                        ii += 1;
                    }
                    else
                    {
                        s = s.Substring(1);
                        t1.Text = s;
                        ii -= 1;
                        x1 *= (-1);
                    }
                    m1 *= -1;
                }else if (op == 5)
                {
                    if (s.Contains("-"))
                    {
                        if (ii + 1 == s.Length)
                        {
                            s = s + "-";
                            t1.Text = s;
                        }
                        else
                        {
                            s = s.Substring(0,ii+1)+ "-" + s.Substring(ii+1);
                        }
                    }
                    else
                    {
                        if(ii+1 == s.Length)
                        {
                            s =s.Substring(0, ii+1);
                            t1.Text = s;
                        }
                        else
                        {
                            s = s.Substring(ii+2);
                            t1.Text = s;
                        }
                    }
                }
            }
            if (t1.Text == "-0")
            {
                x1 = 0;
                s = "0";
                op = 0;
                point = 0;
                ch = 1;
                t1.Text = s;
                ii = 0;
                m1 = 1;
            }
        }

        
        private void Bpoint(object sender, RoutedEventArgs e)
        {
            if (ch > n1)
            {
                t1.Text = "0";
                s = "0";
                point = 0;
                ch = 1;
                op = 0;
                x1 = 1;
                x2 = 1;
                m1 = 1;
                t1.FontSize = 130;
            }
            else if (ch != 0)
            {
                if (t1.Text.Length + 1 > 9)
                {
                    t1.FontSize = 52;
                }
                else t1.FontSize = 130;
                if (ch > n1)
                {
                    t1.Text = "0";
                    s = "0";
                    point = 0;
                    ch = 1; m1 = 1;
                    op = 0;
                    x1 = 1;
                    x2 = 1;
                    t1.FontSize = 130;
                }
                else
                {
                    if (point == 0)
                    {
                        point = 1;
                        ch = 0;
                        s += ",";
                        t1.Text = s;
                    }
                }
            }
            if (t1.Text == "-0")
            {
                x1 = 0;
                s = "0";
                op = 0;
                point = 0;
                ch = 1;
                t1.Text = s;
                ii = 0;
                m1 = 1;
            }
        }




        private void Num(object sender, RoutedEventArgs e)
        {
            if (t1.Text.Length + 1 > 9)
            {
                t1.FontSize = 52;
            }
            else t1.FontSize = 130;
            if (ch > n1)
            {
                t1.Text = "0";
                s = "0";
                point = 0;
                ch = 1;
                op = 0;
                x1 = 1;
                x2 = 1;
                m1 = 1;
                t1.FontSize = 130;
            }
            else { 
                Button b = (Button)sender;
            if(b.Content.ToString() == "e" & ((ch == 0 ) ||  (t1.Text == "0")))
            {
                    x1 = Math.Round(Math.E,6);
                    ch = 6;
                    point = 1;
                    s = x1.ToString();
                    t1.Text = s;
            } else
            if (b.Content.ToString() == "pi" & ((ch == 0) || (t1.Text == "0")))
                {
                    x1 = Math.Round(Math.PI, 6);
                    ch = 6;
                    point = 1;
                    s = x1.ToString();
                    t1.Text = s;
                }
                else if(b.Content.ToString() != "pi" & b.Content.ToString() != "e")
                {
                    if (ch < n1 & point == 0)
                    {

                        if (t1.Text == "0")
                        {
                            s = b.Content.ToString() + "";
                        }
                        else if (op == 0 || ch == 0) { s += b.Content.ToString(); ch++; }
                        else if (s.Substring(s.Length - 1) != "0") { s += b.Content.ToString(); ch++; }
                    }
                    else if (ch < n2)
                    {
                        s += b.Content.ToString();
                        ch += 1;
                    }
                    t1.Text = s;
                }
            }
            if (t1.Text == "-0")
            {
                x1 = 0;
                s = "0";
                op = 0;
                point = 0;
                ch = 1;
                t1.Text = s;
                ii = 0;
                m1 = 1;
            }
        }
        
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
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

namespace CalcGUI
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        static readonly string FailMessage = "計算失敗";
        static decimal num = 0;
        static string inKey = null;
        static string ope = null;
        static decimal result = 0;
        static decimal d = 0;
        static string Ans = null;
        public void button0_Click(object sender, RoutedEventArgs e)
        {
            inKey = "0";
            if (formula.Text.EndsWith("."))
            {
                formula.Text = formula.Text + inKey;
            }
            else if (decimal.TryParse(formula.Text, out d))
            {
                formula.Text = (System.Convert.ToDecimal(formula.Text) * 10 + System.Convert.ToDecimal(inKey)).ToString();
            }
            else
            {
                formula.Text = inKey;
            }
        }

        public void button1_Click(object sender, RoutedEventArgs e)
        {
            inKey = "1";
            if (formula.Text.EndsWith("."))
            {
                formula.Text = formula.Text + inKey;
            }
            else if (decimal.TryParse(formula.Text, out d))
            {
                formula.Text = (System.Convert.ToDecimal(formula.Text) * 10 + System.Convert.ToDecimal(inKey)).ToString();
            }
            else
            {
                formula.Text = inKey;
            }
        }

        public void button2_Click(object sender, RoutedEventArgs e)
        {
            inKey = "2";
            if (formula.Text.EndsWith("."))
            {
                formula.Text = formula.Text + inKey;
            }
            else if (decimal.TryParse(formula.Text, out d))
            {
                formula.Text = (System.Convert.ToDecimal(formula.Text) * 10 + System.Convert.ToDecimal(inKey)).ToString();
            }
            else
            {
                formula.Text = inKey;
            }
        }

        public void button3_Click(object sender, RoutedEventArgs e)
        {
            inKey = "3";
            if (formula.Text.EndsWith("."))
            {
                formula.Text = formula.Text + inKey;
            }
            else if (decimal.TryParse(formula.Text, out d))
            {
                formula.Text = (System.Convert.ToDecimal(formula.Text) * 10 + System.Convert.ToDecimal(inKey)).ToString();
            }
            else
            {
                formula.Text = inKey;
            }
        }

        public void button4_Click(object sender, RoutedEventArgs e)
        {
            inKey = "4";
            if (formula.Text.EndsWith("."))
            {
                formula.Text = formula.Text + inKey;
            }
            else if (decimal.TryParse(formula.Text, out d))
            {
                formula.Text = (System.Convert.ToDecimal(formula.Text) * 10 + System.Convert.ToDecimal(inKey)).ToString();
            }
            else
            {
                formula.Text = inKey;
            }
        }

        public void button5_Click(object sender, RoutedEventArgs e)
        {
            inKey = "5";
            if (formula.Text.EndsWith("."))
            {
                formula.Text = formula.Text + inKey;
            }
            else if (decimal.TryParse(formula.Text, out d))
            {
                formula.Text = (System.Convert.ToDecimal(formula.Text) * 10 + System.Convert.ToDecimal(inKey)).ToString();
            }
            else
            {
                formula.Text = inKey;
            }
        }

        public void button6_Click(object sender, RoutedEventArgs e)
        {
            inKey = "6";
            if (formula.Text.EndsWith("."))
            {
                formula.Text = formula.Text + inKey;
            }
            else if (decimal.TryParse(formula.Text, out d))
            {
                formula.Text = (System.Convert.ToDecimal(formula.Text) * 10 + System.Convert.ToDecimal(inKey)).ToString();
            }
            else
            {
                formula.Text = inKey;
            }
        }

        public void button7_Click(object sender, RoutedEventArgs e)
        {
            inKey = "7";
            if (formula.Text.EndsWith("."))
            {
                formula.Text = formula.Text + inKey;
            }
            else if (decimal.TryParse(formula.Text, out d))
            {
                formula.Text = (System.Convert.ToDecimal(formula.Text) * 10 + System.Convert.ToDecimal(inKey)).ToString();
            }
            else
            {
                formula.Text = inKey;
            }
        }

        public void button8_Click(object sender, RoutedEventArgs e)
        {
            inKey = "8";
            if (formula.Text.EndsWith("."))
            {
                formula.Text = formula.Text + inKey;
            }
            else if (decimal.TryParse(formula.Text, out d))
            {
                formula.Text = (System.Convert.ToDecimal(formula.Text) * 10 + System.Convert.ToDecimal(inKey)).ToString();
            }
            else
            {
                formula.Text = inKey;
            }
        }

        public void button9_Click(object sender, RoutedEventArgs e)
        {
            inKey = "9";
            if (formula.Text.EndsWith("."))
            {
                formula.Text = formula.Text + inKey;
            }
            else if (decimal.TryParse(formula.Text, out d))
            {
                formula.Text = (System.Convert.ToDecimal(formula.Text) * 10 + System.Convert.ToDecimal(inKey)).ToString();
            }
            else
            {
                formula.Text = inKey;
            }
        }

        public void buttonP_Click(object sender, RoutedEventArgs e)
        {
            inKey = "+";
            if (formula.Text == FailMessage)
            {
                formula.Text = "0";
            }
            else if (ope == null)
            {
                result = System.Convert.ToDecimal(formula.Text);
                ope = inKey;
                formula.Text = inKey;
            }
            /*else
            {
                Calc();
                formula.Text = ope;
                Clear();
            }*/
        }
        public void buttonM_Click(object sender, RoutedEventArgs e)
        {
            inKey = "-";
            if (formula.Text == FailMessage)
            {
                formula.Text = "0";
            }
            else if (ope == null)
            {
                result = System.Convert.ToDecimal(formula.Text);
                ope = inKey;
                formula.Text = inKey;
            }
            /*else
            {
                Calc();
                formula.Text = ope;
                Clear();
            }*/
        }
        public void buttonD_Click(object sender, RoutedEventArgs e)
        {
            inKey = "/";
            if (formula.Text == FailMessage)
            {
                formula.Text = "0";
            }
            else if (ope == null)
            {
                result = System.Convert.ToDecimal(formula.Text);
                ope = inKey;
                formula.Text = inKey;
            }
            /*else
            {
                Calc();
                formula.Text = ope;
                Clear();
            }*/
        }
        public void buttonT_Click(object sender, RoutedEventArgs e)
        {
            inKey = "*";
            if (formula.Text == FailMessage)
            {
                formula.Text = "0";
            }
            else if (ope == null)
            {
                result = System.Convert.ToDecimal(formula.Text);
                ope = inKey;
                formula.Text = inKey;
            }
            /*else
            {
                num = System.Convert.ToDecimal(formula.Text);
                Calc();
                formula.Text = ope;
                Clear();
            }*/
        }
        public void buttonAC_Click(object sender, RoutedEventArgs e)
        {
            inKey = "AC";
            formula.Text = "0";
            Clear();
        }
        public void buttonE_Click(object sender, RoutedEventArgs e)
        {
            inKey = "=";
            if (formula.Text == FailMessage)
            {
                formula.Text = "0";
            }
            else if (ope == null)
            {
                formula.Text = "0";
            }
            else
            {
                num = System.Convert.ToDecimal(formula.Text);
                Calc();
                formula.Text = System.Convert.ToString(result);
                Clear();
                Ans = formula.Text;
            }
        }

        public void buttonDP_Click(object sender, RoutedEventArgs e)
        {
            inKey = ".";
            if (decimal.TryParse(formula.Text, out d))
            {
                formula.Text = formula.Text + inKey;
            }
            else
            {
                formula.Text = "0";
            }
        }
        public void buttonF_Click(object sender, RoutedEventArgs e)
        {
            inKey = "^";
            if (formula.Text == FailMessage)
            {
                formula.Text = "0";
            }
            else if (ope == null)
            {
                result = System.Convert.ToDecimal(formula.Text);
                ope = inKey;
                formula.Text = inKey;
            }
        }

        public void buttonAns_Click(object sender, RoutedEventArgs e)//Recall of previous calculation result
        {
            inKey = "Ans";
            if(!decimal.TryParse(formula.Text, out d))
            {
                formula.Text = Ans;
            }
        }

        public static void Calc()
        {
            switch (ope)
            {
                case "+":
                    result = result + num;
                    break;
                case "-":
                    result = result - num;
                    break;
                case "*":
                    result = result * num;
                    break;
                case "/":
                    if (num != 0)
                    {
                        result = result / num;
                    }
                    else
                    {
                        result = 0;
                    }
                    break;
                case "^":
                    result = Powd(result, num);
                    break;
            }
            
        }
        public static void Clear()
        {
            inKey = null;
            num = 0;
            ope = null;
            result = 0;
            d = 0;
        }
        public static decimal Powd(decimal a, decimal b)
        {
            if (b == 0)
            {
                return 1;
            }
            else
            {
                return a * Powd(a, b - 1);
            }
        }
    }
}

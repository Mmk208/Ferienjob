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

namespace Taschenrechner
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private double Result = 0.0;
        private char lastOp = ' ';


        public MainWindow()
        {
            InitializeComponent();
            Feld.Text = null;
        }



        private void NumberNine_Click(object sender, RoutedEventArgs e)
        {
            Feld.Text += "9";

        }



        private void NumberEight_Click(object sender, RoutedEventArgs e)
        {
            Feld.Text += "8";

        }


        private void NumberSeven_Click(object sender, RoutedEventArgs e)
        {
            Feld.Text += "7";

        }


        private void NumberSix_Click(object sender, RoutedEventArgs e)
        {
            Feld.Text += "6";

        }


        private void NumberFive_Click(object sender, RoutedEventArgs e)
        {
            Feld.Text += "5";

        }


        private void NumberFour_Click(object sender, RoutedEventArgs e)
        {
            Feld.Text += "4";

        }


        private void NumberThree_Click(object sender, RoutedEventArgs e)
        {
            Feld.Text += "3";

        }


        private void NumberTwo_Click(object sender, RoutedEventArgs e)
        {
            Feld.Text += "2";


        }

        private void NumerOne_Click(object sender, RoutedEventArgs e)
        {
            Feld.Text += "1";

        }


        private void NumberZero_Click(object sender, RoutedEventArgs e)
        {
            Feld.Text += "0";

        }


        private void Addition_Click(object sender, RoutedEventArgs e)
        {
            calc(Convert.ToDouble(Feld.Text), lastOp);
            lastOp = '+';
            Feld.Text = null;

        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            calc(Convert.ToDouble(Feld.Text), lastOp);
            lastOp = '-';
            Feld.Text = null;
        }
        private void Multiplicate_Click(object sender, RoutedEventArgs e)
        {
            calc(Convert.ToDouble(Feld.Text), lastOp);
            lastOp = '*';
            Feld.Text = null;

        }
        private void Division_Click(object sender, RoutedEventArgs e)
        {
            calc(Convert.ToDouble(Feld.Text), lastOp);
            lastOp = '/';
            Feld.Text = null;
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            calc(Convert.ToDouble(Feld.Text), lastOp);
            Feld.Text = Result.ToString();


        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Feld.Text = null;
            lastOp = ' ';
            Result = 0.0;
        }

        private void calc (double doubleValue, char chrOp)
        {
            switch (chrOp)
            {
                case '+':
                    Result += doubleValue;
                    break;
                case '-':
                    Result -= doubleValue;
                    break;
                case '*':
                    Result *= doubleValue;
                    break;
                case '/':
                    Result /= doubleValue;
                    break;
                case ' ':
                    Result = doubleValue;
                    break;
            }
        }

        private void Dot_Click(object sender, RoutedEventArgs e)
        {
            Feld.Text += ",";
        }
    }
}


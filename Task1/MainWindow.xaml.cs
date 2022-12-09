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

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateEuro.Text);
            double sum = Convert.ToDouble(sumEuro.Text);
            double res = rate * sum;
            resEuro.Text = res.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateHryv.Text);
            double sum = Convert.ToDouble(sumHryv.Text);
            double res = rate * sum;
            resHryv.Text = res.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateDram.Text);
            double sum = Convert.ToDouble(sumDram.Text);
            double res = rate * sum;
            resDram.Text = res.ToString();

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateInch.Text);
            double res = rate * 0.0254;
            resInchMeter.Text = res.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateFoot.Text);
            double res = rate * 0.3048;
            resFootMeter.Text = res.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateMile.Text);
            double res = rate * 1609.34;
            resMileMeter.Text = res.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateVerst.Text);
            double res = rate * 1066.8;
            resVerstMeter.Text = res.ToString();
        }
    }
}

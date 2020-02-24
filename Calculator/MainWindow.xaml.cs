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

namespace Calculator
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int firstNumber = int.Parse(txbFirstNumber.Text);
            int secondNumber = int.Parse(txbSecondNumber.Text);

            lblSumResult.Content = firstNumber + " + " + secondNumber + " = " + (firstNumber + secondNumber);
            lblSubResult.Content = firstNumber + " - " + secondNumber + " = " + (firstNumber - secondNumber);
            lblDivResult.Content = firstNumber + " / " + secondNumber + " = " + (firstNumber / secondNumber);
            lblMultResult.Content = firstNumber + " * " + secondNumber + " = " + (firstNumber * secondNumber);

        }
    }
}

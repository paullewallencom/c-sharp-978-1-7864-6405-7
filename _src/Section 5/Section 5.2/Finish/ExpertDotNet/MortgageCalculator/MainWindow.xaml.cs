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

namespace MortgageCalculator
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

        // Variables
        static public double amountBorrowed { get; set; }
        static public double interestRate { get; set; }
        static public int mortgagePeriod { get; set; }

        private void btn_Calculate_Click(object sender, RoutedEventArgs e)
        {
            // Get & Parse values
            amountBorrowed = (double)Int32.Parse(Amount.Text);

            decimal result;
            if(Decimal.TryParse(Interest.Text, out result))
            interestRate = (double)result;

            mortgagePeriod = Int32.Parse(Period.Text);

            // Calculate mortgage
            MonthlyPayments.Text = CalcMortgage(amountBorrowed, interestRate, mortgagePeriod);
            
        }

        private string CalcMortgage(double amountBorrowed, double interestRate, int mortgagePeriod)
        {
            double p = amountBorrowed;
            double r = ConvertToMonthlyInterest(interestRate);
            double n = YearsToMonths(mortgagePeriod);

            var c = (decimal)(((r * p) * Math.Pow((1 + r),n)) / (Math.Pow((1 + r), n) - 1));

            return ($"${Math.Round(c,MidpointRounding.AwayFromZero)}");
        }

        private int  YearsToMonths(int years)
        {
            return (12 * years);
        }

        private double ConvertToMonthlyInterest(double percent)
        {
            return (percent / 12) / 100;
        }
    }
}

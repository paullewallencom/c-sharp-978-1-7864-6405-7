using System;
using System.Windows;
using static System.Int32;
using static System.MidpointRounding;
using static System.Math;

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
            amountBorrowed = (double)Parse(Amount.Text);

            decimal result;
            if(Decimal.TryParse(Interest.Text, out result))
            interestRate = (double)result;

            mortgagePeriod = Parse(Period.Text);

            // Calculate mortgage
            MonthlyPayments.Text = CalcMortgage(amountBorrowed, interestRate, mortgagePeriod);
            
        }

        private string CalcMortgage(double amountBorrowed, double interestRate, int mortgagePeriod)
        {
            double p = amountBorrowed;
            double r = ConvertToMonthlyInterest(interestRate);
            double n = YearsToMonths(mortgagePeriod);

            var c = (decimal)(((r * p) * Pow((1 + r),n)) / (Pow((1 + r), n) - 1));

            return ($"${Round(c,AwayFromZero)}");
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

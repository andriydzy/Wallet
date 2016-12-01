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

namespace Wallet
{
    interface IMoney
    {
        double MoneyCount { get; set; }
        bool SetMoney(double count);
        bool GetMoney(double count);
        double CountMoney();
    }
    interface ICreditCard
    {
        IMoney money { get; set; }
        bool GetCredit(double count);
        bool PayOffCredit(double count);
    }
    interface IBuisnesCard
    {
        IMoney money { get; set; }
        ICreditCard creditCard {get;set;}
        void GetCreditMoney(double count);
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();			
        }

        private void GetFromBuisnes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SetToBuisnes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CountBuisnes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GetFromCredit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SetToCredit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GetCredit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PayOfCredit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CountCredit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

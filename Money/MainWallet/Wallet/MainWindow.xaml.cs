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
   public interface IMoney
    {
        double MoneyCount { get; set; }
        bool SetMoney(double count);
        bool GetMoney(double count);
        double CountMoney();
    }
   public interface ICreditCard
    {
        IMoney money { get; set; }
        bool GetCredit(double count);
        bool PayOffCredit(double count);
    }
   public interface IBuisnesCard
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
    }
}

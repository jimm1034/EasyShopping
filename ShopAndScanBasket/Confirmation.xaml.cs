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
using System.Windows.Shapes;

namespace EasyShopping
{
    /// <summary>
    /// Interaction logic for Confirmation.xaml
    /// </summary>
    public partial class Confirmation : Window
    {
        public Confirmation()
        {
            InitializeComponent();
        }

        private void Button_Click_True(object sender, RoutedEventArgs e)
        {
            PaymentWindow pay = new PaymentWindow();
            pay.Show();
            this.Close();
        }

        private void Button_Click_False(object sender, RoutedEventArgs e)
        {
            ShoppingBasket m = new ShoppingBasket();
            m.Show();
            this.Close();
        }
    }
}

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
    /// Interaction logic for ShoppingBasketWithoutList.xaml
    /// </summary>
    public partial class ShoppingBasketWithoutList : Window
    {
        public ShoppingBasketWithoutList()
        {
            InitializeComponent();
        }

        private void ShoppingDone_Click(object sender, RoutedEventArgs e)
        {
            Confirmation con = new Confirmation();
            con.Show();
            this.Close();
        }
    }
}

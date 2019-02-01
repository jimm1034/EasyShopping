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
    /// Interaction logic for ShoppingEnded.xaml
    /// </summary>
    public partial class ShoppingEnded : Window
    {
        public ShoppingEnded()
        {
            InitializeComponent();
        }

        private void BackToMainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void Reciepts_Click(object sender, RoutedEventArgs e)
        {
            Reciepts reciepts = new Reciepts();
            reciepts.Show();
            this.Close();
        }
    }
}

using System;
using System.Collections;
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
    /// Interaction logic for Reciepts.xaml
    /// </summary>
    public partial class Reciepts : Window
    {
        private ArrayList myDataList;

        public Reciepts()
        {
            InitializeComponent();
            myDataList = LoadListBoxData();             // Get List from Method -- Method is only temp and should be changed to retrieve list from web
            recieptList.ItemsSource = myDataList;  // Bind ArrayList with the ListBox
        }

        private ArrayList LoadListBoxData()             //Temp List
        {
            ArrayList recieptsFromUser = new ArrayList();
            recieptsFromUser.Add("19 Jan 2019 Klokken 10:43 Bilka Odense");
            recieptsFromUser.Add("13 Jan 2019 Klokken 11:03 Bilka Odense");
            recieptsFromUser.Add("08 Jan 2019 Klokken 09:19 Bilka Odense");
            recieptsFromUser.Add("28 Dec 2018 Klokken 13:23 Bilka Odense");
            return recieptsFromUser;
        }
    }
}

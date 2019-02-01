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
    /// Interaction logic for ShoppingBasket.xaml
    /// </summary>
    /// 
    public partial class ShoppingBasket : Window
    {
        private ArrayList myDataList;
        private string currentItemText;

        public ShoppingBasket()
        {
            InitializeComponent();
            myDataList = LoadListBoxData();             // Get List from Method -- Method is only temp and should be changed to retrieve list from web
            showShoppingList.ItemsSource = myDataList;  // Bind ArrayList with the ListBox  
        }
        
        private ArrayList LoadListBoxData()             //Temp List
        {
            ArrayList itemsList = new ArrayList();
            itemsList.Add("Brød");
            itemsList.Add("250g Smør");
            itemsList.Add("Ost");
            itemsList.Add("2 Liter Mælk");
            return itemsList;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Find the right item and it's value and index  
            currentItemText = showShoppingList.SelectedValue.ToString();
            int currentItemIndex = showShoppingList.SelectedIndex;

            showBasketList.Items.Add(currentItemText);
            if (myDataList != null)
            {
                myDataList.RemoveAt(currentItemIndex);
            }

            BindToList();
        }
        
        private void BindToList()
        {
            showShoppingList.ItemsSource = null;
            showShoppingList.ItemsSource = myDataList;
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e) //Bug ikke fixet når man trykker uden at vælge objekt først
        {
                // Find the selected item with value and index  
                currentItemText = showBasketList.SelectedValue.ToString();
                int currentItemIndex = showBasketList.SelectedIndex;

                myDataList.Add(currentItemText);                                                            // Add item to the ArrayList  
                showBasketList.Items.RemoveAt(showBasketList.Items.IndexOf(showBasketList.SelectedItem));   // Remove from BasketList            
                BindToList();                                                                               // Call Method BindToList to update 
        }

        private void ShoppingDone_Click(object sender, RoutedEventArgs e)
        {
            Confirmation con = new Confirmation();
            con.Show();
            this.Close();
        }

        private void ShowShoppingList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            // Find the right item and it's value and index  
            currentItemText = showShoppingList.SelectedValue.ToString();
            int currentItemIndex = showShoppingList.SelectedIndex;

            showBasketList.Items.Add(currentItemText);
            if (myDataList != null)
            {
                myDataList.RemoveAt(currentItemIndex);
            }

            BindToList();
        }
    }
}

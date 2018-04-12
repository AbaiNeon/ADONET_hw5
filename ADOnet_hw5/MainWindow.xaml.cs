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

namespace ADOnet_hw5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            myComboBox.ItemsSource = new string[] { "buyers", "sellers", "deals" };
            
        }

        private void myComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            using (var db = new Model1())
            {
                var shortBuyers = (from buyers in db.Buyers
                                   select new { id = buyers.Buyer_id, firstName = buyers.firstName, lastName = buyers.LastName }).ToList();
                var shortSellers = (from sellers in db.Sellers
                                    select new { id = sellers.Seller_id, firstName = sellers.firstName, lastName = sellers.LastName }).ToList();
                var shortDeals = (from deals in db.Deals
                                  select new { id = deals.Deal_id, sellerId = deals.seller_id, buyerId = deals.buyer_id, sum = deals.sum, date = deals.deal_date }).ToList();


                ComboBox comboBox = (ComboBox)sender;
                //ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;

                string tmp = comboBox.SelectedItem.ToString();

                if (tmp == "buyers")
                {
                    myDataGrid.ItemsSource = shortBuyers;
                }
                else if (tmp == "sellers")
                {
                    myDataGrid.ItemsSource = shortSellers;
                }
                else if (tmp == "deals")
                {
                    myDataGrid.ItemsSource = shortDeals;
                }
            }
        }
    }
}

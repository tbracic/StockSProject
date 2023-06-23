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
using StockS.Logic.Items;
namespace Stocks.UI.Dialogs
{
    /// <summary>
    /// Interaction logic for ChangePrice.xaml
    /// </summary>
    public partial class ChangePrice : Window
    {
        public ItemRepositroy repositroy;
        public int selectedItem=0;
        public ChangePrice()
        {
            InitializeComponent();
            repositroy = new ItemRepositroy();
            ItemBox.ItemsSource = repositroy.GetAllItemNames();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try {
                float price1 =float.Parse(oldPrice.Text);
                float price2 = float.Parse(newPrice.Text);
                repositroy.ChangePrice(selectedItem,price1,price2);
                this.Close();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ItemBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedItem=repositroy.GetItemID(ItemBox.SelectedItem.ToString());
            oldPrice.Text = repositroy.GetItem(selectedItem).Price.ToString();
        }
    }
}

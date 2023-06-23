using StockS.Logic.Items;
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
using StockS.Logic.Items;
using StockS.Logic.Inventory;
using System.Diagnostics;
using Stocks.UI.MWM.ViewModel;

namespace Stocks.UI.MWM.View
{
    /// <summary>
    /// Interaction logic for ItemView.xaml
    /// </summary>
    public partial class ItemView : UserControl
    {

        public ItemRepositroy repositroy;
        public ItemView()
        {
            InitializeComponent();
            repositroy = new ItemRepositroy();
            List<Item> items = repositroy.GetAllItems();
            dgvItems.ItemsSource = items;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InventoryRepository repos2 = new InventoryRepository();
            repos2.CreatePDFList("PDFList");
            Process.Start("explorer.exe", "PDFList.pdf");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window window = new Stocks.UI.Dialogs.NewCompany();
            window.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window window = new Stocks.UI.Dialogs.ChangePrice();
            window.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window window = new Stocks.UI.Dialogs.NewItem();
            window.Show();
        }
    }
}

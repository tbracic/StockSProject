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
using StockS.Logic.Inventory;
using StockS.Logic.Items;

namespace Stocks.UI.Dialogs
{
    /// <summary>
    /// Interaction logic for NewInventory.xaml
    /// </summary>
    public partial class NewInventory : Window
    {
        public InventoryRepository repository;
        public ItemRepositroy repo1;
        public struct MyData
        {
            public string name { get; set; }
            public int quantity { get; set; }
        }

        public int i = 1;
        public NewInventory()
        {
            InitializeComponent();
            repo1 = new ItemRepositroy();
            leftItems.Text = repo1.GetAllItems().Count.ToString();
            DataGridTextColumn col1 = new DataGridTextColumn();
            DataGridTextColumn col2 = new DataGridTextColumn();
            dgvNewItems.Columns.Add(col1);
            dgvNewItems.Columns.Add(col2);
            col1.Binding = new Binding("name");
            col2.Binding = new Binding("quantity");
            col1.Header = "Name";
            col2.Header = "Quantity";
            currentItem.Text = repo1.GetItemName(i);

            btnAdd.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try 
            {
                int quantity2 = int.Parse(newquantity.Text);
                string name2 = currentItem.Text;
                dgvNewItems.Items.Add(new MyData { name = name2, quantity = quantity2 });
                currentItem.Text = repo1.GetItemName(++i);
                if (currentItem.Text == "")
                {
                    btnAdd.IsEnabled = true;
                    btnAdd2.IsEnabled = false;
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try 
            {
                repository = new InventoryRepository();
                int invid = repository.GetAllInventories().Count + 1;
                Inventory inventory = new Inventory(invid, DateTime.Now.ToString(), 11111111111);
                List<QuantityHistory> items = new List<QuantityHistory>();
                foreach(MyData row in dgvNewItems.Items)
                {
                    QuantityHistory quantityHistory = new QuantityHistory(repo1.GetItemID(row.name), invid,row.quantity);
                    items.Add(quantityHistory);
                }
                repository.CreateNewInventory(inventory, items);
                Close();
            }
            catch (Exception ex) { }
        }
    }
}

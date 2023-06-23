using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
using StockS.Logic.Conclusion;
using StockS.Logic.Items;

namespace Stocks.UI.Dialogs
{
    /// <summary>
    /// Interaction logic for NewConclusion.xaml
    /// </summary>
    public partial class NewConclusion : Window
    {
        public ItemRepositroy repositroy;
        public struct MyData
        {
            public string name { get; set; }
            public int quantity { get; set; }

        }
        public NewConclusion()
        {
            InitializeComponent();
            repositroy = new ItemRepositroy();
            cboxItem.ItemsSource = repositroy.GetAllItemNames();
            DataGridTextColumn col1 = new DataGridTextColumn();
            DataGridTextColumn col2 = new DataGridTextColumn();
            dgvNewItems.Columns.Add(col1);
            dgvNewItems.Columns.Add(col2);
            col1.Binding = new Binding("name");
            col2.Binding = new Binding("quantity");
            col1.Header = "Name";
            col2.Header = "Quantity";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try 
            {
                string date = DateTime.Now.ToString();
                long user = 11111111111;
                int shift = 1;
                ConclusionRepositroy repository2 = new ConclusionRepositroy();
                repositroy = new ItemRepositroy();
                repository2.CreateNewConclusion(date, shift, user);
                foreach (MyData row in dgvNewItems.Items)
                {
                    repository2.CreateNewSoldItem(repositroy.GetItemID(row.name), row.quantity);
                }
                Close();
            }
            catch(Exception ex) { } 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try 
            {
                int quantity2 = int.Parse(txtQuantity.Text);
                string name2 = cboxItem.SelectedItem.ToString();

                dgvNewItems.Items.Add(new MyData { name=name2 , quantity = quantity2 });
            }
            catch (Exception ex) { }
        }
    }

}

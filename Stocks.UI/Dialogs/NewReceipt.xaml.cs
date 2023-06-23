using StockS.Logic.Conclusion;
using StockS.Logic.Items;
using StockS.Logic.Receipt;
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

namespace Stocks.UI.Dialogs
{
    /// <summary>
    /// Interaction logic for NewReceipt.xaml
    /// </summary>
    public partial class NewReceipt : Window
    {
        public ItemRepositroy repositroy;
        public struct MyData
        {
            public string name { get; set; }
            public int quantity { get; set; }
            public float pprice { get; set; }

        }
        public NewReceipt()
        {
            InitializeComponent();
            repositroy = new ItemRepositroy();
            cboxItem.ItemsSource = repositroy.GetAllItemNames();
            cboxCompany.ItemsSource = repositroy.GetAllCompaniesNames();
            DataGridTextColumn col1 = new DataGridTextColumn();
            DataGridTextColumn col2 = new DataGridTextColumn();
            DataGridTextColumn col3 = new DataGridTextColumn();
            dgvNewItems.Columns.Add(col1);
            dgvNewItems.Columns.Add(col2);
            dgvNewItems.Columns.Add(col3);
            col1.Binding = new Binding("name");
            col2.Binding = new Binding("quantity");
            col3.Binding = new Binding("pprice");
            col1.Header = "Name";
            col2.Header = "Quantity";
            col3.Header = "Purchuese price";
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
                float price2 = float.Parse(txtPrice.Text);

                dgvNewItems.Items.Add(new MyData { name = name2, quantity = quantity2, pprice =price2 });
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                long user = 11111111111;
                int shift = 1;
                repositroy = new ItemRepositroy();
                ReceiptRepository repo1 = new ReceiptRepository();
                string comp = cboxCompany.SelectedItem.ToString();
                long companyID = 0;
                List<Company> companies = repositroy.GetAllCompanies();
                foreach (Company company in companies)
                {
                    if (company.Name == comp) companyID = company.OIB;
                }
                int no = repo1.GetAllReceipts().Count() + 1;
                repo1.AddReceipt(no, companyID, user, DateTime.Now);
                foreach (MyData row in dgvNewItems.Items)
                {
                    Item item = repositroy.GetItem(repositroy.GetItemID(row.name));
                    repo1.AddBoughtItem(item.IdItem,no, row.quantity,row.pprice,item.Quantity);
                }
                Close();
            }
            catch (Exception ex) { }
        }
    }
}

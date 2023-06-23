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
    /// Interaction logic for NewItem.xaml
    /// </summary>
    public partial class NewItem : Window
    {
        public NewItem()
        {
            InitializeComponent();
            ItemRepositroy repositroy = new ItemRepositroy();
            boxUnit.ItemsSource = Enum.GetValues(typeof(Units));
            List<Company> list = repositroy.GetAllCompanies();
            string[] company0 = new string[list.Count];
            int i = 0;
            foreach (Company company in list)
            {
                company0[i] = company.Name;
            }
            boxCompany.ItemsSource = company0;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ItemRepositroy repositroy = new ItemRepositroy();
            try
            {
                int ItemId = int.Parse(Id.Text);
                float itemPrice = float.Parse(Price.Text);
                int quantity = int.Parse(Quantity.Text);
                int units = boxUnit.SelectedIndex;
                string companyName = boxCompany.SelectedItem.ToString();
                long companyID = 0;
                List<Company> list = repositroy.GetAllCompanies();
                foreach (Company company in list)
                {
                    if (company.Name == companyName)
                    {
                        companyID = company.OIB;
                    }
                }
                repositroy.AddNewItem(ItemId, Name.Text, itemPrice, quantity, units, companyID);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }
    }
}

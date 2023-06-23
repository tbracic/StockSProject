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
    /// Interaction logic for NewCompany.xaml
    /// </summary>
    public partial class NewCompany : Window
    {
        public NewCompany()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try {
                ItemRepositroy repositroy = new ItemRepositroy();
                long oib = long.Parse(txtOib.Text);
                string name = txtName.Text;
                string adress = txtAddress.Text;
                string telephone = txtPhone.Text;
                string email = txtMail.Text;
                repositroy.AddNewCompany(oib, name, adress, telephone, email);
                Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }
    }
}
